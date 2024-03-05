using PizzaciSon1.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon1.Siparis
{
    public partial class ZRapor : Form
    {
        public ZRapor()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        public static string ciktiTarihi;

        static int ToplamYap(List<int> liste)
        {
            int toplam = 0;
            foreach (int sayi in liste)
            { toplam += sayi; }
            return toplam;
        }

        private void ZRapor_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from ZRapor order by siparisSaat", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();

                listele.Text = (oku["satici"].ToString());
                listele.SubItems.Add(oku["siparisSaat"].ToString());
                listele.SubItems.Add(oku["odemeDurumu"].ToString());
                listele.SubItems.Add(oku["islem"].ToString());
                listele.SubItems.Add(oku["tutar"].ToString());
                lstViewZRapor.Items.Add(listele);
            }
            bg.Close();


            bg.Open();
            try
            {
                cmd = new SqlCommand("select sum(tutar) as toplam from ZRapor", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    txtToplamTutar.Text = "Toplam Tutar: " + oku["toplam"].ToString();
                }
            }
            catch (Exception)
            { }
            bg.Close();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int toplamTutar = 0, kdvTutar = 0, iptalYiyecek = 0, iptalIcecek = 0, iptalToplamTutar = 0, ikramToplamTutar = 0;
            int adisyonAdet = 0, paketServisAdet = 0, personelGider = 0, fire = 0, marketGider = 0, mutfakGider = 0;

            List<string> personelAd = new List<string>();
            List<int> personelUcret = new List<int>();

            ciktiTarihi = DateTime.Now.ToLongTimeString();
            string Tarih = DateTime.Now.ToShortDateString();
            char ayrac = '.';
            string[] Tarih1 = Tarih.Split(ayrac);
            string yıl = Tarih1[2]; string ay = Tarih1[1]; string gun = Tarih1[0];
            string tarihİlk = yıl + "-" + ay + "-" + gun;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select SUM(tutar) as toplamTutar from ZRapor where odemeDurumu='Nakit'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                toplamTutar = (int)oku["toplamTutar"];
            }
            kdvTutar = ((toplamTutar * 18) / 100);
            bg.Close();

            bg.Open();
            try
            {
                cmd = new SqlCommand("select SUM(fiyat) as toplamTutar from Fire", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    fire = (int)oku["toplamTutar"];
                }
            }
            catch (Exception)
            {
            }
            bg.Close();
            bg.Open();
            cmd = new SqlCommand("select * from GunSonuFiyatlar", bg);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                iptalYiyecek = (int)oku["iptalYiyecek"];
                iptalIcecek = (int)oku["iptalIcecek"];
                ikramToplamTutar = (int)oku["ikram"];
            }
            iptalToplamTutar = iptalIcecek + iptalYiyecek;
            bg.Close();

            bg.Open();
            cmd = new SqlCommand("select COUNT(adisyonNo) as adisyonAdet from GunlukAdisyon", bg);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                adisyonAdet = (int)oku["adisyonAdet"];
            }
            bg.Close();

            bg.Open();
            cmd = new SqlCommand("select COUNT(paketServisNo) as paketServisAdet from PaketServis", bg);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                paketServisAdet = (int)oku["paketServisAdet"];
            }
            bg.Close();

            bg.Open();
            int adet = 0;
            try
            {
                cmd = new SqlCommand("select SUM(personelUcret) as toplamTutar, COUNT(*) as adet from PersonelGider", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    personelGider = (int)oku["toplamTutar"];
                    adet = (int)oku["adet"];
                }
            }
            catch (Exception)
            {
            }
            bg.Close();

            bg.Open();
            try
            {
                cmd = new SqlCommand("select personelUcret, personelAdSoyad from PersonelGider", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    personelAd.Add((string)oku["personelAdSoyad"]);
                    personelUcret.Add((int)oku["personelUcret"]);
                }
            }
            catch (Exception)
            {
            }
            bg.Close();

            bg.Open();
            try
            {
                cmd = new SqlCommand("select * from marketMutfakGider", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    marketGider = (int)oku["marketGider"];
                    mutfakGider = (int)oku["mutfakGider"];
                }
            }
            catch (Exception)
            {
            }
            bg.Close();

            //SqlConnection bg2 = new SqlConnection("Data Source=LAPTOP-0D7UILE8;Initial Catalog=PizzaciMuhasebe;Integrated Security=True");
            //try
            //{
            //    bg2.Open();
            //    SqlCommand cmd2 = new SqlCommand("insert into ZRapor(toplamTutar, iptalToplamTutar, ikramToplamTutar, kdvTutar, fireTutar, adisyonSayisi, paketServisSayisi, tarih) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", bg2);
            //    cmd2.Parameters.AddWithValue("@p1", toplamTutar);
            //    cmd2.Parameters.AddWithValue("@p2", iptalToplamTutar);
            //    cmd2.Parameters.AddWithValue("@p3", ikramToplamTutar);
            //    cmd2.Parameters.AddWithValue("@p4", kdvTutar);
            //    cmd2.Parameters.AddWithValue("@p5", fire);
            //    cmd2.Parameters.AddWithValue("@p6", adisyonAdet);
            //    cmd2.Parameters.AddWithValue("@p7", paketServisAdet);
            //    cmd2.Parameters.AddWithValue("@p8", tarihİlk);
            //    cmd2.ExecuteNonQuery();
            //    bg2.Close();

            //    for (int i = 0; i < adet; i++)
            //    {
            //        bg2.Open();
            //        cmd2 = new SqlCommand("insert into Personel(tarih, personelAd, personelUcret) values(@p1, @p2, @p3)", bg2);
            //        cmd2.Parameters.AddWithValue("@p1", tarihİlk);
            //        cmd2.Parameters.AddWithValue("@p2", personelAd[i]);
            //        cmd2.Parameters.AddWithValue("@p3", personelUcret[i]);
            //        cmd2.ExecuteNonQuery();
            //        bg2.Close();
            //    }

            //    bg2.Open();
            //    cmd2 = new SqlCommand("insert into personelGider(tarih, personelAdet, giderTutar) values(@p1, @p2, @p3)", bg2);
            //    cmd2.Parameters.AddWithValue("@p1", tarihİlk);
            //    cmd2.Parameters.AddWithValue("@p2", adet);
            //    cmd2.Parameters.AddWithValue("@p3", personelGider);
            //    cmd2.ExecuteNonQuery();
            //    bg2.Close();

            //    bg2.Open();
            //    cmd2 = new SqlCommand("insert into marketMutfakGider(marketGider, mutfakGider, tarih) values(@p1, @p2, @p3)", bg2);
            //    cmd2.Parameters.AddWithValue("@p1", marketGider);
            //    cmd2.Parameters.AddWithValue("@p2", mutfakGider);
            //    cmd2.Parameters.AddWithValue("@p3", tarihİlk);
            //    cmd2.ExecuteNonQuery();
            //    bg2.Close();
            //}
            //catch (Exception)
            //{
            //}

            printPreviewDialog1.ShowDialog();
        }

        private void printZRapor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string ilkFis = "";
            string sonFis = "";
            int ortalamaFis = 0;
            int toplamUcret = 0;
            int iptalFis = 0;
            double kdvUcreti;
            int Yiyecek = 0, Icecek = 0, iptalYiyecek = 0, iptalIcecek = 0;
            int Yiyecek2 = 0, Icecek2 = 0, iptalYiyecek2 = 0, iptalIcecek2 = 0;

            SqlConnection bg = new SqlConnection(ConnectionString);

            bg.Open();
            SqlCommand cmd = new SqlCommand("select MAX(siparisSaat) as kapanis, MIN(siparisSaat) as acilis, COUNT(Tutar) as toplamFisMiktari, AVG(Tutar) as ortalama, SUM(Tutar) as toplamUcret from ZRapor where odemeDurumu='Nakit'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                sonFis = ((TimeSpan)oku["kapanis"]).ToString();
                ilkFis = ((TimeSpan)oku["acilis"]).ToString();
                ortalamaFis = (int)oku["ortalama"];
                toplamUcret = (int)oku["toplamUcret"];
            }
            bg.Close();


            bg.Open();
            try
            {
                cmd = new SqlCommand("select SUM(Tutar) as iptalToplamTutar from ZRapor where odemeDurumu='Fiş İptal'", bg);
                oku = cmd.ExecuteReader();
                if (oku.Read())
                {
                    iptalFis = (int)oku["iptalToplamTutar"];
                }
            }
            catch (Exception)
            { }
            bg.Close();

            kdvUcreti = ((toplamUcret * 18) / 100);

            bg.Open();
            cmd = new SqlCommand("Select * from GunSonu", bg);
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                Yiyecek = (int)oku["yiyecek"];
                Icecek = (int)oku["icecek"];
                iptalYiyecek = (int)oku["iptalYiyecek"];
                iptalIcecek = (int)oku["iptalIcecek"];
            }
            bg.Close();

            int satılanUrunToplam = 0;
            int iptalUrunToplam = 0;

            bg.Open();
            cmd = new SqlCommand("Select * from GunSonuFiyatlar", bg);
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                Yiyecek2 = (int)oku["yiyecek"];
                Icecek2 = (int)oku["icecek"];
                iptalYiyecek2 = (int)oku["iptalYiyecek"];
                iptalIcecek2 = (int)oku["iptalIcecek"];
            }
            bg.Close();

            satılanUrunToplam = Icecek2 + Yiyecek2;
            iptalUrunToplam = iptalYiyecek2 + iptalIcecek2;

            int toplamFis = 0;
            bg.Open();
            cmd = new SqlCommand("select count(*) as toplamFisMiktari from GunlukAdisyon", bg);
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                toplamFis = (int)oku["toplamFisMiktari"];
            }
            bg.Close();

            int paketServisAdet = 0;
            bg.Open();
            cmd = new SqlCommand("Select count(*) as paketServisAdet from PaketServis", bg);
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                paketServisAdet = (int)oku["paketServisAdet"];
            }
            bg.Close();


            //List<int> stokAdet = new List<int>();
            //bg.Open();
            //cmd = new SqlCommand("select * from IcecekStok", bg);
            //oku = cmd.ExecuteReader();
            //if (oku.Read())
            //{
            //    for (int i = 0; i < oku.FieldCount; i++)
            //    {
            //        stokAdet.Add((int)oku[i]);
            //    }
            //}
            //bg.Close();
            //int toplamStokAdet = ToplamYap(stokAdet);


            int adet = 0;
            int personelGider = 0;
            int marketGider = 0;
            int mutfakGider = 0;
            bg.Open();
            try
            {
                cmd = new SqlCommand("select SUM(personelUcret) as toplamTutar, COUNT(*) as adet from PersonelGider", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    adet = (int)oku["adet"];
                    personelGider = (int)oku["toplamTutar"];
                }
            }
            catch (Exception)
            {
            }
            bg.Close();

            bg.Open();
            try
            {
                cmd = new SqlCommand("select * from marketMutfakGider", bg);
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    marketGider = (int)oku["marketGider"];
                    mutfakGider = (int)oku["mutfakGider"];
                }
            }
            catch (Exception)
            {
            }
            bg.Close();

            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                // Pen kalem = new Pen(Color.Black);
                e.Graphics.DrawString($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);

                font = new Font("Arial", 15, FontStyle.Bold);
                Font baslik = new Font("Arial", 27, FontStyle.Bold);
                Font cizgi = new Font("Arial", 12);
                Font font2 = new Font("Arial", 16);
                Font font3 = new Font("Arial", 14, FontStyle.Bold);
                Font font4 = new Font("Arial", 17, FontStyle.Bold);
                Font font5 = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString("KD Katık Döner Z Raporu Ürünlü", baslik, firca, 100, 90);
                e.Graphics.DrawString(("Şube: Söğütlü"), font, firca, 100, 135);
                e.Graphics.DrawString(("İlk Fiş Tarihi: " + ilkFis), font, firca, 100, 167);
                e.Graphics.DrawString(("Son Fiş Tarihi: " + sonFis), font, firca, 100, 199);
                e.Graphics.DrawString(("Çıktı Tarihi: " + ciktiTarihi), font, firca, 100, 230);
                e.Graphics.DrawString(("Kullanıcı: " + Giris.pozisyon), font, firca, 100, 261);
                e.Graphics.DrawString(("Toplam Fiş Adedi: " + toplamFis), font, firca, 100, 291);
                e.Graphics.DrawString(("Paket Servis Adedi: " + paketServisAdet), font, firca, 100, 351);
                e.Graphics.DrawString(("Ortalama Fiş Tutarı: " + ortalamaFis), font, firca, 100, 321);

                e.Graphics.DrawString("****** Satılan Ürünler ******", font4, firca, 100, 397);
                e.Graphics.DrawString(("Yiyecek: " + Yiyecek + "adt.          " + Yiyecek2), font, firca, 100, 429);
                e.Graphics.DrawString(("İçecek:  " + Icecek + "adt.           " + Icecek2), font, firca, 100, 461);
                e.Graphics.DrawString("--------------------------------------------------", cizgi, firca, 100, 485);
                e.Graphics.DrawString(("Adet: " + (Yiyecek+Icecek) + "adt."), font3, firca, 100, 505);
                e.Graphics.DrawString(("Tutar: " + satılanUrunToplam), font3, firca, 270, 505);
                e.Graphics.DrawString("***** İptal Edilen Ürünler *****", font4, firca, 100, 545);
                e.Graphics.DrawString(("Yiyecek: " + iptalYiyecek + "adt.          " + iptalYiyecek2), font, firca, 100, 578);
                e.Graphics.DrawString(("İçecek:  " + iptalIcecek + "adt.           " + iptalIcecek2), font, firca, 100, 610);
                e.Graphics.DrawString("--------------------------------------------------", cizgi, firca, 100, 635);
                e.Graphics.DrawString(("Adet: " + (iptalYiyecek+iptalIcecek) + "adt."), font3, firca, 100, 655);
                e.Graphics.DrawString(("Tutar: " + iptalUrunToplam), font3, firca, 270, 655);
                e.Graphics.DrawString("****** KDV Tutarı ******", font4, firca, 100, 695);
                e.Graphics.DrawString(("Toplam Tutar: " + toplamUcret), font, firca, 100, 728);
                e.Graphics.DrawString(("KDV Oranı: %18"), font, firca, 100, 760);
                e.Graphics.DrawString("--------------------------------------------------", cizgi, firca, 100, 785);
                e.Graphics.DrawString(("Toplam Tutar: " + kdvUcreti), font, firca, 200, 805);
                e.Graphics.DrawString("****** Uygulanan İndirim ******", font4, firca, 100, 845);
                e.Graphics.DrawString(("Toplam İndirim Adedi: "), font5, firca, 100, 885);
                e.Graphics.DrawString(("Toplam İndirim Tutarı: "), font5, firca, 100, 918);
                e.Graphics.DrawString("****** Günlük Giderler ******", font4, firca, 100, 960);
                e.Graphics.DrawString(("Toplam Personel: " + adet), font3, firca, 100, 995);
                e.Graphics.DrawString(("Günlük Personel Ücretleri: " + personelGider), font3, firca, 370, 995);
                e.Graphics.DrawString(("Günlük Mutfak Ücreti: " + mutfakGider), font3, firca, 100, 1027);
                e.Graphics.DrawString(("Günlük Market Ücreti: " + marketGider), font3, firca, 370, 1027);
            }
            catch (Exception)
            { }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            RaporlarAna raporlarAna = new RaporlarAna();
            raporlarAna.Show();
            this.Hide();
        }

        private void txtToplamTutar_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
