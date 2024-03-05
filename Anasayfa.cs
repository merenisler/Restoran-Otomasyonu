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
using System.Data.SqlClient;

namespace PizzaciSon1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        public static bool pesinSatis = false;

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            string calisanPozisyon = Giris.pozisyon;

            string tarih = DateTime.Now.ToShortDateString();
            char ayrac = '.';
            string[] tarih2 = tarih.Split(ayrac);
            string yıl = tarih2[2];
            string ay = tarih2[1];
            string gun = tarih2[0];
            string tarihİlk = yıl + "-" + ay + "-" + gun;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand guncel = new SqlCommand("delete IndirimKodu where SonKullanmaTarihi<=@p1", bg);
            guncel.Parameters.AddWithValue("@p1", tarihİlk);
            guncel.ExecuteNonQuery();
            bg.Close();
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
        private void btnKuryeIslemleri_Click(object sender, EventArgs e)
        {
            SiparisAtama siparisAtama = new SiparisAtama();
            siparisAtama.Show();
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
