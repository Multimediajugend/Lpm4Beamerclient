using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeamerClient_v2
{
    public partial class BeamerClient : Form
    {
        private Projector projector;
        private Log log;

        //private BeamerClient_v2.Controls.Website website;

        public BeamerClient()
        {
            InitializeComponent();

            fillPanelDisplays();

            log = new Log(listBoxLog);

            log.add("Started");

            website.ShowWebsite += website_ShowWebsite;

            closeProjector();
        }

        void projector_MovieEnded()
        {
            projector.showBlack();
            // TODO: Play next movie
        }

        void website_Log(string msg)
        {
            log.add(msg);
        }

        void website_ShowWebsite(string url, int duration)
        {
            if (projector != null && !projector.IsDisposed)
            {
                if (projector.moviePlaying)
                    projector.pauseMovie();

                projector.showWebsite(url);
                log.add(String.Format("Show Website ({1}s):{0}", url, duration));
                timerWebsiteShowTime.Interval = duration * 1000;
            }
        }

        private void fillPanelDisplays()
        {
            this.panelDisplays.Controls.Clear();

            for (Int32 i = 0; i < Screen.AllScreens.Length; i++)
            {
                Screen screen = Screen.AllScreens[i];

                RadioButton rbNext = new RadioButton();
                rbNext.Text = "Display " + (i + 1);
                rbNext.Checked = (i == 0);
                rbNext.Location = new Point(5, 5 + i * 23);
                this.panelDisplays.Controls.Add(rbNext);
            }
        }

        private void newProjector()
        {
            try
            {
                if (projector == null || projector.IsDisposed)
                {
                    Int32 screen = Int32.Parse(panelDisplays.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text.Substring(8));

                    Rectangle rect = Screen.AllScreens[screen - 1].Bounds;

                    projector = new Projector();
                    projector.Location = new Point(rect.X, rect.Y);
                    projector.StartPosition = FormStartPosition.Manual;
                    projector.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    projector.Disposed += myProjector_Disposed;
                    projector.WebsiteLoaded += projector_WebsiteLoaded;
                    projector.Show();

                    projector.MovieEnded += projector_MovieEnded;

                    groupBoxDisplay.Enabled = false;
                    groupBoxConfigureProjector.Enabled = true;
                    buttonToggleProjector.Text = "Close Projectorwindow";
                    
                    website.enable();

                    log.add(String.Format("ProjectorWindow opened at X={0} Y={1} ({2}x{3})!", rect.X, rect.Y, rect.Width, rect.Height));
                }
                else
                    MessageBox.Show("Projector is already running.");
            }
            catch (Exception ex)
            {
                log.add(ex.Message);
            }
        }

        void projector_WebsiteLoaded()
        {
            timerWebsiteShowTime.Start();
        }

        private void closeProjector()
        {
            website.disable();
            groupBoxDisplay.Enabled = true;
            groupBoxConfigureProjector.Enabled = false;
            buttonToggleProjector.Text = "Open Projectorwindow";
        }

        private void buttonToggleProjector_Click(object sender, EventArgs e)
        {
            if (projector == null || projector.IsDisposed)
                newProjector();
            else
                projector.Close();
        }

        void myProjector_Disposed(object sender, EventArgs e)
        {
            closeProjector();
            log.add("ProjectorWindow closed!");
        }

        private void buttonLogClear_Click(object sender, EventArgs e)
        {
            log.clear();
        }

        private void buttonLogCopy_Click(object sender, EventArgs e)
        {
            log.copyToClipboard();
        }

        private void timerWebsiteShowTime_Tick(object sender, EventArgs e)
        {
            timerWebsiteShowTime.Stop();
            projector.showBlack();

            if (projector.moviePaused)
                projector.unpauseMovie();
        }

        private void play()
        {
            projector.playMovie();
        }

        private void pause()
        {
            projector.pauseMovie();
        }

        private void stopMovie()
        {
            projector.stopMovie();
        }

        private void stop()
        {
            buttonStartProjector.Enabled = true;

            buttonPlayMovie.Enabled = false;
            buttonPauseMovie.Enabled = false;
            buttonStopMovie.Enabled = false;
            buttonNext.Enabled = false;

            buttonStopProjector.Enabled = false;

            projector.stopMovie();
            timerWebsiteShowTime.Stop();
            projector.showBlack();
        }

        private void start()
        {
            buttonStartProjector.Enabled = false;
            buttonStopProjector.Enabled = true;
            buttonPlayMovie.Enabled = true;
            buttonPauseMovie.Enabled = true;
            buttonStopMovie.Enabled = true;
            buttonNext.Enabled = true;

            showNextMovie();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            play();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void buttonStopMovie_Click(object sender, EventArgs e)
        {
            stopMovie();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop();
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            start();
        }

        private void showNextMovie()
        {
            if (projector != null && !projector.IsDisposed)
            {
                timerWebsiteShowTime.Stop();
                
                String next = video.getNextPath();
                
                if (String.IsNullOrEmpty(next))
                    stop();
                else
                    projector.showMovie(next);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            showNextMovie();
        }

    }

    public class Log
    {
        private ListBox listBox;

        public Log(ListBox listBox)
        {
            this.listBox = listBox;
        }
        public void add(String msg)
        {
            String log = String.Format("{0}: {1}", DateTime.Now.ToString("dd.MM.yyyy - HH:mm:ss.fff"), msg);
            this.listBox.Items.Insert(0, log);
        }
        public void clear()
        {
            this.listBox.Items.Clear();
        }
        public void copyToClipboard()
        {
            String result = String.Empty;
            foreach (String s in this.listBox.Items)
                result += s + Environment.NewLine;
            Clipboard.SetText(result);
        }
    }
}
