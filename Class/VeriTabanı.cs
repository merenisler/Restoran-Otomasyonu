using PizzaciSon1.Siparis;
using PizzaciSon1.Class;
using PizzaciSon1.Masalar;
using PizzaciSon1.Raporlar;
using PizzaciSon1.Ayarlar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaciSon1.Class
{
    internal class VeriTabanı
    {
        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";

        public static bool veriVarmi(string sql)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand(sql, bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { 
                bg.Close();
                return true; 
            }
            else
            {
                bg.Close();
                return false; 
            }
        }

        public static void masaHesapGoster(System.Windows.Forms.Button btn, int masaNo, string masaYeri, int fiyat)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Masalar where masaNo=" + masaNo + " and masaYeri='" + masaYeri + "'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fiyat = (int)dr["fiyat"];
                masaNo = (int)dr["masaNo"];
            }
            if (fiyat!=0)
                btn.Text = masaNo + "\n\n" + fiyat + "TL";
            bg.Close();
        }

        public static void pesinSatisNakit()
        {
            string saat = DateTime.Now.ToLongTimeString();
            SqlConnection bg = new SqlConnection(ConnectionString);
            try
            {
                bg.Open();
                SqlCommand komut = new SqlCommand("insert into ZRapor(satici, siparisSaat, odemeDurumu, islem, tutar) values (@Satici, @Datetime, @odemeDurumu, @islem, @toplamTutar)", bg);
                komut.Parameters.AddWithValue("@Satici", Giris.pozisyon);
                komut.Parameters.AddWithValue("@Datetime", saat);
                komut.Parameters.AddWithValue("@odemeDurumu", "Nakit");
                komut.Parameters.AddWithValue("@islem", "Peşin Satış");
                komut.Parameters.AddWithValue("@toplamTutar", SiparisAna.toplamTutar);
                komut.ExecuteNonQuery();
                bg.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        
        public static void masaVeriKaydet(int masaNo, string masaYeri, int toplamUcret)
        {
            int mutfak = 0;
            int adisyonNo = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (toplamUcret != 0)
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Masalar where masaNo=" + masaNo + " and masaYeri='" + masaYeri + "'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    mutfak = (int)dr["mutfak"];
                    adisyonNo = (int)dr["adisyonNo"];
                }
                bg.Close();
                string AcilisSaat = DateTime.Now.ToLongTimeString();
                if (mutfak != 0)
                {
                    bg.Open();
                    cmd = new SqlCommand("update Masalar set durum=1, fiyat=" + toplamUcret + " where masaNo=" + masaNo + " and masaYeri='" + masaYeri + "'", bg);
                    cmd.ExecuteNonQuery();
                    bg.Close();
                }
                else
                {
                    bg.Open();
                    cmd = new SqlCommand("update Masalar set durum=1, fiyat=" + toplamUcret + ", mutfak=1 where masaNo=" + masaNo + " and masaYeri='" + masaYeri + "'", bg);
                    cmd.ExecuteNonQuery();
                    bg.Close();
                }
                if (adisyonNo==0)
                {
                    int adisyonAdet = 0;
                    bg.Open();
                    cmd = new SqlCommand("select count(adisyonNo) as adisyonAdet from GunlukAdisyon", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        adisyonAdet = (int)dr["adisyonAdet"];
                    }
                    bg.Close();
                    int yeniAdisyonNo = adisyonAdet + 1;
                    bg.Open();
                    cmd = new SqlCommand("update Masalar set adisyonNo=" + yeniAdisyonNo + " where masaNo=" + masaNo + " and masaYeri='" + masaYeri + "'", bg);
                    cmd.ExecuteNonQuery();
                    bg.Close();
                }
            }
        }

        public static void MasaFisİptal(int masaNo, string masaYeri)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            if (masaYeri == "Salon")
            {
                if (SalonMasalar.salonMasaNo == masaNo)
                {
                    string saat = DateTime.Now.ToLongTimeString();
                    double fiyat = 0;
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select * from Masalar where masaNo=" + masaNo + " and masaYeri='Salon'", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        fiyat = (int)dr["fiyat"];
                    }
                    bg.Close();
                    if (fiyat == 0)
                        fiyat = SiparisAna.toplamTutar;
                    try
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("insert into ZRapor(satici, siparisSaat, odemeDurumu, islem, tutar) values (@Satici, @Datetime, @belgeTipi, @islem, @toplamTutar)", bg);
                        komut.Parameters.AddWithValue("@Satici", Giris.pozisyon);
                        komut.Parameters.AddWithValue("@Datetime", saat);
                        komut.Parameters.AddWithValue("@belgeTipi", "Fiş İptal");
                        komut.Parameters.AddWithValue("@islem", ("Salon/" + masaNo));
                        komut.Parameters.AddWithValue("@toplamTutar", fiyat);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                }
            }
            if (masaYeri=="Bahçe")
            {
                if (BahceMasalar.bahceMasaNo == masaNo)
                {
                    string saat = DateTime.Now.ToLongTimeString();
                    double fiyat = 0;
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select * from Masalar where masaNo=" + masaNo + " and masaYeri='Bahçe'", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        fiyat = (int)dr["fiyat"];
                    }
                    bg.Close();
                    if (fiyat == 0)
                        fiyat = SiparisAna.toplamTutar;
                    try
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("insert into ZRapor(satici, siparisSaat, odemeDurumu, islem, tutar) values (@Satici, @Datetime, @belgeTipi, @islem, @toplamTutar)", bg);
                        komut.Parameters.AddWithValue("@Satici", Giris.pozisyon);
                        komut.Parameters.AddWithValue("@Datetime", saat);
                        komut.Parameters.AddWithValue("@belgeTipi", "Fiş İptal");
                        komut.Parameters.AddWithValue("@islem", ("Bahçe/" + masaNo));
                        komut.Parameters.AddWithValue("@toplamTutar", fiyat);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                }
            }

            bg.Open();
            SqlCommand cmd2 = new SqlCommand("update Masalar set fiyat=0, durum='false', mutfak=0, adisyonNo=0 where masaYeri='" + masaYeri + "' and masaNo=" + masaNo + "", bg);
            cmd2.ExecuteNonQuery();
            bg.Close();
        }

        public static void MasaNakit(int masaNo, string masaYeri)
        {
            string saat = DateTime.Now.ToLongTimeString();

            SqlConnection bg = new SqlConnection(ConnectionString);

            if (masaYeri == "Salon")
            {
                if (SalonMasalar.salonMasaNo == masaNo)
                {
                    try
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("insert into ZRapor(satici, siparisSaat, odemeDurumu, islem, tutar) values (@Satici, @Datetime, @odemeDurumu, @islem, @toplamTutar)", bg);
                        komut.Parameters.AddWithValue("@Satici", Giris.pozisyon);
                        komut.Parameters.AddWithValue("@Datetime", saat);
                        komut.Parameters.AddWithValue("@odemeDurumu", "Nakit");
                        komut.Parameters.AddWithValue("@islem", ("Salon/" + masaNo));
                        komut.Parameters.AddWithValue("@toplamTutar", SiparisAna.toplamTutar);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                }
            }
            if (masaYeri == "Bahçe")
            {
                if (BahceMasalar.bahceMasaNo == masaNo)
                {
                    try
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("insert into ZRapor(satici, siparisSaat, odemeDurumu, islem, tutar) values (@Satici, @Datetime, @odemeDurumu, @islem, @toplamTutar)", bg);
                        komut.Parameters.AddWithValue("@Satici", Giris.pozisyon);
                        komut.Parameters.AddWithValue("@Datetime", saat);
                        komut.Parameters.AddWithValue("@odemeDurumu", "Nakit");
                        komut.Parameters.AddWithValue("@islem", ("Bahçe/" + masaNo));
                        komut.Parameters.AddWithValue("@toplamTutar", SiparisAna.toplamTutar);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                }
            }
            bg.Open();
            string sql = "update Masalar set durum=0, fiyat=0, mutfak=0, adisyonNo=0 where masaNo=" + masaNo + " and masaYeri='" + masaYeri + "'";
            SqlCommand cmd = new SqlCommand(sql, bg);
            cmd.ExecuteNonQuery();
            bg.Close();
        }

        public static void pesinSatisFisİptal()
        {
            string saat = DateTime.Now.ToLongTimeString();
            int hesap = (int)SiparisAna.toplamTutar;

            SqlConnection bg = new SqlConnection(ConnectionString);
            try
            {
                if (bg.State == ConnectionState.Closed)
                    bg.Open();
                SqlCommand komut = new SqlCommand("insert into ZRapor(satici, siparisSaat, odemeDurumu, islem, tutar) values (@Satici, @Datetime, @belgeTipi, @islem, @toplamTutar)", bg);
                komut.Parameters.AddWithValue("@Satici", Giris.pozisyon);
                komut.Parameters.AddWithValue("@Datetime", saat);
                komut.Parameters.AddWithValue("@belgeTipi", "Fiş İptal");
                komut.Parameters.AddWithValue("@islem", "Peşin Satış");
                komut.Parameters.AddWithValue("@toplamTutar", hesap);
                komut.ExecuteNonQuery();
                bg.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        public static void lstViewGetirMasa(System.Windows.Forms.ListView lstViewSiparis, int masaNo, string masaYeri)
        {
            string listBox = "";
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from ListboxKontrol where masaNo=" + masaNo + " and masaYeri='" + masaYeri + "' and durum=1", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                listBox = (string)dr["listbox"];
            }
            bg.Close();

            if (listBox != "")
            {
                char ayrac = ',';
                char ayrac2 = '/';
                string[] parcalar = listBox.Split(ayrac);
                for (int i = 0; i < parcalar.Length - 1; i++)
                {
                    string[] Urun = parcalar[i].Split(ayrac2);
                    var satir = new ListViewItem(Urun);
                    lstViewSiparis.Items.Add(satir);
                }
            }
        }

        public static void lstViewGetirAdisyon(System.Windows.Forms.ListView lstViewSiparis, string listBox)
        {
            if (listBox != "")
            {
                char ayrac = ',';
                char ayrac2 = '/';
                string[] parcalar = listBox.Split(ayrac);
                for (int i = 0; i < parcalar.Length - 1; i++)
                {
                    string[] Urun = parcalar[i].Split(ayrac2);
                    var satir = new ListViewItem(Urun);
                    lstViewSiparis.Items.Add(satir);
                }
            }
        }
    }
}
