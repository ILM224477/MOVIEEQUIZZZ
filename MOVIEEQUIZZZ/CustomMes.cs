using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVIEEQUIZZZ
{
    public partial class CustomMes : Form
    {
        public CustomMes(int onoo, int niit)
        {
            InitializeComponent();
            tbOnoo.Text = onoo + " / " +niit;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbOnoo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
