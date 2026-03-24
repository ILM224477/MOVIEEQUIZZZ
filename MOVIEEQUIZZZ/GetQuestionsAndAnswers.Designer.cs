namespace MOVIEEQUIZZZ
{
    partial class GetQuestionsAndAnswers
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            txtQuestion = new TextBox();
            lblAns1 = new Label();
            txtAns1 = new TextBox();
            lblAns2 = new Label();
            txtAns2 = new TextBox();
            lblAns3 = new Label();
            txtAns3 = new TextBox();
            lblAns4 = new Label();
            txtAns4 = new TextBox();
            lblCorrect = new Label();
            cmbCorrectAnswer = new ComboBox();
            lblFilePath = new Label();
            cmbFilePath = new ComboBox();
            btnSave = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.White;
            lblQuestion.Location = new Point(30, 30);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(172, 54);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Асуулт: ";
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(275, 30);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(1152, 80);
            txtQuestion.TabIndex = 1;
            // 
            // lblAns1
            // 
            lblAns1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblAns1.ForeColor = Color.White;
            lblAns1.Location = new Point(30, 163);
            lblAns1.Name = "lblAns1";
            lblAns1.Size = new Size(189, 54);
            lblAns1.TabIndex = 2;
            lblAns1.Text = "Хариулт 1:";
            // 
            // txtAns1
            // 
            txtAns1.Location = new Point(275, 163);
            txtAns1.Name = "txtAns1";
            txtAns1.Size = new Size(1152, 39);
            txtAns1.TabIndex = 3;
            // 
            // lblAns2
            // 
            lblAns2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblAns2.ForeColor = Color.White;
            lblAns2.Location = new Point(30, 263);
            lblAns2.Name = "lblAns2";
            lblAns2.Size = new Size(189, 54);
            lblAns2.TabIndex = 4;
            lblAns2.Text = "Хариулт 2:";
            // 
            // txtAns2
            // 
            txtAns2.Location = new Point(275, 263);
            txtAns2.Name = "txtAns2";
            txtAns2.Size = new Size(1152, 39);
            txtAns2.TabIndex = 5;
            // 
            // lblAns3
            // 
            lblAns3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblAns3.ForeColor = Color.White;
            lblAns3.Location = new Point(30, 363);
            lblAns3.Name = "lblAns3";
            lblAns3.Size = new Size(189, 54);
            lblAns3.TabIndex = 6;
            lblAns3.Text = "Хариулт 3:";
            // 
            // txtAns3
            // 
            txtAns3.Location = new Point(275, 363);
            txtAns3.Name = "txtAns3";
            txtAns3.Size = new Size(1152, 39);
            txtAns3.TabIndex = 7;
            // 
            // lblAns4
            // 
            lblAns4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblAns4.ForeColor = Color.White;
            lblAns4.Location = new Point(30, 463);
            lblAns4.Name = "lblAns4";
            lblAns4.Size = new Size(189, 54);
            lblAns4.TabIndex = 8;
            lblAns4.Text = "Хариулт 4:";
            // 
            // txtAns4
            // 
            txtAns4.Location = new Point(275, 463);
            txtAns4.Name = "txtAns4";
            txtAns4.Size = new Size(1152, 39);
            txtAns4.TabIndex = 9;
            // 
            // lblCorrect
            // 
            lblCorrect.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblCorrect.ForeColor = Color.White;
            lblCorrect.Location = new Point(30, 563);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(226, 54);
            lblCorrect.TabIndex = 10;
            lblCorrect.Text = "Зөв хариулт :";
            // 
            // cmbCorrectAnswer
            // 
            cmbCorrectAnswer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCorrectAnswer.FormattingEnabled = true;
            cmbCorrectAnswer.Items.AddRange(new object[] { "0 (Answer 1)", "1 (Answer 2)", "2 (Answer 3)", "3 (Answer 4)" });
            cmbCorrectAnswer.Location = new Point(275, 563);
            cmbCorrectAnswer.Name = "cmbCorrectAnswer";
            cmbCorrectAnswer.Size = new Size(1152, 40);
            cmbCorrectAnswer.TabIndex = 11;
            // 
            // lblFilePath
            // 
            lblFilePath.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblFilePath.ForeColor = Color.White;
            lblFilePath.Location = new Point(30, 663);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(226, 54);
            lblFilePath.TabIndex = 12;
            lblFilePath.Text = "File Path:";
            // 
            // cmbFilePath
            // 
            cmbFilePath.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilePath.FormattingEnabled = true;
            cmbFilePath.Items.AddRange(new object[] { "Japanese", "Korean", "Spanish" });
            cmbFilePath.Location = new Point(275, 663);
            cmbFilePath.Name = "cmbFilePath";
            cmbFilePath.Size = new Size(1152, 40);
            cmbFilePath.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold);
            btnSave.Location = new Point(815, 790);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(311, 78);
            btnSave.TabIndex = 14;
            btnSave.Text = "Асуулт оруулах";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold);
            button1.Location = new Point(1240, 790);
            button1.Name = "button1";
            button1.Size = new Size(226, 74);
            button1.TabIndex = 15;
            button1.Text = "Дуусгах";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GetQuestionsAndAnswers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1582, 930);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(cmbFilePath);
            Controls.Add(lblFilePath);
            Controls.Add(cmbCorrectAnswer);
            Controls.Add(lblCorrect);
            Controls.Add(txtAns4);
            Controls.Add(lblAns4);
            Controls.Add(txtAns3);
            Controls.Add(lblAns3);
            Controls.Add(txtAns2);
            Controls.Add(lblAns2);
            Controls.Add(txtAns1);
            Controls.Add(lblAns1);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestion);
            Name = "GetQuestionsAndAnswers";
            Text = "Add Question";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.Label lblAns3;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.Label lblAns4;
        private System.Windows.Forms.TextBox txtAns4;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.ComboBox cmbCorrectAnswer;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.ComboBox cmbFilePath;
        private System.Windows.Forms.Button btnSave;
        private Button button1;
    }
}
