namespace MOVIEEQUIZZZ
{
    partial class Japanese
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
            lbasuult = new Label();
            lbxhariultuud = new ListBox();
            textBox1 = new TextBox();
            btnOmnoh = new Button();
            btnDaraagiih = new Button();
            btnDuusgah = new Button();
            btEhlel = new Button();
            lbDugaar = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbasuult
            // 
            lbasuult.AutoSize = true;
            lbasuult.BorderStyle = BorderStyle.FixedSingle;
            lbasuult.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold);
            lbasuult.Location = new Point(633, 251);
            lbasuult.Name = "lbasuult";
            lbasuult.Size = new Size(234, 76);
            lbasuult.TabIndex = 0;
            lbasuult.Text = "label1";
            // 
            // lbxhariultuud
            // 
            lbxhariultuud.BackColor = Color.White;
            lbxhariultuud.BorderStyle = BorderStyle.FixedSingle;
            lbxhariultuud.Cursor = Cursors.Hand;
            lbxhariultuud.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold);
            lbxhariultuud.FormattingEnabled = true;
            lbxhariultuud.ItemHeight = 74;
            lbxhariultuud.Location = new Point(443, 778);
            lbxhariultuud.Name = "lbxhariultuud";
            lbxhariultuud.Size = new Size(1756, 446);
            lbxhariultuud.TabIndex = 1;
            lbxhariultuud.SelectedIndexChanged += lbxhariultuud_SelectedIndexChanged;
            lbxhariultuud.MouseDown += lbxhariultuud_MouseDown;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold);
            textBox1.Location = new Point(693, 478);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(973, 81);
            textBox1.TabIndex = 2;
            textBox1.DragDrop += tbHariultTavih_DragDrop;
            textBox1.DragEnter += tbHariultTavih_DragEnter;
            // 
            // btnOmnoh
            // 
            btnOmnoh.BackColor = Color.Transparent;
            btnOmnoh.FlatAppearance.BorderColor = Color.Black;
            btnOmnoh.FlatAppearance.BorderSize = 5;
            btnOmnoh.FlatStyle = FlatStyle.Flat;
            btnOmnoh.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold);
            btnOmnoh.Location = new Point(366, 1573);
            btnOmnoh.Margin = new Padding(8, 6, 8, 6);
            btnOmnoh.Name = "btnOmnoh";
            btnOmnoh.Padding = new Padding(5);
            btnOmnoh.Size = new Size(404, 95);
            btnOmnoh.TabIndex = 7;
            btnOmnoh.Text = "Өмнөх";
            btnOmnoh.UseVisualStyleBackColor = false;
            btnOmnoh.Click += btnOmnoh_Click;
            // 
            // btnDaraagiih
            // 
            btnDaraagiih.BackColor = Color.White;
            btnDaraagiih.FlatAppearance.BorderColor = Color.Black;
            btnDaraagiih.FlatAppearance.BorderSize = 5;
            btnDaraagiih.FlatStyle = FlatStyle.Flat;
            btnDaraagiih.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold);
            btnDaraagiih.Location = new Point(823, 1573);
            btnDaraagiih.Margin = new Padding(8, 6, 8, 6);
            btnDaraagiih.Name = "btnDaraagiih";
            btnDaraagiih.Padding = new Padding(5);
            btnDaraagiih.Size = new Size(426, 95);
            btnDaraagiih.TabIndex = 8;
            btnDaraagiih.Text = "Дараагийнх";
            btnDaraagiih.UseVisualStyleBackColor = false;
            btnDaraagiih.Click += btnDaraagiih_Click;
            // 
            // btnDuusgah
            // 
            btnDuusgah.BackColor = Color.White;
            btnDuusgah.FlatAppearance.BorderColor = Color.Black;
            btnDuusgah.FlatAppearance.BorderSize = 5;
            btnDuusgah.FlatStyle = FlatStyle.Flat;
            btnDuusgah.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold);
            btnDuusgah.Location = new Point(2009, 1573);
            btnDuusgah.Margin = new Padding(8, 6, 8, 6);
            btnDuusgah.Name = "btnDuusgah";
            btnDuusgah.Padding = new Padding(5);
            btnDuusgah.Size = new Size(404, 95);
            btnDuusgah.TabIndex = 9;
            btnDuusgah.Text = "Дуусгах";
            btnDuusgah.UseVisualStyleBackColor = false;
            btnDuusgah.Click += btnDuusgah_Click;
            // 
            // btEhlel
            // 
            btEhlel.BackColor = Color.White;
            btEhlel.FlatAppearance.BorderColor = Color.Black;
            btEhlel.FlatAppearance.BorderSize = 5;
            btEhlel.FlatStyle = FlatStyle.Flat;
            btEhlel.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEhlel.Location = new Point(78, 64);
            btEhlel.Name = "btEhlel";
            btEhlel.Padding = new Padding(5);
            btEhlel.Size = new Size(228, 112);
            btEhlel.TabIndex = 11;
            btEhlel.Text = "Эхлэл";
            btEhlel.UseVisualStyleBackColor = false;
            btEhlel.Click += btEhlel_Click;
            // 
            // lbDugaar
            // 
            lbDugaar.AutoSize = true;
            lbDugaar.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDugaar.ForeColor = SystemColors.ControlLightLight;
            lbDugaar.Location = new Point(226, 213);
            lbDugaar.Margin = new Padding(8, 0, 8, 0);
            lbDugaar.Name = "lbDugaar";
            lbDugaar.Size = new Size(108, 119);
            lbDugaar.TabIndex = 12;
            lbDugaar.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold);
            label1.Location = new Point(633, 383);
            label1.Name = "label1";
            label1.Size = new Size(1138, 76);
            label1.TabIndex = 13;
            label1.Text = "Зөв хариултаа энэ доор чирж тавиарай";
            // 
            // Japanese
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Flag_of_Japan_svg;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(2674, 1829);
            Controls.Add(label1);
            Controls.Add(lbDugaar);
            Controls.Add(btEhlel);
            Controls.Add(btnDuusgah);
            Controls.Add(btnDaraagiih);
            Controls.Add(btnOmnoh);
            Controls.Add(textBox1);
            Controls.Add(lbxhariultuud);
            Controls.Add(lbasuult);
            Name = "Japanese";
            Text = "Japanese";
            WindowState = FormWindowState.Maximized;
            Load += Japanese_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbasuult;
        private ListBox lbxhariultuud;
        private TextBox textBox1;
        private Button btnOmnoh;
        private Button btnDaraagiih;
        private Button btnDuusgah;
        private Button btEhlel;
        private Label lbDugaar;
        private Label label1;
    }
}