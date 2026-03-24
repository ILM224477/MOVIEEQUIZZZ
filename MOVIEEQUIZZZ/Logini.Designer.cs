namespace MOVIEEQUIZZZ
{
    partial class Logini
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
            label2 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            tbpasssword = new TextBox();
            btlogin = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(438, 700);
            label1.Name = "label1";
            label1.Size = new Size(928, 119);
            label1.TabIndex = 0;
            label1.Text = "Хэрэглэгчийн нэр :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(919, 942);
            label2.Name = "label2";
            label2.Size = new Size(447, 119);
            label2.TabIndex = 1;
            label2.Text = "Нууц үг :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 64);
            label3.Font = new Font("Showcard Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1070, 251);
            label3.Name = "label3";
            label3.Size = new Size(831, 237);
            label3.TabIndex = 2;
            label3.Text = "Нэвтрэх";
            // 
            // tbName
            // 
            tbName.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold);
            tbName.Location = new Point(1533, 700);
            tbName.Name = "tbName";
            tbName.Size = new Size(932, 126);
            tbName.TabIndex = 3;
            tbName.TextChanged += tbname_TextChanged;
            // 
            // tbpasssword
            // 
            tbpasssword.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold);
            tbpasssword.Location = new Point(1533, 942);
            tbpasssword.Name = "tbpasssword";
            tbpasssword.Size = new Size(932, 126);
            tbpasssword.TabIndex = 4;
            tbpasssword.TextChanged += tbpasssword_TextChanged;
            // 
            // btlogin
            // 
            btlogin.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btlogin.Location = new Point(1024, 1446);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(338, 102);
            btlogin.TabIndex = 5;
            btlogin.Text = "Нэвтрэх";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1563, 1446);
            button2.Name = "button2";
            button2.Size = new Size(338, 102);
            button2.TabIndex = 6;
            button2.Text = "Бүртгүүлэх";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SignUp_Click;
            // 
            // Logini
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(2884, 1879);
            Controls.Add(button2);
            Controls.Add(btlogin);
            Controls.Add(tbpasssword);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Logini";
            Text = "Logini";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private TextBox tbpasssword;
        private Button btlogin;
        private Button button2;
    }
}