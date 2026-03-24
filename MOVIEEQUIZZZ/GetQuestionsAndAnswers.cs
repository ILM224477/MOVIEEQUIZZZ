using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MOVIEEQUIZZZ
{
    public partial class GetQuestionsAndAnswers : Form
    {
        public GetQuestionsAndAnswers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string question = txtQuestion.Text.Trim();
            string ans0 = txtAns1.Text.Trim();
            string ans1 = txtAns2.Text.Trim();
            string ans2 = txtAns3.Text.Trim();
            string ans3 = txtAns4.Text.Trim();

            int correctIndex = cmbCorrectAnswer.SelectedIndex;
            string selectedLanguage = cmbFilePath.Text.Trim();

            if (string.IsNullOrEmpty(question) || string.IsNullOrEmpty(ans0) || string.IsNullOrEmpty(ans1) || string.IsNullOrEmpty(ans2) || string.IsNullOrEmpty(ans3) || correctIndex == -1)
            {
                MessageBox.Show("Бүх талбарыг бөглөнө үү!");
                return;
            }

            if (string.IsNullOrEmpty(selectedLanguage))
            {
                MessageBox.Show("Хэлээ сонгоорой");
                return;
            }

            string fileName = selectedLanguage + ".txt";
            string path = Path.Combine(@"C:\Users\Nomio\OneDrive\Ажлын тавцан\", fileName);
            string line = $"{question}|{ans0},{ans1},{ans2},{ans3}|{correctIndex}";

            try
            {
                File.AppendAllText(path, line + Environment.NewLine, Encoding.UTF8);
                MessageBox.Show("Хадгалагдлаа!");

                txtQuestion.Clear();
                txtAns1.Clear();
                txtAns2.Clear();
                txtAns3.Clear();
                txtAns4.Clear();
                cmbCorrectAnswer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
