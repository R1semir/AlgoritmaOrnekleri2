using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Clear();
        }
        int TekSayiToplam = 0;
        int CiftSayiToplam = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {

            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            temizle();
            if (sayi % 2 == 0)
            {
                CiftSayiToplam = sayi + CiftSayiToplam;
                lblCiftSayilar.Text = CiftSayiToplam.ToString();
                temizle();
            }
            if (sayi % 2 == 1)
            {
                TekSayiToplam = sayi + TekSayiToplam;
                lblTekSayilar.Text = TekSayiToplam.ToString();
                temizle();
            }
        }
    }
}
