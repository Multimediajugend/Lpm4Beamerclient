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
using System.Web;
using System.Security.Cryptography;
using System.Net.Sockets;

namespace BeamerClient
{
    public partial class Form1 : Form
    {
        public Int32 currentStatus = 0;

        public Form1()
        {
            InitializeComponent();

            textBoxID.Text = AppSett.getAppSetting("ID");
            textBoxURL.Text = AppSett.getAppSetting("URL");
            textBoxUsername.Text = AppSett.getAppSetting("Username");
            if (!String.IsNullOrWhiteSpace(AppSett.getAppSetting("Password")))
                textBoxPassword.Text = aes.decryptStringFromBytes_AES(Convert.FromBase64String(AppSett.getAppSetting("Password")), Encoding.UTF8.GetBytes("boIG&T78g8fwgif9273gh87T&(%E756a"), Encoding.UTF8.GetBytes("boIG&T7h8g8fwgia"));
            checkBoxAutoStart.Checked = Convert.ToBoolean(AppSett.getAppSetting("AutoStart"));
            checkBoxSecondaryDisplay.Checked = Convert.ToBoolean(AppSett.getAppSetting("SecondaryDisplay"));
            checkBoxStartWithWindows.Checked = Convert.ToBoolean(AppSett.getAppSetting("StartWithWindows"));
        }


        #region Events

        private void buttonStart_Click(object sender, EventArgs e)
        {
            RegisterBeamerOnLPM();
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            SaveID();
        }
        private void textBoxURL_Leave(object sender, EventArgs e)
        {
            SaveURL();
        }
        private void checkBoxAutoStart_Leave(object sender, EventArgs e)
        {
            SaveAutoStart();
        }
        private void checkBoxStartWithWindows_Leave(object sender, EventArgs e)
        {
            SaveStartWithWindows();
        }
        private void checkBoxSecondaryDisplay_Leave(object sender, EventArgs e)
        {
            SaveSecondaryDisplay();
        }
        private void form2ClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            this.Show();
            currentStatus = 0;
        }

        #endregion Events

        #region Methods

        private void SaveID()
        {
            AppSett.setAppSetting("ID", textBoxID.Text);
        }
        private void SaveURL()
        {
            AppSett.setAppSetting("URL", textBoxURL.Text);
        }
        private void SaveAutoStart()
        {
            AppSett.setAppSetting("AutoStart", checkBoxAutoStart.Checked.ToString());
        }
        private void SaveSecondaryDisplay()
        {
            AppSett.setAppSetting("SecondaryDisplay", checkBoxSecondaryDisplay.Checked.ToString());
        }
        private void SaveStartWithWindows()
        {
            AppSett.setAppSetting("StartWithWindows", checkBoxStartWithWindows.Checked.ToString());
            // TODO:
            // mit windows starten
        }

        private void RegisterBeamerOnLPM()
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxID.Text == "" || textBoxURL.Text == "")
            {
                MessageBox.Show("Bitte erstmal alle Daten eingeben!");
                return;
            }

            // TODO: authentifizierung


            String url = textBoxURL.Text.ToLower();
            if (!url.StartsWith("http://"))
                url = "http://" + url;
            if (!url.EndsWith("/"))
                url += "/";

            url += "?tpl=empty";
            url += "&mod=" + BeamerClient.Properties.Settings.Default.lpm4_module_name;
            url += "&mode=client";
            //url += "&cmd=login";   //LIEFERT BISHER SERVERSEITIG IMMER EINEN HTTP FEHLER 403 (forbidden)
            url += "&cmd=reg";
            url += "&name=" + textBoxID.Text;
            url += "&clientversion=" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            url += "&udpport=11001";
            try
            {
                WebRequest req = WebRequest.Create(url);
                WebResponse resp = req.GetResponse();

                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);
                while (-1 != sr.Peek())
                {
                    if (sr.ReadLine() == "0")
                    {
                        //MessageBox.Show("Succes");
                        Form2 f2 = new Form2();
                        f2.urlToWebserver = textBoxURL.Text.ToLower();
                        f2.Show();
                        this.Hide();
                        f2.FormClosed += new FormClosedEventHandler(this.form2ClosedEventHandler);
                        currentStatus = 1;
                        timerAntiIdle.Enabled = true;
                    }
                    else
                        MessageBox.Show("Failed");
                }
                resp.Close();
                sr.Close();
            }
            catch (WebException ex)
            {
                if (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.Forbidden)
                    MessageBox.Show("Anmeldung fehlgeschlagen, wohl falsche Anmeldeinformationen eingegeben!", "Anmeldedaten falsch!");
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                byte[] encrypted = aes.encryptStringToBytes_AES(textBoxPassword.Text, Encoding.UTF8.GetBytes("boIG&T78g8fwgif9273gh87T&(%E756a"), Encoding.UTF8.GetBytes("boIG&T7h8g8fwgia"));
                AppSett.setAppSetting("Username", textBoxUsername.Text);
                AppSett.setAppSetting("Password", Convert.ToBase64String(encrypted));
            }
        }

        #endregion Methods

        private void timerAntiIdle_Tick(object sender, EventArgs e)
        {
            String url = textBoxURL.Text.ToLower();
            if (!url.StartsWith("http://"))
                url = "http://" + url;
            if (!url.EndsWith("/"))
                url += "/";

            url += "?tpl=empty";
            url += "&mod=" + BeamerClient.Properties.Settings.Default.lpm4_module_name;
            url += "&mode=client";
            //url += "&cmd=login";   //LIEFERT BISHER SERVERSEITIG IMMER EINEN HTTP FEHLER 403 (forbidden)
            url += "&cmd=clientstatus";
            url += "&status=" + currentStatus.ToString();

            try
            {
                WebRequest req = WebRequest.Create(url);
                WebResponse resp = req.GetResponse();

                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);
                while (-1 != sr.Peek())
                {
                    if (sr.ReadLine() != "0")
                    {
                        MessageBox.Show("Something failed during sending a keep-alive to Server!?");
                    }
                }
                resp.Close();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bitte diesen unerwarteten Fehler melden!!!");    //sollte nicht eintreten
            }
        }

        private void UDPSocketListener_DoWork(object sender, DoWorkEventArgs e)
        {
            const int listenPort = 11001;
            Boolean done = false;
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            string received_data;
            byte[] receive_byte_array;

            try
            {
                while (!done)
                {
                    Console.WriteLine("Waiting for broadcast");
                    receive_byte_array = listener.Receive(ref groupEP);
                    String title = "Received a broadcast from " + groupEP.ToString();
                    received_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);
                    MessageBox.Show(String.Format("data follows \n{0}\n\n", received_data), title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            listener.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            UDPSocketListener.RunWorkerAsync();

            if (checkBoxAutoStart.Checked)
                RegisterBeamerOnLPM();
        }
    }
}
