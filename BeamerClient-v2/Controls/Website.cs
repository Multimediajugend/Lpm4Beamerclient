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
using System.IO;
using System.Web.Script.Serialization;

namespace BeamerClient_v2.Controls
{
    public partial class Website : UserControl
    {
        private List<news> newsList = new List<news>();
        private String url;
        private Int32 lastID = 0;

        public delegate void ShowWebsiteEventHandler(String url, Int32 duration);
        public event ShowWebsiteEventHandler ShowWebsite;

        public delegate void LogEventHandler(String msg);
        public event LogEventHandler Log;
        
        public Website()
        {
            InitializeComponent();

            getNews();
        }

        public void disable()
        {
            buttonWebsiteShow.Enabled = false;
        }
        public void enable()
        {
            buttonWebsiteShow.Enabled = true;
        }

        private void addLog(String msg)
        {
            if (Log != null)
                Log(msg);
        }
        private void show()
        {
            Int32 duration;
            if (!Int32.TryParse(textBoxWebsiteDuration.Text, out duration))
                textBoxWebsiteDuration.ForeColor = Color.Red;
            else
                if (ShowWebsite != null)
                    ShowWebsite(this.url, duration);
        }

        private void getNews()
        {
            newsList.Clear();

            try
            {
                //TODO: Get news from LPM4
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.hsf-clanwars.de/news_request.php");
                request.ContentType = "application/json; charset=utf-8";
                request.Accept = "application/json";

                WebResponse response = request.GetResponse();

                Stream stream = response.GetResponseStream();
                String json = String.Empty;

                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                        json += reader.ReadLine();
                }


                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Object[] x = (Object[])serializer.DeserializeObject(json);

                foreach (Dictionary<string, object> o in x)
                {
                    Int32 newsid = Convert.ToInt32(o["newsid"]);
                    String title = o["title"] as String;

                    String url = String.Format("http://www.hsf-clanwars.de/?tpl=beamer&mode=beamer&mod=news&newsid={0}", newsid);
                    String value = String.Format("{0} - {1}", newsid, title);

                    newsList.Add(new news(url, value));

                    if (lastID < newsid)
                    {
                        if (lastID != 0)
                        {
                            if (checkBoxWebsitePolling.Checked)
                            {
                                this.url = url;
                                show();
                            }
                        }
                        lastID = newsid;
                    }
                }

                fillComboBox();

            }
            catch (Exception ex)
            {
                addLog(ex.Message);
            }
        }

        private void fillComboBox()
        {
            comboBoxWebsiteNews.Items.Clear();

            foreach (news n in newsList)
                comboBoxWebsiteNews.Items.Add(n.value);
            comboBoxWebsiteNews.SelectedIndex = 0;

            if (checkBoxWebsitePolling.Checked)
                timerPolling.Start();
        }

        private void loadPreview()
        {
            String status = "Loading Preview ...";

            try
            {
                webBrowserPreview.Navigate(new Uri(textBoxWebsiteURL.Text));
            }
            catch (UriFormatException ex)
            {
                status = "Please enter a correct URL";
            }

            labelWebsiteStatus.Text = status;
            labelWebsiteStatus.Visible = true;
        }

        private void comboBoxWebsiteNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (news n in newsList)
                if (n.value == comboBoxWebsiteNews.SelectedItem as String)
                    textBoxWebsiteURL.Text = n.url;
        }

        private void textBoxWebsiteURL_TextChanged(object sender, EventArgs e)
        {
            this.url = String.Empty;
            timerUrlCheck.Stop();
            timerUrlCheck.Start();
        }

        private void timerUrlCheck_Tick(object sender, EventArgs e)
        {
            timerUrlCheck.Stop();
            loadPreview();
        }

        private void buttonWebsiteShow_Click(object sender, EventArgs e)
        {
            textBoxWebsiteDuration.ForeColor = SystemColors.WindowText;
            Int32 duration;

            if (String.IsNullOrEmpty(this.url))
                textBoxWebsiteURL.ForeColor = Color.Red;
            else
                show();
        }

        private void buttonWebsiteRefresh_Click(object sender, EventArgs e)
        {
            loadPreview();
        }

        private void webBrowserPreview_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.url = webBrowserPreview.Url.ToString();
            textBoxWebsiteURL.Text = this.url;
            textBoxWebsiteURL.ForeColor = SystemColors.WindowText;
            labelWebsiteStatus.Visible = false;
        }

        private void checkBoxWebsitePolling_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWebsitePolling.Checked)
                timerPolling.Start();
            else
                timerPolling.Stop();
        }

        private void timerPolling_Tick(object sender, EventArgs e)
        {
            timerPolling.Stop();
            getNews();
        }

        private void buttonWebsiteLoadNews_Click(object sender, EventArgs e)
        {
            getNews();
        }
    }

    public class news
    {
        public String url
        {
            get;
            private set;
        }
        public String value
        {
            get;
            private set;
        }

        public news(String url, String value)
        {
            this.url = url;
            this.value = value;
        }
    }
}
