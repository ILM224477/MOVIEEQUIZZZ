namespace MOVIEEQUIZZZ
{
    partial class SignUp
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
            pictureBox1 = new PictureBox();
            dateBirth = new DateTimePicker();
            rbEmegtei = new RadioButton();
            rbEregtei = new RadioButton();
            tbLastname = new TextBox();
            tbFirstname = new TextBox();
            tbRegister = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbBirthdate = new Label();
            lbGender = new Label();
            lbLastname = new Label();
            lbFirstname = new Label();
            lbRegister = new Label();
            lbUsername = new Label();
            lbPassword = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(2159, 435);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dateBirth
            // 
            dateBirth.CalendarForeColor = SystemColors.ActiveCaptionText;
            dateBirth.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            dateBirth.Location = new Point(789, 1224);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(1295, 93);
            dateBirth.TabIndex = 30;
            // 
            // rbEmegtei
            // 
            rbEmegtei.AutoSize = true;
            rbEmegtei.BackColor = Color.Transparent;
            rbEmegtei.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            rbEmegtei.ForeColor = Color.White;
            rbEmegtei.Location = new Point(1148, 1016);
            rbEmegtei.Name = "rbEmegtei";
            rbEmegtei.Size = new Size(338, 88);
            rbEmegtei.TabIndex = 29;
            rbEmegtei.TabStop = true;
            rbEmegtei.Text = "Эмэгтэй";
            rbEmegtei.UseVisualStyleBackColor = false;
            // 
            // rbEregtei
            // 
            rbEregtei.AutoSize = true;
            rbEregtei.BackColor = Color.Transparent;
            rbEregtei.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            rbEregtei.ForeColor = Color.White;
            rbEregtei.Location = new Point(789, 1016);
            rbEregtei.Name = "rbEregtei";
            rbEregtei.Size = new Size(327, 88);
            rbEregtei.TabIndex = 28;
            rbEregtei.TabStop = true;
            rbEregtei.Text = "Эрэгтэй";
            rbEregtei.UseVisualStyleBackColor = false;
            // 
            // tbLastname
            // 
            tbLastname.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            tbLastname.Location = new Point(789, 815);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(1295, 93);
            tbLastname.TabIndex = 27;
            // 
            // tbFirstname
            // 
            tbFirstname.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            tbFirstname.Location = new Point(789, 624);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(1295, 93);
            tbFirstname.TabIndex = 26;
            // 
            // tbRegister
            // 
            tbRegister.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            tbRegister.Location = new Point(789, 435);
            tbRegister.Name = "tbRegister";
            tbRegister.Size = new Size(1295, 93);
            tbRegister.TabIndex = 25;
            tbRegister.TextChanged += tbRegister_TextChanged;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            tbUsername.Location = new Point(789, 1410);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(1295, 93);
            tbUsername.TabIndex = 40;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            tbPassword.Location = new Point(789, 1600);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(1295, 93);
            tbPassword.TabIndex = 41;
            // 
            // lbBirthdate
            // 
            lbBirthdate.AutoSize = true;
            lbBirthdate.BackColor = Color.Transparent;
            lbBirthdate.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            lbBirthdate.ForeColor = Color.White;
            lbBirthdate.Location = new Point(164, 1224);
            lbBirthdate.Name = "lbBirthdate";
            lbBirthdate.Size = new Size(507, 84);
            lbBirthdate.TabIndex = 23;
            lbBirthdate.Text = "Төрсөн огноо :";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.BackColor = Color.Transparent;
            lbGender.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            lbGender.ForeColor = Color.White;
            lbGender.Location = new Point(164, 1016);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(233, 84);
            lbGender.TabIndex = 22;
            lbGender.Text = "Хүйс :";
            // 
            // lbLastname
            // 
            lbLastname.AutoSize = true;
            lbLastname.BackColor = Color.Transparent;
            lbLastname.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            lbLastname.ForeColor = Color.White;
            lbLastname.Location = new Point(164, 815);
            lbLastname.Name = "lbLastname";
            lbLastname.Size = new Size(200, 84);
            lbLastname.TabIndex = 21;
            lbLastname.Text = "Нэр :";
            // 
            // lbFirstname
            // 
            lbFirstname.AutoSize = true;
            lbFirstname.BackColor = Color.Transparent;
            lbFirstname.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            lbFirstname.ForeColor = Color.White;
            lbFirstname.Location = new Point(164, 624);
            lbFirstname.Name = "lbFirstname";
            lbFirstname.Size = new Size(233, 84);
            lbFirstname.TabIndex = 20;
            lbFirstname.Text = "Овог :";
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.BackColor = Color.Transparent;
            lbRegister.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            lbRegister.ForeColor = Color.White;
            lbRegister.Location = new Point(164, 435);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(374, 84);
            lbRegister.TabIndex = 19;
            lbRegister.Text = "Регистер :";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = Color.Transparent;
            lbUsername.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(164, 1410);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(472, 84);
            lbUsername.TabIndex = 42;
            lbUsername.Text = "Нэвтрэх нэр :";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.Transparent;
            lbPassword.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Bold);
            lbPassword.ForeColor = Color.White;
            lbPassword.Location = new Point(164, 1600);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(316, 84);
            lbPassword.TabIndex = 43;
            lbPassword.Text = "Нууц үг :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(886, 99);
            label1.Name = "label1";
            label1.Size = new Size(1095, 237);
            label1.TabIndex = 36;
            label1.Text = "Бүртгүүлэх";
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(2252, 1591);
            button2.Name = "button2";
            button2.Size = new Size(338, 102);
            button2.TabIndex = 38;
            button2.Text = "Бүртгүүлэх";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(2252, 1410);
            button1.Name = "button1";
            button1.Size = new Size(338, 102);
            button1.TabIndex = 37;
            button1.Text = "Нэвтрэх";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2759, 1879);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dateBirth);
            Controls.Add(rbEmegtei);
            Controls.Add(rbEregtei);
            Controls.Add(tbLastname);
            Controls.Add(tbFirstname);
            Controls.Add(tbRegister);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Controls.Add(lbBirthdate);
            Controls.Add(lbGender);
            Controls.Add(lbLastname);
            Controls.Add(lbFirstname);
            Controls.Add(lbRegister);
            Controls.Add(lbUsername);
            Controls.Add(lbPassword);
            DoubleBuffered = true;
            Name = "SignUp";
            Text = "SignUp";
            WindowState = FormWindowState.Maximized;
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DateTimePicker dateBirth;
        private RadioButton rbEmegtei;
        private RadioButton rbEregtei;
        private TextBox tbLastname;
        private TextBox tbFirstname;
        private TextBox tbRegister;
        private Label lbBirthdate;
        private Label lbGender;
        private Label lbLastname;
        private Label lbFirstname;
        private Label lbRegister;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbUsername;
        private Label lbPassword;
    }
}