using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVIEEQUIZZZ
{
    public partial class Korea : Form
    {
        string[] lines = new string[0];
        int index = 0;
        string correctAnswer = "";
        string[] userAnswers;

        public Korea()
        {
            InitializeComponent();

            string path = Path.Combine(@"C:\Users\Nomio\OneDrive\Ажлын тавцан\Korean.txt");
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path, Encoding.UTF8);
                if (lines.Length > 0)
                {
                    userAnswers = new string[lines.Length];
                    LoadQuestion();
                }
            }
            else
            {
                MessageBox.Show("File not found: " + path);
            }
        }

        void LoadQuestion()
        {
            var parts = lines[index].Split('|');

            string question = parts[0];
            string[] answers = parts[1].Split(',');
            correctAnswer = answers[int.Parse(parts[2])];

            lbasuult.Text = question;

            lbxhariultuud.Items.Clear();
            foreach (var ans in answers)
            {
                lbxhariultuud.Items.Add(ans);
            }

            textBox1.Text = userAnswers[index] ?? "";
            lbDugaar.Text = (index + 1).ToString();
        }

        private void Korea_Load(object sender, EventArgs e)
        {
        }

        private void lbxhariultuud_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbxhariultuud.SelectedItem != null)
            {
                lbxhariultuud.DoDragDrop(lbxhariultuud.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }

        private void btnOmnoh_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Ehnii asuult");
            }
        }

        private void btnDaraagiih_Click(object sender, EventArgs e)
        {
            if (index < lines.Length - 1)
            {
                index++;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Suuliin asuult");
            }
        }

        private void btnDuusgah_Click(object sender, EventArgs e)
        {
            int score = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrEmpty(lines[i])) continue;
                var parts = lines[i].Split('|');
                if (parts.Length < 3) continue;
                string[] answers = parts[1].Split(',');
                string correctAns = answers[int.Parse(parts[2])];

                if (userAnswers[i] == correctAns)
                {
                    score++;
                }
            }

            // Save score to JSON
            UserManager.SaveScore(UserManager.CurrentUser, "Korean", score);

            CustomMes resultForm = new CustomMes(score, lines.Length);
            resultForm.ShowDialog();
        }

        private void btEhlel_Click(object sender, EventArgs e)
        {
            Form2 ehlel = new Form2();
            ehlel.Show();
            this.Hide();
        }


        private void tbHariultTavih_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void tbHariultTavih_DragDrop(object sender, DragEventArgs e)
        {
            string answer = (string)e.Data.GetData(DataFormats.StringFormat);
            textBox1.Text = answer;
            userAnswers[index] = answer;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
