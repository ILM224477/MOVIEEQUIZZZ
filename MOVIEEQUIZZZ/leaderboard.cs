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
    public partial class leaderboard : Form
    {
        // 0 = MOVIEQUIZZZ, 1 = Let's Learn Language
        private int currentView = 0;

        public leaderboard()
        {
            InitializeComponent();
        }

        private void leaderboard_Load(object sender, EventArgs e)
        {
            ShowView(0);
        }

        private void ShowView(int view)
        {
            currentView = view;
            dtgridScore.Rows.Clear();

            var users = UserManager.LoadAll();

            if (view == 0)
            {
                // MOVIEQUIZZZ view: НЭР, Movie, Anime, Cartoon, НИЙТ
                lbCategory.Text = "MOVIEQUIZZZ";

                // Show/hide columns
                dtgridScore.Columns["Movie"].Visible = true;
                dtgridScore.Columns["Anime"].Visible = true;
                dtgridScore.Columns["cartoon"].Visible = true;
                dtgridScore.Columns["Japanese"].Visible = false;
                dtgridScore.Columns["Korean"].Visible = false;
                dtgridScore.Columns["Spanish"].Visible = false;
                dtgridScore.Columns["niit"].HeaderText = "НИЙТ ОНОО";

                // Sort by total descending
                var sorted = users.OrderByDescending(u => u.ScoreMovie + u.ScoreAnime + u.ScoreCartoon).ToList();
                foreach (var u in sorted)
                {
                    int total = u.ScoreMovie + u.ScoreAnime + u.ScoreCartoon;
                    dtgridScore.Rows.Add(u.Username, u.ScoreMovie, u.ScoreAnime, u.ScoreCartoon,
                        /*Japanese*/ "", /*Korean*/ "", /*Spanish*/ "", total);
                }
            }
            else
            {
                // Let's Learn Language view: НЭР, Japanese, Korean, Spanish, НИЙТ
                lbCategory.Text = "LET'S LEARN LANGUAGE";

                dtgridScore.Columns["Movie"].Visible = false;
                dtgridScore.Columns["Anime"].Visible = false;
                dtgridScore.Columns["cartoon"].Visible = false;
                dtgridScore.Columns["Japanese"].Visible = true;
                dtgridScore.Columns["Korean"].Visible = true;
                dtgridScore.Columns["Spanish"].Visible = true;
                dtgridScore.Columns["niit"].HeaderText = "НИЙТ ОНОО";

                var sorted = users.OrderByDescending(u => u.ScoreJapanese + u.ScoreKorean + u.ScoreSpanish).ToList();
                foreach (var u in sorted)
                {
                    int total = u.ScoreJapanese + u.ScoreKorean + u.ScoreSpanish;
                    dtgridScore.Rows.Add(u.Username, /*Movie*/ "", /*Anime*/ "", /*Cartoon*/ "",
                        u.ScoreJapanese, u.ScoreKorean, u.ScoreSpanish, total);
                }
            }
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            ShowView(1); // Switch to Language view
        }

        private void btprevious_Click(object sender, EventArgs e)
        {
            ShowView(0); // Switch to Movie view
        }

        private void btEhlel_Click(object sender, EventArgs e)
        {
            Form1 ehlel = new Form1();
            ehlel.Show();
            this.Hide();
        }
    }
}
