using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders0926_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtNot1.Text);
            sayi2 = Convert.ToDouble(txtNot2.Text);
            sonuc = (sayi1 + sayi2) / 2;
            lblSonuc.Text = "Sonuç : " + sonuc;

        }
    }
}
