using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Core.Medias;

namespace BeamerClient_v2
{
    public partial class Projector : Form
    {
        private VlcControl vlcControl;

        public delegate void MovieEndedEventHandler();
        public event MovieEndedEventHandler MovieEnded;

        public delegate void WebsiteLoadedEventHandler();
        public event WebsiteLoadedEventHandler WebsiteLoaded;

        public Boolean moviePlaying { get { return vlcControl.IsPlaying; } }
        public Boolean moviePaused { get { return vlcControl.IsPaused; } }

        public Projector()
        {
            InitializeComponent();
            panelBlack.BringToFront();
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;

            vlcControl = new VlcControl();
            vlcControl.BackColor = Color.Black;
            vlcControl.Dock = DockStyle.Fill;
            vlcControl.Rate = 0F;

            vlcControl.Disposed += vlcControl_Disposed;
            vlcControl.EndReached += vlcControl_EndReached;

            //vlcControl.Stop();

            //vlcControl.Media = new EmptyMedia("a");

            this.Controls.Add(vlcControl);
        }

        void vlcControl_EndReached(VlcControl sender, Vlc.DotNet.Core.VlcEventArgs<EventArgs> e)
        {
            vlcControl.Media.Dispose();
            vlcControl.Media = null;
            showBlack();
            if (MovieEnded != null)
                MovieEnded();
        }

        void vlcControl_Disposed(object sender, EventArgs e)
        {
            vlcControl.Stop();
        }

        public void showBlack()
        {
            panelBlack.BringToFront();
        }

        public void showWebsite(String url)
        {
            loadWebsite(url);
        }

        public void showMovie(String path)
        {
            loadMovie(path);
        }

        public void playMovie()
        {
            if (!vlcControl.IsPlaying)
            {
                vlcControl.BringToFront();

                vlcControl.Play();
            }
        }

        public void pauseMovie()
        {
            if(vlcControl.IsPlaying)
                vlcControl.Pause();
            showBlack();
        }

        public void stopMovie()
        {
            vlcControl.Stop();
            showBlack();
        }

        public void unpauseMovie()
        {
            if (vlcControl.IsPaused)
            {
                Double totalSeconds = vlcControl.Media.Duration.TotalSeconds;
                Double position = vlcControl.Position;

                Double currentSecond = totalSeconds * position;

                position = (currentSecond - 10) / totalSeconds;

                if (position < 0)
                    position = 0;

                vlcControl.Position = (Single)position;

                vlcControl.BringToFront();

                vlcControl.Play();
            }
        }


        private void loadMovie(String path)
        {
            if (vlcControl.IsPlaying || vlcControl.IsPaused)
                vlcControl.Stop();

            var media = new PathMedia(path);

            vlcControl.Time = new TimeSpan(0, 0, 0);

            vlcControl.Media = media;
            vlcControl.BringToFront();

            vlcControl.Play();
        }

        private void loadWebsite(String url)
        {
            if (webBrowser.Document != null)
                webBrowser.Document.Write("<html><head><meta http-equiv=\"Page-Exit\" content=\"blendTrans(Duration=1)\"></head><body style=\"background-color:#000;\"></body></html>");
            webBrowser.Navigate(new Uri(url));
            webBrowser.Refresh();
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.BringToFront();
            if (WebsiteLoaded != null)
                WebsiteLoaded();
        }
    }
}
