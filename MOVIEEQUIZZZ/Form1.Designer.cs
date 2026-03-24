namespace MOVIEEQUIZZZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb1 = new Label();
            pbMovie = new PictureBox();
            pbAnime = new PictureBox();
            pbCartoon = new PictureBox();
            btCartoon = new Button();
            btAnime = new Button();
            btMovie = new Button();
            menuStrip1 = new MenuStrip();
            fUNMOVIEQUIZToolStripMenuItem = new ToolStripMenuItem();
            fUNMOVIEQUIZZToolStripMenuItem = new ToolStripMenuItem();
            movieToolStripMenuItem = new ToolStripMenuItem();
            animeToolStripMenuItem = new ToolStripMenuItem();
            cartoonToolStripMenuItem = new ToolStripMenuItem();
            lETSLEARNNEWLANGUAGESToolStripMenuItem = new ToolStripMenuItem();
            japaneseToolStripMenuItem = new ToolStripMenuItem();
            koreanToolStripMenuItem = new ToolStripMenuItem();
            spanishToolStripMenuItem = new ToolStripMenuItem();
            aSUULTNEMEHToolStripMenuItem = new ToolStripMenuItem();
            LEADERBOARD = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCartoon).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Showcard Gothic", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.ForeColor = SystemColors.ControlLightLight;
            lb1.Location = new Point(247, 85);
            lb1.Name = "lb1";
            lb1.Size = new Size(2423, 199);
            lb1.TabIndex = 0;
            lb1.Text = "🌟Дүрийн нэрийг таагаарай!🌟";
            lb1.TextAlign = ContentAlignment.TopCenter;
            lb1.Click += lb1_Click;
            // 
            // pbMovie
            // 
            pbMovie.BackColor = Color.White;
            pbMovie.Image = Properties.Resources.movies;
            pbMovie.Location = new Point(348, 496);
            pbMovie.Name = "pbMovie";
            pbMovie.Size = new Size(585, 500);
            pbMovie.SizeMode = PictureBoxSizeMode.Zoom;
            pbMovie.TabIndex = 1;
            pbMovie.TabStop = false;
            // 
            // pbAnime
            // 
            pbAnime.BackColor = Color.White;
            pbAnime.Image = Properties.Resources.anime;
            pbAnime.Location = new Point(1148, 496);
            pbAnime.Name = "pbAnime";
            pbAnime.Size = new Size(585, 500);
            pbAnime.SizeMode = PictureBoxSizeMode.Zoom;
            pbAnime.TabIndex = 2;
            pbAnime.TabStop = false;
            // 
            // pbCartoon
            // 
            pbCartoon.BackColor = Color.White;
            pbCartoon.Image = Properties.Resources.cartoon;
            pbCartoon.Location = new Point(1948, 496);
            pbCartoon.Name = "pbCartoon";
            pbCartoon.Size = new Size(585, 500);
            pbCartoon.SizeMode = PictureBoxSizeMode.Zoom;
            pbCartoon.TabIndex = 3;
            pbCartoon.TabStop = false;
            // 
            // btCartoon
            // 
            btCartoon.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold | FontStyle.Italic);
            btCartoon.Location = new Point(1948, 1040);
            btCartoon.Name = "btCartoon";
            btCartoon.Size = new Size(593, 139);
            btCartoon.TabIndex = 4;
            btCartoon.Text = "Cartoon";
            btCartoon.UseVisualStyleBackColor = true;
            btCartoon.Click += btCartoon_Click;
            // 
            // btAnime
            // 
            btAnime.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold | FontStyle.Italic);
            btAnime.Location = new Point(1148, 1040);
            btAnime.Name = "btAnime";
            btAnime.Size = new Size(593, 139);
            btAnime.TabIndex = 5;
            btAnime.Text = "Anime";
            btAnime.UseVisualStyleBackColor = true;
            btAnime.Click += btAnime_Click;
            // 
            // btMovie
            // 
            btMovie.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold | FontStyle.Italic);
            btMovie.Location = new Point(348, 1040);
            btMovie.Name = "btMovie";
            btMovie.Size = new Size(593, 139);
            btMovie.TabIndex = 6;
            btMovie.Text = "Movie";
            btMovie.UseVisualStyleBackColor = true;
            btMovie.Click += btMovie_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fUNMOVIEQUIZToolStripMenuItem, aSUULTNEMEHToolStripMenuItem, LEADERBOARD });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2876, 48);
            menuStrip1.TabIndex = 7;
            // 
            // fUNMOVIEQUIZToolStripMenuItem
            // 
            fUNMOVIEQUIZToolStripMenuItem.AccessibleRole = AccessibleRole.None;
            fUNMOVIEQUIZToolStripMenuItem.BackColor = Color.Black;
            fUNMOVIEQUIZToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fUNMOVIEQUIZZToolStripMenuItem, lETSLEARNNEWLANGUAGESToolStripMenuItem });
            fUNMOVIEQUIZToolStripMenuItem.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fUNMOVIEQUIZToolStripMenuItem.ForeColor = Color.White;
            fUNMOVIEQUIZToolStripMenuItem.Name = "fUNMOVIEQUIZToolStripMenuItem";
            fUNMOVIEQUIZToolStripMenuItem.Size = new Size(155, 44);
            fUNMOVIEQUIZToolStripMenuItem.Text = "QUIZES";
            fUNMOVIEQUIZToolStripMenuItem.Click += fUNMOVIEQUIZToolStripMenuItem_Click;
            // 
            // fUNMOVIEQUIZZToolStripMenuItem
            // 
            fUNMOVIEQUIZZToolStripMenuItem.BackColor = Color.Black;
            fUNMOVIEQUIZZToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { movieToolStripMenuItem, animeToolStripMenuItem, cartoonToolStripMenuItem });
            fUNMOVIEQUIZZToolStripMenuItem.ForeColor = Color.White;
            fUNMOVIEQUIZZToolStripMenuItem.Name = "fUNMOVIEQUIZZToolStripMenuItem";
            fUNMOVIEQUIZZToolStripMenuItem.Size = new Size(625, 48);
            fUNMOVIEQUIZZToolStripMenuItem.Text = "FUN MOVIE QUIZZ";
            fUNMOVIEQUIZZToolStripMenuItem.Click += fUNMOVIEQUIZZToolStripMenuItem_Click;
            // 
            // movieToolStripMenuItem
            // 
            movieToolStripMenuItem.BackColor = Color.Black;
            movieToolStripMenuItem.ForeColor = Color.White;
            movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            movieToolStripMenuItem.Size = new Size(308, 48);
            movieToolStripMenuItem.Text = "Movie";
            movieToolStripMenuItem.Click += movieToolStripMenuItem_Click;
            // 
            // animeToolStripMenuItem
            // 
            animeToolStripMenuItem.BackColor = Color.Black;
            animeToolStripMenuItem.ForeColor = Color.White;
            animeToolStripMenuItem.Name = "animeToolStripMenuItem";
            animeToolStripMenuItem.Size = new Size(308, 48);
            animeToolStripMenuItem.Text = "Anime";
            animeToolStripMenuItem.Click += animeToolStripMenuItem_Click;
            // 
            // cartoonToolStripMenuItem
            // 
            cartoonToolStripMenuItem.BackColor = Color.Black;
            cartoonToolStripMenuItem.ForeColor = Color.White;
            cartoonToolStripMenuItem.Name = "cartoonToolStripMenuItem";
            cartoonToolStripMenuItem.Size = new Size(308, 48);
            cartoonToolStripMenuItem.Text = "Cartoon";
            cartoonToolStripMenuItem.Click += cartoonToolStripMenuItem_Click;
            // 
            // lETSLEARNNEWLANGUAGESToolStripMenuItem
            // 
            lETSLEARNNEWLANGUAGESToolStripMenuItem.BackColor = Color.Black;
            lETSLEARNNEWLANGUAGESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { japaneseToolStripMenuItem, koreanToolStripMenuItem, spanishToolStripMenuItem });
            lETSLEARNNEWLANGUAGESToolStripMenuItem.ForeColor = Color.White;
            lETSLEARNNEWLANGUAGESToolStripMenuItem.Name = "lETSLEARNNEWLANGUAGESToolStripMenuItem";
            lETSLEARNNEWLANGUAGESToolStripMenuItem.Size = new Size(625, 48);
            lETSLEARNNEWLANGUAGESToolStripMenuItem.Text = "LET'S LEARN NEW LANGUAGES";
            lETSLEARNNEWLANGUAGESToolStripMenuItem.Click += lETSLEARNNEWLANGUAGESToolStripMenuItem_Click;
            // 
            // japaneseToolStripMenuItem
            // 
            japaneseToolStripMenuItem.BackColor = Color.Black;
            japaneseToolStripMenuItem.ForeColor = Color.White;
            japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            japaneseToolStripMenuItem.Size = new Size(310, 48);
            japaneseToolStripMenuItem.Text = "Japanese";
            japaneseToolStripMenuItem.Click += japaneseToolStripMenuItem_Click;
            // 
            // koreanToolStripMenuItem
            // 
            koreanToolStripMenuItem.BackColor = Color.Black;
            koreanToolStripMenuItem.ForeColor = Color.White;
            koreanToolStripMenuItem.Name = "koreanToolStripMenuItem";
            koreanToolStripMenuItem.Size = new Size(310, 48);
            koreanToolStripMenuItem.Text = "Korean";
            koreanToolStripMenuItem.Click += koreanToolStripMenuItem_Click;
            // 
            // spanishToolStripMenuItem
            // 
            spanishToolStripMenuItem.BackColor = Color.Black;
            spanishToolStripMenuItem.ForeColor = Color.White;
            spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            spanishToolStripMenuItem.Size = new Size(310, 48);
            spanishToolStripMenuItem.Text = "Spanish";
            spanishToolStripMenuItem.Click += spanishToolStripMenuItem_Click;
            // 
            // aSUULTNEMEHToolStripMenuItem
            // 
            aSUULTNEMEHToolStripMenuItem.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            aSUULTNEMEHToolStripMenuItem.ForeColor = Color.White;
            aSUULTNEMEHToolStripMenuItem.Name = "aSUULTNEMEHToolStripMenuItem";
            aSUULTNEMEHToolStripMenuItem.Size = new Size(282, 44);
            aSUULTNEMEHToolStripMenuItem.Text = "ASUULT NEMEH";
            aSUULTNEMEHToolStripMenuItem.Click += aSUULTNEMEHToolStripMenuItem_Click;
            // 
            // LEADERBOARD
            // 
            LEADERBOARD.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            LEADERBOARD.ForeColor = Color.White;
            LEADERBOARD.Name = "LEADERBOARD";
            LEADERBOARD.Size = new Size(275, 44);
            LEADERBOARD.Text = "LEADERBOARD";
            LEADERBOARD.Click += LEADERBOARD_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(2876, 1462);
            Controls.Add(btMovie);
            Controls.Add(btAnime);
            Controls.Add(btCartoon);
            Controls.Add(pbCartoon);
            Controls.Add(pbAnime);
            Controls.Add(pbMovie);
            Controls.Add(lb1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pbMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCartoon).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private PictureBox pbMovie;
        private PictureBox pbAnime;
        private PictureBox pbCartoon;
        private Button btCartoon;
        private Button btAnime;
        private Button btMovie;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fUNMOVIEQUIZToolStripMenuItem;
        private ToolStripMenuItem fUNMOVIEQUIZZToolStripMenuItem;
        private ToolStripMenuItem movieToolStripMenuItem;
        private ToolStripMenuItem animeToolStripMenuItem;
        private ToolStripMenuItem cartoonToolStripMenuItem;
        private ToolStripMenuItem lETSLEARNNEWLANGUAGESToolStripMenuItem;
        private ToolStripMenuItem japaneseToolStripMenuItem;
        private ToolStripMenuItem koreanToolStripMenuItem;
        private ToolStripMenuItem spanishToolStripMenuItem;
        private ToolStripMenuItem aSUULTNEMEHToolStripMenuItem;
        private ToolStripMenuItem LEADERBOARD;
    }
}
