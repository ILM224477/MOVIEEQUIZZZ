namespace MOVIEEQUIZZZ
{
    partial class CustomMes
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
            lbOnoo = new Label();
            tbOnoo = new TextBox();
            btOk = new Button();
            SuspendLayout();
            // 
            // lbOnoo
            // 
            lbOnoo.AutoSize = true;
            lbOnoo.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOnoo.ForeColor = SystemColors.ControlLightLight;
            lbOnoo.Location = new Point(189, 51);
            lbOnoo.Name = "lbOnoo";
            lbOnoo.Size = new Size(394, 79);
            lbOnoo.TabIndex = 0;
            lbOnoo.Text = "Таны оноо: ";
            // 
            // tbOnoo
            // 
            tbOnoo.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOnoo.Location = new Point(226, 173);
            tbOnoo.Name = "tbOnoo";
            tbOnoo.ReadOnly = true;
            tbOnoo.Size = new Size(306, 126);
            tbOnoo.TabIndex = 1;
            tbOnoo.TextChanged += tbOnoo_TextChanged;
            // 
            // btOk
            // 
            btOk.BackColor = Color.Navy;
            btOk.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btOk.ForeColor = SystemColors.ControlLightLight;
            btOk.Location = new Point(226, 357);
            btOk.Name = "btOk";
            btOk.Size = new Size(314, 66);
            btOk.TabIndex = 2;
            btOk.Text = "Ойлголоо! ";
            btOk.TextAlign = ContentAlignment.TopCenter;
            btOk.UseVisualStyleBackColor = false;
            btOk.Click += btOk_Click;
            // 
            // CustomMes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImage = Properties.Resources.pngegg;
            ClientSize = new Size(800, 450);
            Controls.Add(btOk);
            Controls.Add(tbOnoo);
            Controls.Add(lbOnoo);
            ForeColor = SystemColors.ControlText;
            Name = "CustomMes";
            Text = "Onoo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOnoo;
        private TextBox tbOnoo;
        private Button btOk;
    }
}