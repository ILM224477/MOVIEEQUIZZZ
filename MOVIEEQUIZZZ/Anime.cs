
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
    public partial class Anime : Form
    {
        public Anime()
        {
            InitializeComponent();
        }
        int Dugaar = 1;
        string Asuult = "Дүрийн нэрийг таагаарай";

        //dur = Jake sully, Steve rogers, Dr.Bruce banner, Sam Wilson, Spider-MAn in symbiote suite
        string[] Hariult1 = { "Tanjiro", "Gintoki", "All might", "Luffy", "Sai" };
        string[] Hariult2 = { "Tomiyoka", "Hijikata", "Bakugo", "Robin", "Sasuke" };
        string[] Hariult3 = { "Nezuko", "Kagura", "Todoroki", "Zoro", "Naruto" };
        string[] Hariult4 = { "Muzan", "Elizabeth", "Kirishima", "Nami", "Tsunade" };

        string[] AsuultZurag =
    { 
            "pngwing.com (6).png",
            "pngwing.com (7).png",
            "pngwing.com (10).png",
            "pngwing.com (8).png",
            "pngwing.com (9).png"
        };

        string Zam = @"C:\Users\Nomio\Downloads\";

        int[] zowHariult = { 3, 3, 1, 3, 2 };
        int[] selectedAnswers = new int[5];


        private void Anime_Load(object sender, EventArgs e)
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
            UserManager.SaveScore(UserManager.CurrentUser, "Anime", onoo);

            CustomMes hariu = new CustomMes(onoo, Dugaar);
            hariu.Show();

            // Хүсвэл дахин эхлүүлэх
            Dugaar = 1;
            selectedAnswers = new int[5];
            Asuult_TextChanged();
        }

        private void btEhlel_Click(object sender, EventArgs e)
        {
            Form1 ehlel = new Form1();
            ehlel.Show();
            this.Hide();
        }
    }


}


    

