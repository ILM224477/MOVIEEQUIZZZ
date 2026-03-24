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
    public partial class Logini : Form
    {
        public Logini()
        {
            InitializeComponent();
            tbpasssword.PasswordChar = '*';
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void tbpasssword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = tbName.Text.Trim();
            string password = tbpasssword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Нэвтрэх нэр болон нууц үгээ оруулна уу!", "Анхааруулга",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserEntry user = UserManager.Validate(username, password);

            if (user == null)
            {
                MessageBox.Show("Нэвтрэх нэр эсвэл нууц үг буруу байна!", "Алдаа",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set the logged-in user globally
            UserManager.CurrentUser = user.Username;

            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
