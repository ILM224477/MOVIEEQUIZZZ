namespace MOVIEEQUIZZZ
{
    partial class leaderboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbleaderboard = new Label();
            dtgridScore = new DataGridView();
            ner = new DataGridViewTextBoxColumn();
            Movie = new DataGridViewTextBoxColumn();
            Anime = new DataGridViewTextBoxColumn();
            cartoon = new DataGridViewTextBoxColumn();
            Japanese = new DataGridViewTextBoxColumn();
            Korean = new DataGridViewTextBoxColumn();
            Spanish = new DataGridViewTextBoxColumn();
            niit = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btprevious = new Button();
            btnext = new Button();
            lbCategory = new Label();
            btEhlel = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgridScore).BeginInit();
            SuspendLayout();
            // 
            // lbleaderboard
            // 
            lbleaderboard.AutoSize = true;
            lbleaderboard.BackColor = Color.White;
            lbleaderboard.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbleaderboard.Location = new Point(947, 86);
            lbleaderboard.Name = "lbleaderboard";
            lbleaderboard.Size = new Size(976, 159);
            lbleaderboard.TabIndex = 0;
            lbleaderboard.Text = "LeaderBoard";
            // 
            // dtgridScore
            // 
            dtgridScore.BackgroundColor = Color.White;
            dtgridScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridScore.Columns.AddRange(new DataGridViewColumn[] { ner, Movie, Anime, cartoon, Japanese, Korean, Spanish, niit });
            dtgridScore.Location = new Point(500, 641);
            dtgridScore.Name = "dtgridScore";
            dtgridScore.ReadOnly = true;
            dtgridScore.RowHeadersWidth = 82;
            dtgridScore.RowTemplate.DefaultCellStyle.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtgridScore.Size = new Size(1910, 790);
            dtgridScore.TabIndex = 39;
            // 
            // ner
            // 
            ner.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ner.HeaderText = "НЭР";
            ner.MinimumWidth = 10;
            ner.Name = "ner";
            ner.ReadOnly = true;
            // 
            // Movie
            // 
            Movie.HeaderText = "Movie";
            Movie.MinimumWidth = 10;
            Movie.Name = "Movie";
            Movie.ReadOnly = true;
            Movie.Width = 300;
            // 
            // Anime
            // 
            Anime.HeaderText = "Anime";
            Anime.MinimumWidth = 10;
            Anime.Name = "Anime";
            Anime.ReadOnly = true;
            Anime.Width = 300;
            // 
            // cartoon
            // 
            cartoon.HeaderText = "Cartoon";
            cartoon.MinimumWidth = 10;
            cartoon.Name = "cartoon";
            cartoon.ReadOnly = true;
            cartoon.Width = 300;
            // 
            // Japanese
            // 
            Japanese.HeaderText = "Japanese";
            Japanese.MinimumWidth = 10;
            Japanese.Name = "Japanese";
            Japanese.ReadOnly = true;
            Japanese.Width = 300;
            // 
            // Korean
            // 
            Korean.HeaderText = "Korean";
            Korean.MinimumWidth = 10;
            Korean.Name = "Korean";
            Korean.ReadOnly = true;
            Korean.Width = 300;
            // 
            // Spanish
            // 
            Spanish.HeaderText = "Spanish";
            Spanish.MinimumWidth = 10;
            Spanish.Name = "Spanish";
            Spanish.ReadOnly = true;
            Spanish.Width = 300;
            // 
            // niit
            // 
            niit.HeaderText = "НИИТ ОНОО";
            niit.MinimumWidth = 10;
            niit.Name = "niit";
            niit.ReadOnly = true;
            niit.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(789, 330);
            label1.Name = "label1";
            label1.Size = new Size(1423, 254);
            label1.TabIndex = 43;
            label1.Text = "iiiiiiiiiiiiiiiiiiiiiiiiiiii";
            // 
            // btprevious
            // 
            btprevious.BackColor = Color.MidnightBlue;
            btprevious.FlatAppearance.BorderColor = Color.Turquoise;
            btprevious.FlatStyle = FlatStyle.Popup;
            btprevious.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold);
            btprevious.ForeColor = Color.White;
            btprevious.Location = new Point(789, 330);
            btprevious.Name = "btprevious";
            btprevious.Size = new Size(159, 254);
            btprevious.TabIndex = 46;
            btprevious.Text = "<";
            btprevious.UseVisualStyleBackColor = false;
            btprevious.Click += btprevious_Click;
            // 
            // btnext
            // 
            btnext.BackColor = Color.MidnightBlue;
            btnext.FlatAppearance.BorderColor = Color.Turquoise;
            btnext.FlatStyle = FlatStyle.Popup;
            btnext.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold);
            btnext.ForeColor = Color.White;
            btnext.Location = new Point(2061, 330);
            btnext.Name = "btnext";
            btnext.Size = new Size(151, 254);
            btnext.TabIndex = 45;
            btnext.Text = ">";
            btnext.UseVisualStyleBackColor = false;
            btnext.Click += btnext_Click;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.BackColor = Color.White;
            lbCategory.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCategory.Location = new Point(1165, 409);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(479, 79);
            lbCategory.TabIndex = 44;
            lbCategory.Text = "MOVIEQUIZZZ";
            // 
            // btEhlel
            // 
            btEhlel.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEhlel.Location = new Point(95, 76);
            btEhlel.Name = "btEhlel";
            btEhlel.Size = new Size(228, 112);
            btEhlel.TabIndex = 47;
            btEhlel.Text = "Эхлэл";
            btEhlel.UseVisualStyleBackColor = true;
            btEhlel.Click += btEhlel_Click;
            // 
            // leaderboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(2884, 1578);
            Controls.Add(btEhlel);
            Controls.Add(btprevious);
            Controls.Add(btnext);
            Controls.Add(lbCategory);
            Controls.Add(label1);
            Controls.Add(dtgridScore);
            Controls.Add(lbleaderboard);
            Name = "leaderboard";
            Text = "leaderboard";
            WindowState = FormWindowState.Maximized;
            Load += leaderboard_Load;
            ((System.ComponentModel.ISupportInitialize)dtgridScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbleaderboard;
        private DataGridView dtgridScore;
        private Label label1;
        private Button btprevious;
        private Button btnext;
        private Label lbCategory;
        private DataGridViewTextBoxColumn ner;
        private DataGridViewTextBoxColumn Movie;
        private DataGridViewTextBoxColumn Anime;
        private DataGridViewTextBoxColumn cartoon;
        private DataGridViewTextBoxColumn Japanese;
        private DataGridViewTextBoxColumn Korean;
        private DataGridViewTextBoxColumn Spanish;
        private DataGridViewTextBoxColumn niit;
        private Button btEhlel;
    }
}