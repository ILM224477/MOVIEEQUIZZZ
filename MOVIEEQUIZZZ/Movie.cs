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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }
        int Dugaar = 1;
        string Asuult = "Дүрийн нэрийг таагаарай";

        //dur = Jake sully, Steve rogers, Dr.Bruce banner, Sam Wilson, Spider-MAn in symbiote suite
        string[] Hariult1 = { "Harry Potter", "Steve Rogers", "Dr.Bruce Banner", "Anthon", "venom" };
        string[] Hariult2 = { "Jake Sully", "America", "Dr.Bruno Banner", "America", "Spider-man" };
        string[] Hariult3 = { "Neytiri", "Steven", "Bruno", "Sam Wilson", "Spider-Man in symbiote suite" };
        string[] Hariult4 = { "Mo'at", "Christiana", "Bob", "Alex", "Josh" };

        string[] AsuultZurag =
            {   "Avatar-Movie-Character-transparent-png.png",
                "Captain-America-superhero-from-the-Avengers-transparent-png-image.png",
                "The-Hulk-PNG-Superhero-Character-Transparent.png",
                "Sam-Wilson-Captain-America.png",
                "Spider-Man-in-Symbiote-Suit-Marvel-Black-Costume-8286239.png"};

        string Zam = @"C:\Users\Nomio\Downloads\";

        int[] zowHariult = { 2, 1, 1, 3, 3 };
        int[] selectedAnswers = new int[5];


        private void Movie_Load(object sender, EventArgs e)
        {
            Asuult_TextChanged();
        }
        private void Asuult_TextChanged()
        {

            lbDugaar.Text = Dugaar.ToString();
            tbAsuult.Text = Asuult;

            rbHariult1.Text = Hariult1[Dugaar - 1];
            rbHariult2.Text = Hariult2[Dugaar - 1];
            rbHariult3.Text = Hariult3[Dugaar - 1];
            rbHariult4.Text = Hariult4[Dugaar - 1];
            pbZurag.Image = Image.FromFile(Zam + AsuultZurag[Dugaar - 1]);

            rbHariult1.Checked = false;
            rbHariult2.Checked = false;
            rbHariult3.Checked = false;
            rbHariult4.Checked = false;
        }

        private void SaveAnswer()
        {
            if (rbHariult1.Checked) selectedAnswers[Dugaar - 1] = 1;
            else if (rbHariult2.Checked) selectedAnswers[Dugaar - 1] = 2;
            else if (rbHariult3.Checked) selectedAnswers[Dugaar - 1] = 3;
            else if (rbHariult4.Checked) selectedAnswers[Dugaar - 1] = 4;
            else selectedAnswers[Dugaar - 1] = 0; // сонгоогүй
        }

        private void btnOmnoh_Click(object sender, EventArgs e)
        {
            SaveAnswer();

            if (Dugaar > 1)
            {
                Dugaar--;
                Asuult_TextChanged();
            }
        }

        private void btnDaraagiih_Click(object sender, EventArgs e)
        {
            SaveAnswer();

            if (Dugaar < 5)
            {
                Dugaar++;
                Asuult_TextChanged();
            }

        }
        private void Duusgah_Click(object sender, EventArgs e)
        {


            SaveAnswer(); // Дуусахын өмнө одоогийн асуултыг хадгалах

            int onoo = 0;
            for (int i = 0; i < 5; i++)
            {
                if (selectedAnswers[i] == zowHariult[i])
                    onoo++;
            }

            // Save score to JSON
            UserManager.SaveScore(UserManager.CurrentUser, "Movie", onoo);

            CustomMes hariu = new CustomMes(onoo, Dugaar);
            hariu.Show();

            // Хүсвэл дахин эхлүүлэх
            Dugaar = 1;
            selectedAnswers = new int[5];
            Asuult_TextChanged();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ehlel = new Form1();
            ehlel.Show();
            this.Hide();
        }
    }


}

