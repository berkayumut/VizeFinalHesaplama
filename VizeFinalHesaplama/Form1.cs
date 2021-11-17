using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float vize;
        float final;
        float ortalama;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            vize =float.Parse(txtVize.Text);
            final =float.Parse(txtFinal.Text);
            float vizeYuzdeKirk = (vize * 40) / 100;
            float finalYuzdealtmis = (final * 60) / 100;
            ortalama = vizeYuzdeKirk + finalYuzdealtmis;
            lblOrtalama.Text = ortalama.ToString();
            if (ortalama < 30)
            {
                lblHarfNotu.Text = "F";
      
            }
            if (ortalama >= 30 && ortalama < 50)
            {
                lblHarfNotu.Text = "D";

            }
            if (ortalama >= 50 && ortalama < 70)
            {
                lblHarfNotu.Text = "C";
            }
            if (ortalama >= 70 && ortalama < 85)
            {
                lblHarfNotu.Text = "B";
            }
            if (ortalama >= 85)
            {
                lblHarfNotu.Text = "A";
            }
        }
    }
}
