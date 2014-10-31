using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace BeamerClient_v2.Controls
{

    public partial class WebControl :  UserControl
    {
        public delegate void StartSendedEventHandler();
        public event StartSendedEventHandler StartSended;

        public delegate void StopSendedEventHandler();
        public event StopSendedEventHandler StopSended;

        public delegate void PlaySendedEventHandler();
        public event PlaySendedEventHandler PlaySended;

        public delegate void PauseSendedEventHandler();
        public event PauseSendedEventHandler PauseSended;

        public delegate void NextSendedEventHandler();
        public event NextSendedEventHandler NextSended;

        public delegate void UrlSendedEventHandler(String url);
        public event UrlSendedEventHandler UrlSended;


        public WebControl() : base()
        {
            InitializeComponent();
            miniWebServer.StartSended += miniWebServer_StartSended;
            miniWebServer.StopSended += miniWebServer_StopSended;
            miniWebServer.PlaySended += miniWebServer_PlaySended;
            miniWebServer.PauseSended += miniWebServer_PauseSended;
            miniWebServer.NextSended += miniWebServer_NextSended;
            miniWebServer.UrlSended += miniWebServer_UrlSended;
        }

        void miniWebServer_StartSended()
        {
            myInvoker("start", null);
        }

        void miniWebServer_StopSended()
        {
            myInvoker("stop", null);
        }

        void miniWebServer_PlaySended()
        {
            myInvoker("play", null);
        }

        void miniWebServer_PauseSended()
        {
            myInvoker("pause", null);
        }

        void miniWebServer_NextSended()
        {
            myInvoker("start", null);
        }

        void miniWebServer_UrlSended(String url)
        {
            myInvoker("url", url);
        }

        private void myInvoker(String sender, object e)
        {
            if (this.InvokeRequired)
                this.Invoke((MethodInvoker)delegate
                {
                    String add = DateTime.Now.ToString("dd.MM.yyyy - HH:mm:ss.fff: ") + sender;
                    if(e != null)
                        add += ": " + e.ToString();
                    listBoxLog.Items.Insert(0, add);

                    switch (sender)
                    {
                        case "start":
                            if (StartSended != null)
                                StartSended();
                            break;
                        case "stop":
                            if (StopSended != null)
                                StopSended();
                            break;
                        case "play":
                            if (PlaySended != null)
                                PlaySended();
                            break;
                        case "pause":
                            if (PauseSended != null)
                                PauseSended();
                            break;
                        case "next":
                            if (NextSended != null)
                                NextSended();
                            break;
                        case "url":
                            String url = e as String;
                            if (UrlSended != null)
                                UrlSended(url);
                            break;
                    }
                });
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!miniWebServer.IsRunning)
            {
                Int32 port = Convert.ToInt32(textBoxPort.Text);
                miniWebServer.Start(port);
                buttonStart.Text = "Stop WebControl";
            }
            else
            {
                miniWebServer.Stop();
                buttonStart.Text = "Start WebControl";
            }
        }
    }

    public static class miniWebServer
    {
        private static readonly HttpListener Listener = new HttpListener();

        public delegate void StartSendedEventHandler();
        public static event StartSendedEventHandler StartSended;

        public delegate void StopSendedEventHandler();
        public static event StopSendedEventHandler StopSended;

        public delegate void PlaySendedEventHandler();
        public static event PlaySendedEventHandler PlaySended;

        public delegate void PauseSendedEventHandler();
        public static event PauseSendedEventHandler PauseSended;

        public delegate void NextSendedEventHandler();
        public static event NextSendedEventHandler NextSended;

        public delegate void UrlSendedEventHandler(String url);
        public static event UrlSendedEventHandler UrlSended;

        public static Boolean IsRunning { get; private set; }

        public static void Start(Int32 port)
        {
            String s = String.Format("http://+:{0}/", port);
            Listener.Prefixes.Add(s);

            Listener.Start();
            Listen();
            IsRunning = true;
        }

        public static void Stop()
        {
            Listener.Stop();
            Listener.Prefixes.Clear();
            IsRunning = false;
        }

        private static async void Listen()
        {
            try
            {
                while (true)
                {
                    HttpListenerContext context = await Listener.GetContextAsync();
                    Task.Factory.StartNew(() => ProcessRequest(context));
                }
            }
            catch (HttpListenerException ex)
            {
                if (ex.ErrorCode != 995)
                    throw ex;
            }
        }
        private static void ProcessRequest(HttpListenerContext context)
        {
            System.Threading.Thread.Sleep(1000);
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
            String responseString = "<html><body><h1>Hello World!</h1></body></html>";

            if (request.QueryString.Keys.Count > 0)
            {
                String action = request.QueryString["action"];
                if (!String.IsNullOrEmpty(action))
                {
                    Boolean result = true;
                    try
                    {
                        switch (action.ToLower())
                        {
                            case "start":
                                if (StartSended != null)
                                    StartSended();
                                break;
                            case "stop":
                                if (StopSended != null)
                                    StopSended();
                                break;
                            case "play":
                                if (PlaySended != null)
                                    PlaySended();
                                break;
                            case "pause":
                                if (PauseSended != null)
                                    PauseSended();
                                break;
                            case "next":
                                if (NextSended != null)
                                    NextSended();
                                break;
                            case "url":
                                String url = request.QueryString["url"];
                                if (String.IsNullOrEmpty(url))
                                    result = false;
                                else
                                    if (UrlSended != null)
                                        UrlSended(url);
                                break;
                            default:
                                result = false;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        result = false;
                    }

                    if (result)
                    {
                        responseString = "{\"success\":true}";
                    }
                }
            }
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);

            output.Close();
        }
    }

}
