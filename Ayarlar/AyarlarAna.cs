using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon1.Ayarlar
{
    public partial class AyarlarAna : Form
    {
        public AyarlarAna()
        {
            InitializeComponent();
        }

        private void btnUrunEkleKaldir_Click(object sender, EventArgs e)
        {
            UrunEkleKaldir urunEkleKaldir = new UrunEkleKaldir();
            urunEkleKaldir.Show();
            this.Hide();
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            UrunDuzenle urunDuzenle = new UrunDuzenle();
            urunDuzenle.Show();
            this.Hide();
        }

        private void btnMasaEkleKaldir_Click(object sender, EventArgs e)
        {
            MasaEkleKaldir masaEkleKaldir = new MasaEkleKaldir();
            masaEkleKaldir.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
