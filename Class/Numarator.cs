using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaciSon1.Class
{
    internal class Numarator
    {
        public static void Numara(string deger, TextBox txtSifre)
        {
            if (txtSifre.Text == "0" && txtSifre.Text == null)
            {
                txtSifre.Text = deger;
            }
            else
            {
                txtSifre.Text = txtSifre.Text + deger;
            }
        }
        public static void Sil(TextBox txtSifre)
        {
            if (txtSifre.Text != "")
            {
                string sifre = txtSifre.Text.Substring(0, txtSifre.Text.Length - 1);
                txtSifre.Text = sifre;
            }
        }
    }
}
