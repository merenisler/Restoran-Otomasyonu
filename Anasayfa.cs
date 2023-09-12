using PizzaciSon1.Masalar;
using PizzaciSon1.Raporlar;
using PizzaciSon1.Siparis;
using PizzaciSon1.Ayarlar;
using PizzaciSon1.StokTakibi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        public static bool pesinSatis = false;

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            string calisanPozisyon = Giris.pozisyon;
        }
        private void btnMasalar_Click(object sender, EventArgs e)
        {
            SalonMasalar.salonMasa = true;
            BahceMasalar.bahceMasa = false;
            pesinSatis = false;
            SalonMasalar masalar = new SalonMasalar();
            masalar.Show();
            this.Hide();
        }
        private void btnPesinSatis_Click(object sender, EventArgs e)
        {
            SalonMasalar.salonMasa = false;
            BahceMasalar.bahceMasa = false;
            pesinSatis = true;
            SiparisAna siparis = new SiparisAna();
            siparis.Show();
            this.Hide();
        }
        private void btnStokTakibi_Click(object sender, EventArgs e)
        {
            StokTakibiAna stokTakibiAna = new StokTakibiAna();
            stokTakibiAna.Show();
            this.Hide();
        }
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            RaporlarAna raporlarAna = new RaporlarAna();
            raporlarAna.Show();
            this.Hide();
        }
        private void btnGunlukGiderler_Click(object sender, EventArgs e)
        {
            GunlukGiderler gunlukGiderler = new GunlukGiderler();
            gunlukGiderler.Show();
            this.Hide();
        }
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarGiris ayarlarGiris = new AyarlarGiris();
            ayarlarGiris.Show();
            this.Hide();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }
}
