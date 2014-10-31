using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Core.Medias;
using System.Runtime.InteropServices;

namespace BeamerClient
{
    public partial class Form2 : Form
    {
        public String urlToWebserver = "";

        private VlcControl vlcControl;
        private Element myNextElement;
        private delegate void InvokeDelegate();

        private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
        private const int SET_FEATURE_ON_THREAD = 0x00000001;
        private const int SET_FEATURE_ON_PROCESS = 0x00000002;
        private const int SET_FEATURE_IN_REGISTRY = 0x00000004;
        private const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;
        private const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;
        private const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;
        private const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;
        private const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;
        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        static extern int CoInternetSetFeatureEnabled(int FeatureEntry, [MarshalAs(UnmanagedType.U4)] int dwFlags, bool fEnable); 

        public Form2()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // auf Sekundärem Monitor anzeigen...
            if (Convert.ToBoolean(AppSett.getAppSetting("SecondaryDisplay")) && Screen.AllScreens.Length > 1)
            {
                if(Screen.AllScreens[0] == Screen.PrimaryScreen)
                    this.Location = new Point(Screen.AllScreens[1].WorkingArea.X, 0);
                else
                    this.Location = new Point(Screen.AllScreens[0].WorkingArea.X, 0);
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void timerPollNext_Tick(object sender, EventArgs e)
        {
            //erstmal anhalten und gucken was überhaupt los ist...
            timerPollNext.Enabled = false;

            //url zum Webskript zusammenbauen
            String url = urlToWebserver;
            if (!url.StartsWith("http://"))
                url = "http://" + url;
            if (!url.EndsWith("/"))
                url += "/";

            url += "?tpl=empty";
            url += "&mod=" + BeamerClient.Properties.Settings.Default.lpm4_module_name;
            url += "&mode=client";
            url += "&cmd=next";
            url += "&debug=1";  //serverseitigen DEBUG-Modus aktivieren (liefert immer einen korrekten JSON-String
            /* mit neuer Protokollversion wird &lastid=n überflüssig
             * if(myNextElement == null)
                url += "&lastid=2"; //url += "&lastid=0"; // im Debugmode sind hier id 0/1/2 möglich
            else
                url += "&lastid="+myNextElement.data[0].id.ToString();
            */

            try
            {
                WebRequest req = WebRequest.Create(url);
                WebResponse resp = req.GetResponse();

                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);
                StringBuilder contentBuilder = new StringBuilder();
                while (-1 != sr.Peek())
                {
                    contentBuilder.AppendLine(sr.ReadLine());
                }
                String myJsonString = contentBuilder.ToString();                //JSON-String empfangen

                resp.Close();                                                   // Ressourcen freigeben
                sr.Close();

                myNextElement = Json<Element>.Deserialize(myJsonString);    //deserialize
                ShowElement(myNextElement);                             // erstes empfangenes Element anzeigen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bitte diesen unerwarteten Fehler melden!!!");    //sollte nicht eintreten
            }
        }

        private void ShowElement(Element element)
        {
            switch (element.type)
            {
                case "image":
                    pictureBox1.BackColor = Color.Black;
                    pictureBox1.ImageLocation = element.url;
                    pictureBox1.Refresh();
                    pictureBox1.BringToFront();
                    timerPollNext.Interval = element.duration * 1000;
                    timerPollNext.Enabled = true;
                    break;
                case "movie":
                    setUpMediaplayer();
                    var media = new PathMedia(element.url);
                    vlcControl.Media = media;
                    vlcControl.BringToFront();
                    vlcControl.Play();
                    // kein nextPoll, da Länge nicht übertragen wurde. Stattdessen wird ein MediaEnde-Event geworfen und behandelt
                    break;
                case "http":
                    if(webBrowser1.Document != null)
                        webBrowser1.Document.Write("<html><head><meta http-equiv=\"Page-Exit\" content=\"blendTrans(Duration=1)\"></head><body style=\"background-color:#000;\"></body></html>");
                    webBrowser1.Url = new Uri(element.url);
                    //timerPollNext.Enabled = true;
                    webBrowser1.BeginInvoke(new InvokeDelegate(bringBrowserToFront));
                    timerPollNext.Interval = element.duration * 1000;
                    timerPollNext.Enabled = true;
                    break;
                case null:
                    panel1.BringToFront();
                    timerPollNext.Interval = 10000;
                    timerPollNext.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Elemente vom Typ '" + element.type + "' werden von dieser Version des Clients nicht unterstützt.");
                    break;
            }
        }

        private void bringBrowserToFront()
        {
            webBrowser1.BringToFront();
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            timerPollNext.Enabled = true;

            int feature = FEATURE_DISABLE_NAVIGATION_SOUNDS;
            CoInternetSetFeatureEnabled(feature, SET_FEATURE_ON_PROCESS, true);
        }
        private void setUpMediaplayer()
        {
            if (this.vlcControl == null)
            {
                this.vlcControl = new Vlc.DotNet.Forms.VlcControl();

                this.SuspendLayout();

                this.vlcControl.BackColor = System.Drawing.Color.Black;
                this.vlcControl.Dock = System.Windows.Forms.DockStyle.Fill;
                this.vlcControl.Location = new System.Drawing.Point(0, 0);
                this.vlcControl.Name = "vlcControl";
                this.vlcControl.Position = 0F;
                this.vlcControl.Rate = 0F;
                this.vlcControl.Size = new System.Drawing.Size(300, 200);
                this.vlcControl.TabIndex = 2;
                this.vlcControl.EndReached += new Vlc.DotNet.Core.VlcEventHandler<VlcControl, EventArgs>(vlcControl_EndReached);

                this.Controls.Add(this.vlcControl);

                this.ResumeLayout(false);
            }
            this.vlcControl.Time = System.TimeSpan.Parse("00:00:00");
            vlcControl.Media = new EmptyMedia("");
        }
        void vlcControl_EndReached(VlcControl sender, Vlc.DotNet.Core.VlcEventArgs<EventArgs> e)
        {
            vlcControl.Media = new EmptyMedia("");
            timerPollNext_Tick(sender, EventArgs.Empty);
        }
    }
}
