using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVIEEQUIZZZ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void btspanish_Click(object sender, EventArgs e)
        {
            Spanish spanish = new Spanish();
            spanish.Show();
            this.Hide();
        }

        private void btjapan_Click(object sender, EventArgs e)
        {
            Japanese japanese = new Japanese();
            japanese.Show();
            this.Hide();
        }

        private void btkorea_Click(object sender, EventArgs e)
        {
            Korea korea = new Korea();
            korea.Show();
            this.Hide();
        }

        private void fUNMOVIEQUIZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fUNMOVIEQUIZZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ehlel = new Form1();
            ehlel.Show();
            this.Hide();
        }

        private void lETSLEARNNEWLANGUAGESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ehlel = new Form2();
            ehlel.Show();
            this.Hide();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Show();
            this.Hide();
        }

        private void cartoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartoon cartoon = new Cartoon();
            cartoon.Show();
            this.Hide();
        }

        private void japaneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Japanese japanese = new Japanese();
            japanese.Show();
            this.Hide();
        }

        private void koreanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korea korea = new Korea();
            korea.Show();
            this.Hide();
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spanish spanish = new Spanish();
            spanish.Show();
            this.Hide();
        }

        private void animeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anime anime = new Anime();
            anime.Show();
            this.Hide();
        }

        private void aSUULTNEMEHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetQuestionsAndAnswers get = new GetQuestionsAndAnswers();
            get.Show();
        }


        private void LEADERBOARD_Click_1(object sender, EventArgs e)
        {
            leaderboard leaderboard = new leaderboard();
            leaderboard.Show();
            this.Hide();
        }
    }
}
