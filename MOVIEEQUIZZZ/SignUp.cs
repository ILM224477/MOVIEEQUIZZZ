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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void tbRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // "Нэвтрэх" button — go back to login
        private void button1_Click(object sender, EventArgs e)
        {
            Logini login = new Logini();
            login.Show();
            this.Hide();
        }

        // "Бүртгүүлэх" button — register and save to JSON
        private void button2_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(tbRegister.Text) ||
                string.IsNullOrWhiteSpace(tbFirstname.Text) ||
                string.IsNullOrWhiteSpace(tbLastname.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Бүх талбарыг бөглөнө үү!", "Анхааруулга",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rbEregtei.Checked && !rbEmegtei.Checked)
            {
                MessageBox.Show("Хүйсээ сонгоно уу!", "Анхааруулга",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entry = new UserEntry
            {
                Register  = tbRegister.Text.Trim(),
                Firstname = tbFirstname.Text.Trim(),
                Lastname  = tbLastname.Text.Trim(),
                Gender    = rbEregtei.Checked ? "Эрэгтэй" : "Эмэгтэй",
                Birthdate = dateBirth.Value.ToString("yyyy-MM-dd"),
                Username  = tbUsername.Text.Trim(),
                Password  = tbPassword.Text
            };

            bool ok = UserManager.Register(entry);
            if (!ok)
            {
                MessageBox.Show("Энэ хэрэглэгчийн нэр бүртгэлтэй байна. Өөр нэр сонгоно уу.",
                    "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Бүртгэл амжилттай хийгдлээ!", "Мэдэгдэл",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Logini login = new Logini();
            login.Show();
            this.Hide();
        }
    }
}
