using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeamerClient_v2.Controls
{
    public partial class Video : UserControl
    {
        private MovieList movieList;

        public Video()
        {
            InitializeComponent();
            movieList = new MovieList();

            fillDataGridView();
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            movieList.getNextRandom();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String s in ofd.FileNames)
                    movieList.Add(new Movie(s));
            }

            fillDataGridView();
        }

        private void fillDataGridView()
        {
            dataGridViewMovies.Rows.Clear();

            foreach (Movie m in movieList)
            {
                DataGridViewRow dgvr = new DataGridViewRow();

                DataGridViewTextBoxCell dgvcPath = new DataGridViewTextBoxCell();
                dgvcPath.Value = m.path;

                DataGridViewCheckBoxCell dgvcSkip = new DataGridViewCheckBoxCell();
                dgvcSkip.Value = m.skip;

                DataGridViewTextBoxCell dgvcPlayed = new DataGridViewTextBoxCell();
                dgvcPlayed.Value = m.playCnt;

                dgvr.Cells.Add(dgvcPath);
                dgvr.Cells.Add(dgvcSkip);
                dgvr.Cells.Add(dgvcPlayed);

                dataGridViewMovies.Rows.Add(dgvr);
            }
        }

        private void dataGridViewMovies_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowCount == 1)
                movieList.RemoveAt(e.RowIndex);
        }

        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                String[] files = Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories);

                foreach (String s in files)
                {
                    movieList.Add(new Movie(s));
                }
            }

            fillDataGridView();
        }

        public String getNextPath()
        {
            return movieList.getNextRandom();
        }
    }

    public class MovieList : List<Movie>
    {
        //public List<Movie> list { get; private set; }

        public String getNextRandom()
        {
            String result = null;

            if (this.Count > 0)
            {
                List<Movie> skipList =
                    (from Movie in this
                    where (Movie.skip != true)
                    select Movie).ToList();

                //List<Movie> skipList = tmpList.ToList();

                if (skipList.Count() > 0)
                {
                    Random rand = new Random((Int32)DateTime.Now.ToFileTime());
                    Movie next = skipList[rand.Next(skipList.Count())];
                    next.playCnt++;

                    result = next.path;
                }
            }
            return result;
        }
    }

    public class Movie
    {
        public String path { get; private set; }
        public Boolean skip { get; set; }
        public Int32 playCnt { get; set; }

        public Movie(String path)
        {
            this.path = path;
            this.skip = false;
            this.playCnt = 0;
        }
    }
}
