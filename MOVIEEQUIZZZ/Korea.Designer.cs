namespace MOVIEEQUIZZZ
{
    partial class Korea
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
            label1 = new Label();
            lbDugaar = new Label();
            btEhlel = new Button();
            btnDuusgah = new Button();
            btnDaraagiih = new Button();
            btnOmnoh = new Button();
            textBox1 = new TextBox();
            lbxhariultuud = new ListBox();
            lbasuult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold);
            label1.Location = new Point(634, 380);
            label1.Name = "label1";
            label1.Size = new Size(1136, 74);
            label1.TabIndex = 22;
            label1.Text = "Зөв хариултаа энэ доор чирж тавиарай";
            // 
            // lbDugaar
            // 
            lbDugaar.AutoSize = true;
            lbDugaar.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDugaar.ForeColor = SystemColors.ControlLightLight;
            lbDugaar.Location = new Point(227, 210);
            lbDugaar.Margin = new Padding(8, 0, 8, 0);
            lbDugaar.Name = "lbDugaar";
            lbDugaar.Size = new Size(108, 119);
            lbDugaar.TabIndex = 21;
            lbDugaar.Text = "0";
            // 
            // btEhlel
            // 
            btEhlel.FlatAppearance.BorderColor = Color.Black;
            btEhlel.FlatAppearance.BorderSize = 5;
            btEhlel.FlatStyle = FlatStyle.Flat;
            btEhlel.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEhlel.Location = new Point(79, 61);
            btEhlel.Name = "btEhlel";
            btEhlel.Size = new Size(228, 112);
            btEhlel.TabIndex = 20;
            btEhlel.Text = "Эхлэл";
            btEhlel.UseVisualStyleBackColor = true;
            btEhlel.Click += btEhlel_Click;
            // 
            // btnDuusgah
            // 
            btnDuusgah.FlatAppearance.BorderColor = Color.Black;
            btnDuusgah.FlatAppearance.BorderSize = 5;
            btnDuusgah.FlatStyle = FlatStyle.Flat;
            btnDuusgah.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold);
            btnDuusgah.Location = new Point(2010, 1570);
            btnDuusgah.Margin = new Padding(8, 6, 8, 6);
            btnDuusgah.Name = "btnDuusgah";
            btnDuusgah.Size = new Size(404, 95);
            btnDuusgah.TabIndex = 19;
            btnDuusgah.Text = "Дуусгах";
            btnDuusgah.UseVisualStyleBackColor = true;
            btnDuusgah.Click += btnDuusgah_Click;
            // 
            // btnDaraagiih
            // 
            btnDaraagiih.FlatAppearance.BorderColor = Color.Black;
            btnDaraagiih.FlatAppearance.BorderSize = 5;
            btnDaraagiih.FlatStyle = FlatStyle.Flat;
            btnDaraagiih.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold);
            btnDaraagiih.Location = new Point(824, 1570);
            btnDaraagiih.Margin = new Padding(8, 6, 8, 6);
            btnDaraagiih.Name = "btnDaraagiih";
            btnDaraagiih.Size = new Size(426, 95);
            btnDaraagiih.TabIndex = 18;
            btnDaraagiih.Text = "Дараагийнх";
            btnDaraagiih.UseVisualStyleBackColor = true;
            btnDaraagiih.Click += btnDaraagiih_Click;
            // 
            // btnOmnoh
            // 
            btnOmnoh.FlatAppearance.BorderColor = Color.Black;
            btnOmnoh.FlatAppearance.BorderSize = 5;
            btnOmnoh.FlatStyle = FlatStyle.Flat;
            btnOmnoh.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold);
            btnOmnoh.Location = new Point(367, 1570);
            btnOmnoh.Margin = new Padding(8, 6, 8, 6);
            btnOmnoh.Name = "btnOmnoh";
            btnOmnoh.Size = new Size(404, 95);
            btnOmnoh.TabIndex = 17;
            btnOmnoh.Text = "Өмнөх";
            btnOmnoh.UseVisualStyleBackColor = true;
            btnOmnoh.Click += btnOmnoh_Click;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold);
            textBox1.Location = new Point(694, 475);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(973, 81);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DragDrop += tbHariultTavih_DragDrop;
            textBox1.DragEnter += tbHariultTavih_DragEnter;
            // 
            // lbxhariultuud
            // 
            lbxhariultuud.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold);
            lbxhariultuud.FormattingEnabled = true;
            lbxhariultuud.ItemHeight = 74;
            lbxhariultuud.Location = new Point(444, 775);
            lbxhariultuud.Name = "lbxhariultuud";
            lbxhariultuud.Size = new Size(1756, 522);
            lbxhariultuud.TabIndex = 15;
            lbxhariultuud.MouseDown += lbxhariultuud_MouseDown;
            // 
            // lbasuult
            // 
            lbasuult.AutoSize = true;
            lbasuult.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Bold);
            lbasuult.Location = new Point(634, 248);
            lbasuult.Name = "lbasuult";
            lbasuult.Size = new Size(232, 74);
            lbasuult.TabIndex = 14;
            lbasuult.Text = "label1";
            // 
            // Korea
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Flag_of_South_Korea_svg;
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
            Name = "Korea";
            Text = "Korea";
            WindowState = FormWindowState.Maximized;
            Load += Korea_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbDugaar;
        private Button btEhlel;
        private Button btnDuusgah;
        private Button btnDaraagiih;
        private Button btnOmnoh;
        private TextBox textBox1;
        private ListBox lbxhariultuud;
        private Label lbasuult;
    }
}