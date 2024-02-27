using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RR_PD_v6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_aprekins_Click(object sender, EventArgs e)
        {
            double cena1 = Convert.ToDouble(txtbox_cena1.Text);
            double cena2 = Convert.ToDouble(txtbox_cena2.Text);
            double cena3 = Convert.ToDouble(txtbox_cena3.Text);

            int daudzums1 = Convert.ToInt32(num_daudzums1.Text);
            int daudzums2 = Convert.ToInt32(num_daudzums2.Text);
            int daudzums3 = Convert.ToInt32(num_daudzums3.Text);

            double makaa = Convert.ToDouble(txtbox_maks.Text);
        }
    }
}
