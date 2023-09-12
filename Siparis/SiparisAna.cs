using PizzaciSon1.Siparis;
using PizzaciSon1.Class;
using PizzaciSon1.Masalar;
using PizzaciSon1.Raporlar;
using PizzaciSon1.Ayarlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bunifu.UI.WinForms.BunifuSnackbar;
using System.Data.SqlClient;
using System.Security.Policy;

namespace PizzaciSon1.Siparis
{
    public partial class SiparisAna : Form
    {
        public SiparisAna()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";

        public static double toplamTutar = 0;

        public static int CocaCola = 0; public static int Fanta = 0; public static int Sprite = 0;
        public static int MAIceTea = 0; public static int seftaliIceTea = 0; public static int limonIceTea = 0;
        public static int karisikMS = 0; public static int seftaliMS = 0; public static int kayisiMS = 0;
        public static int ICocaCola = 0; public static int IICocaCola = 0; public static int IIICocaCola = 0;
        public static int IFanta = 0; public static int IIFanta = 0; public static int IIIFanta = 0;
        public static int Ayran = 0; public static int Su = 0; public static int Soda = 0; public static int Salgam = 0;

        public static int urunAdet = 0;
        public static int urunFiyat = 0;
        public static string urunIsim = "";
        public static string urunStokKategori = "";
        public static string urunKategori = "";

        public static int Yiyecek;
        public static int Icecek;

        public static string fisNotu = "";

        public static string paketServisTelefon = "";
        public static string paketServisAdres = "";

        public static string adisyonAcilisSaat = "";


        public void dinamikMetodYiyecek(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int urunAdet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(urunId) from FiyatListesi where kategori='Yiyecek'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                urunAdet = (int)dr[0];
            }
            bg.Close();
            int urunId = 0;
            string urunIsim = "";
            string stokKategori = "";
            int fiyat = 0;
            for (int i = 1; i <= urunAdet; i++)
            {
                if ((sender as System.Windows.Forms.Button).TabIndex == i)
                {

                    bg.Open();
                    cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY urunId) indexer, * from FiyatListesi where kategori='Yiyecek') tablo where tablo.indexer=" + i + "", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        urunId = ((int)dr["urunId"]);
                    }
                    bg.Close();
                    bg.Open();
                    cmd = new SqlCommand("Select * From FiyatListesi where kategori='Yiyecek' and urunId=" + urunId + "", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        urunIsim = ((string)dr["urunIsim"]);
                        stokKategori = (string)dr["stokKategori"];
                        fiyat = (int)dr["fiyat"];
                    }
                    bg.Close();

                    if (txtUrunAdet.Text != "")
                    {
                        int Adet = Convert.ToInt32(txtUrunAdet.Text);
                        bg.Open();
                        string sql = "update GunSonu set Yiyecek=Yiyecek+" + Adet + "";
                        cmd = new SqlCommand(sql, bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }
                    else
                    {
                        bg.Open();
                        string sql = "update GunSonu set Yiyecek=Yiyecek+1";
                        cmd = new SqlCommand(sql, bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }

                    if (txtUrunAdet.Text != "")
                    {
                        int Adet = Convert.ToInt32(txtUrunAdet.Text);
                        fiyat = Adet * fiyat;
                        bg.Open();
                        string sql = "update GunSonuFiyatlar set Yiyecek=Yiyecek+" + fiyat + "";
                        cmd = new SqlCommand(sql, bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                    }
                    else
                    {
                        bg.Open();
                        string sql = "update GunSonuFiyatlar set Yiyecek=Yiyecek+" + fiyat + "";
                        cmd = new SqlCommand(sql, bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }

                    int miktarInt = 0;

                    if (txtUrunAdet.Text != "")
                    {
                        int toplam;
                        miktarInt = Convert.ToInt32(txtUrunAdet.Text);
                        toplamTutar = toplamTutar + fiyat;
                        ListViewItem listele = new ListViewItem();
                        listele.Text = ("0");
                        listele.SubItems.Add((miktarInt + " ").ToString());
                        listele.SubItems.Add(urunIsim.ToString());
                        listele.SubItems.Add(fiyat.ToString());
                        listele.SubItems.Add(stokKategori);
                        listele.SubItems.Add("Yiyecek");
                        lstViewSiparis.Items.Add(listele);
                        txtUrunAdet.Text = "";

                        //bg.Open();
                        //string sql = "update GunSonu set Yiyecek=Yiyecek+" + miktarInt + " where Sube='" + Giris.Sube + "'";
                        //cmd = new SqlCommand(sql, bg);
                        //cmd.ExecuteNonQuery();
                        //bg.Close();
                    }
                    else
                    {
                        toplamTutar = toplamTutar + fiyat;
                        //listBox1.Items.Add("1 x " + urunIsim + fiyat);
                        ListViewItem listele = new ListViewItem();
                        listele.Text = ("0");
                        listele.SubItems.Add("1 ");
                        listele.SubItems.Add(urunIsim.ToString());
                        listele.SubItems.Add(fiyat.ToString());
                        listele.SubItems.Add(stokKategori);
                        listele.SubItems.Add("Yiyecek");
                        lstViewSiparis.Items.Add(listele);
                        txtUrunAdet.Text = "";

                        //bg.Open();
                        //string sql = "update GunSonu set Yiyecek=Yiyecek+1 where Sube='" + Giris.Sube + "'";
                        //cmd = new SqlCommand(sql, bg);
                        //cmd.ExecuteNonQuery();
                        //bg.Close();
                    }
                    txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;
                }
            }
        }

        public void dinamikMetodIcecek(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int CocaCola = 0; int Fanta = 0; int Sprite = 0;
            int MAIceTea = 0; int seftaliIceTea = 0; int limonIceTea = 0;
            int karisikMS = 0; int seftaliMS = 0; int kayisiMS = 0;
            int ICocaCola = 0; int IICocaCola = 0; int IIICocaCola = 0;
            int IFanta = 0; int IIFanta = 0; int IIIFanta = 0;
            int Ayran = 0; int Su = 0; int Soda = 0; int Salgam = 0;

            int urunAdet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(urunId) from FiyatListesi where kategori='İçecek'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                urunAdet = (int)dr[0];
            }
            bg.Close();

            int urunId = 0;
            string urunIsim = "";
            string stokKategori = "";
            int fiyat = 0;

            for (int i = 1; i <= urunAdet; i++)
            {
                if ((sender as System.Windows.Forms.Button).TabIndex == i)
                {
                    bg.Open();
                    cmd = new SqlCommand("select * from IcecekStok", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        CocaCola = (int)dr["Cola"]; Fanta = (int)dr["Fanta"]; Sprite = (int)dr["Sprite"];
                        MAIceTea = (int)dr["mangoAnanasIceTea"]; seftaliIceTea = (int)dr["seftaliIceTea"]; limonIceTea = (int)dr["limonIceTea"];
                        karisikMS = (int)dr["karisikMeyveSuyu"]; seftaliMS = (int)dr["seftaliMeyveSuyu"]; kayisiMS = (int)dr["kayisiMeyveSuyu"];
                        ICocaCola = (int)dr["ILCola"]; IICocaCola = (int)dr["IILCola"]; IIICocaCola = (int)dr["IIILCola"];
                        IFanta = (int)dr["ILFanta"]; IIFanta = (int)dr["IILFanta"]; IIIFanta = (int)dr["IIILFanta"];
                        Ayran = (int)dr["Ayran"]; Su = (int)dr["Su"]; Soda = (int)dr["Soda"]; Salgam = (int)dr["Salgam"];
                    }
                    bg.Close();

                    if (txtUrunAdet.Text != "")
                    {
                        int Adet = Convert.ToInt32(txtUrunAdet.Text);
                        bg.Open();
                        string sql = "update GunSonu set icecek=icecek+" + Adet + "";
                        cmd = new SqlCommand(sql, bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                    }
                    else
                    {
                        bg.Open();
                        string sql = "update GunSonu set icecek=icecek+1";
                        cmd = new SqlCommand(sql, bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }

                    bg.Open();
                    cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY urunId) indexer, * from FiyatListesi where kategori='İçecek') tablo where tablo.indexer=" + i + "", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    { urunId = ((int)dr["urunId"]); }
                    bg.Close();

                    bg.Open();
                    cmd = new SqlCommand("Select * From FiyatListesi where kategori='İçecek' and urunId=" + urunId + "", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        urunIsim = ((string)dr["urunIsim"]);
                        stokKategori = (string)dr["stokKategori"];
                        fiyat = (int)dr["fiyat"];
                    }
                    bg.Close();

                    if (txtUrunAdet.Text != "")
                    {
                        int Adet = Convert.ToInt32(txtUrunAdet.Text);
                        fiyat = Adet * fiyat;
                        bg.Open();
                        string sql = "update GunSonuFiyatlar set icecek=icecek+" + fiyat + "";
                        cmd = new SqlCommand(sql, bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                    }
                    else
                    {
                        bg.Open();
                        string sql = "update GunSonuFiyatlar set icecek=icecek+" + fiyat + "";
                        cmd = new SqlCommand(sql, bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }

                    string miktar = txtUrunAdet.Text;
                    int miktarInt = 0;

                    if (txtUrunAdet.Text != "")
                    {
                        miktarInt = Convert.ToInt32(miktar);
                        toplamTutar = toplamTutar + fiyat;
                        ListViewItem listele = new ListViewItem();
                        listele.Text = ("0");
                        listele.SubItems.Add((miktarInt + " ").ToString());
                        listele.SubItems.Add(urunIsim.ToString());
                        listele.SubItems.Add(fiyat.ToString());
                        listele.SubItems.Add(stokKategori);
                        listele.SubItems.Add("İçecek");
                        lstViewSiparis.Items.Add(listele);
                        txtUrunAdet.Text = "";
                        if (stokKategori == "Cola")
                            CocaCola = CocaCola - miktarInt;
                        else if (stokKategori == "Fanta")
                            Fanta = Fanta - miktarInt;
                        else if (stokKategori == "Sprite")
                            Sprite = Sprite - miktarInt;
                        else if (stokKategori == "mangoAnanasIceTea")
                            MAIceTea = MAIceTea - miktarInt;
                        else if (stokKategori == "seftaliIceTea")
                            seftaliIceTea = seftaliIceTea - miktarInt;
                        else if (stokKategori == "limonIceTea")
                            limonIceTea = limonIceTea - miktarInt;
                        else if (stokKategori == "seftaliMeyveSuyu")
                            seftaliMS = seftaliMS - miktarInt;
                        else if (stokKategori == "karisikMeyveSuyu")
                            karisikMS = karisikMS - miktarInt;
                        else if (stokKategori == "kayisiMeyveSuyu")
                            kayisiMS = kayisiMS - miktarInt;
                        else if (stokKategori == "ILCola")
                            ICocaCola = ICocaCola - miktarInt;
                        else if (stokKategori == "IILCola")
                            IICocaCola = IICocaCola - miktarInt;
                        else if (stokKategori == "IIILCola")
                            IIICocaCola = IIICocaCola - miktarInt;
                        else if (stokKategori == "ILFanta")
                            IFanta = IFanta - miktarInt;
                        else if (stokKategori == "IILFanta")
                            IIFanta = IIFanta - miktarInt;
                        else if (stokKategori == "IIILFanta")
                            IIIFanta = IIIFanta - miktarInt;
                        else if (stokKategori == "Ayran")
                            Ayran = Ayran - miktarInt;
                        else if (stokKategori == "Su")
                            Su = Su - miktarInt;
                        else if (stokKategori == "Soda")
                            Soda = Soda - miktarInt;
                        else if (stokKategori == "Salgam")
                            Salgam = Salgam - miktarInt;
                    }
                    else
                    {
                        toplamTutar = toplamTutar + fiyat;
                        ListViewItem listele = new ListViewItem();
                        listele.Text = ("0");
                        listele.SubItems.Add("1 ");
                        listele.SubItems.Add(urunIsim.ToString());
                        listele.SubItems.Add(fiyat.ToString());
                        listele.SubItems.Add(stokKategori);
                        listele.SubItems.Add("İçecek");
                        lstViewSiparis.Items.Add(listele);
                        txtUrunAdet.Text = "";
                        if (stokKategori == "Cola")
                            CocaCola = CocaCola - 1;
                        else if (stokKategori == "Fanta")
                            Fanta = Fanta - 1;
                        else if (stokKategori == "Sprite")
                            Sprite = Sprite - 1;
                        else if (stokKategori == "mangoAnanasIceTea")
                            MAIceTea = MAIceTea - 1;
                        else if (stokKategori == "seftaliIceTea")
                            seftaliIceTea = seftaliIceTea - 1;
                        else if (stokKategori == "limonIceTea")
                            limonIceTea = limonIceTea - 1;
                        else if (stokKategori == "seftaliMeyveSuyu")
                            seftaliMS = seftaliMS - 1;
                        else if (stokKategori == "karisikMeyveSuyu")
                            karisikMS = karisikMS - 1;
                        else if (stokKategori == "kayisiMeyveSuyu")
                            kayisiMS = kayisiMS - 1;
                        else if (stokKategori == "ILCola")
                            ICocaCola = ICocaCola - 1;
                        else if (stokKategori == "IILCola")
                            IICocaCola = IICocaCola - 1;
                        else if (stokKategori == "IIILCola")
                            IIICocaCola = IIICocaCola - 1;
                        else if (stokKategori == "ILFanta")
                            IFanta = IFanta - 1;
                        else if (stokKategori == "IILFanta")
                            IIFanta = IIFanta - 1;
                        else if (stokKategori == "IIILFanta")
                            IIIFanta = IIIFanta - 1;
                        else if (stokKategori == "Ayran")
                            Ayran = Ayran - 1;
                        else if (stokKategori == "Su")
                            Su = Su - 1;
                        else if (stokKategori == "Soda")
                            Soda = Soda - 1;
                        else if (stokKategori == "Salgam")
                            Salgam = Salgam - 1;
                    }
                    txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;

                    bg.Open();
                    SqlCommand guncel = new SqlCommand("update IcecekStok set Ayran=@Ayran, Su=@Su, Soda=@Soda, Salgam=@Salgam, Cola=@Cola, Fanta=@Fanta, Sprite=@Sprite, mangoAnanasIceTea=@mangoAnanasIceTea, seftaliIceTea=@seftaliIceTea, limonIceTea=@limonIceTea, karisikMeyveSuyu=@karisikMeyveSuyu, seftaliMeyveSuyu=@seftaliMeyveSuyu, kayisiMeyveSuyu=@kayisiMeyveSuyu, ILCola=@ILCola, IILCola=@IILCola, IIILCola=@IIILCola, ILFanta=@ILFanta, IILFanta=@IILFanta, IIILFanta=@IIILFanta", bg);
                    guncel.Parameters.AddWithValue("@Ayran", Ayran);
                    guncel.Parameters.AddWithValue("@Su", Su);
                    guncel.Parameters.AddWithValue("@Soda", Soda);
                    guncel.Parameters.AddWithValue("@Salgam", Salgam);
                    guncel.Parameters.AddWithValue("@Cola", CocaCola);
                    guncel.Parameters.AddWithValue("@Fanta", Fanta);
                    guncel.Parameters.AddWithValue("@Sprite", Sprite);
                    guncel.Parameters.AddWithValue("@mangoAnanasIceTea", MAIceTea);
                    guncel.Parameters.AddWithValue("@seftaliIceTea", seftaliIceTea);
                    guncel.Parameters.AddWithValue("@limonIceTea", limonIceTea);
                    guncel.Parameters.AddWithValue("@karisikMeyveSuyu", karisikMS);
                    guncel.Parameters.AddWithValue("@seftaliMeyveSuyu", seftaliMS);
                    guncel.Parameters.AddWithValue("@kayisiMeyveSuyu", kayisiMS);
                    guncel.Parameters.AddWithValue("@ILCola", ICocaCola);
                    guncel.Parameters.AddWithValue("@IILCola", IICocaCola);
                    guncel.Parameters.AddWithValue("@IIILCola", IIICocaCola);
                    guncel.Parameters.AddWithValue("@ILFanta", IFanta);
                    guncel.Parameters.AddWithValue("@IILFanta", IIFanta);
                    guncel.Parameters.AddWithValue("@IIILFanta", IIIFanta);
                    guncel.ExecuteNonQuery();
                    bg.Close();
                }
            }
        }

        private void SiparisAna_Load(object sender, EventArgs e)
        {
            adisyonAcilisSaat = DateTime.Now.ToLongTimeString();
            SqlConnection bg = new SqlConnection(ConnectionString);

            if (SalonMasalar.salonMasa == true)
            {
                btnMasaSayisi.Text = "Salon/" + SalonMasalar.salonMasaNo.ToString();
                btnAdisyon.Enabled = false;

                bg.Open();
                SqlCommand komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                SqlDataReader dr2 = komut.ExecuteReader();
                while (dr2.Read())
                { fisNotu = (string)dr2["fisNotu"]; }
                bg.Close();

                bool durum = false;
                bg.Open();
                komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                dr2 = komut.ExecuteReader();
                while (dr2.Read())
                { durum = (bool)dr2["durum"]; }
                bg.Close();

                int masaSayisi = 0;
                bg.Open();
                komut = new SqlCommand("select count(*) as masaSayisi from Masalar where masaYeri='Salon'", bg);
                dr2 = komut.ExecuteReader();
                while (dr2.Read())
                { masaSayisi = (int)dr2["masaSayisi"]; }
                bg.Close();

                string yazdir = "";
                int adet = 0;
                string isim = "";
                int fiyatt = 0;
                string stokKategori = "";
                string kategori = "";
                bool yazdirdiMi = false;
                if (durum == true)
                {
                    for (int i = 1; i <= masaSayisi; i++)
                    {
                        if (SalonMasalar.salonMasaNo == i)
                        {
                            string masaNo = "Salon" + i;
                            bg.Open();
                            SqlCommand komut5 = new SqlCommand("select * from " + masaNo + "", bg);
                            dr2 = komut5.ExecuteReader();
                            while (dr2.Read())
                            {
                                yazdirdiMi = (bool)dr2["yazdir"];
                                adet = (int)dr2["adet"];
                                isim = (string)dr2["isim"];
                                fiyatt = (int)dr2["fiyat"];
                                stokKategori = (string)dr2["stokKategori"];
                                kategori = (string)dr2["kategori"];

                                if (yazdirdiMi == false)
                                    yazdir = "0";
                                if (yazdirdiMi == true)
                                    yazdir = "1";

                                string listbox = yazdir + "/" + adet + "/" + isim + "/" + fiyatt + "/" + stokKategori + "/" + kategori;
                                char ayrac2 = '/';
                                string[] Urun = listbox.Split(ayrac2);
                                var satir = new ListViewItem(Urun);
                                lstViewSiparis.Items.Add(satir);
                            }
                            bg.Close();
                        }
                    }
                }

                int fiyat = 0;
                bg.Open();
                SqlCommand cmd2 = new SqlCommand("select * from Masalar where masaNo=" + SalonMasalar.salonMasaNo + " and masaYeri='Salon'", bg);
                dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    fiyat = (int)dr2["fiyat"];
                }
                bg.Close();

                txtBxToplamTutar.Text = "Toplam Tutar: " + fiyat;
                toplamTutar = fiyat;

            }
            if (BahceMasalar.bahceMasa == true)
            {
                btnMasaSayisi.Text = "Bahçe/" + BahceMasalar.bahceMasaNo.ToString();
                btnAdisyon.Enabled = false;

                bg.Open();
                SqlCommand komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                SqlDataReader dr2 = komut.ExecuteReader();
                while (dr2.Read())
                { fisNotu = (string)dr2["fisNotu"]; }
                bg.Close();

                bool durum = false;
                bg.Open();
                komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                SqlDataReader dr3 = komut.ExecuteReader();
                while (dr3.Read())
                { durum = (bool)dr3["durum"]; }
                bg.Close();

                int masaSayisi = 0;
                bg.Open();
                komut = new SqlCommand("select count(*) as masaSayisi from Masalar where masaYeri='Bahçe'", bg);
                dr2 = komut.ExecuteReader();
                while (dr2.Read())
                { masaSayisi = (int)dr2["masaSayisi"]; }
                bg.Close();

                string yazdir = "";
                int adet = 0;
                string isim = "";
                int fiyatt = 0;
                string stokKategori = "";
                string kategori = "";
                bool yazdirdiMi = false;
                if (durum == true)
                {
                    for (int i = 1; i <= masaSayisi; i++)
                    {
                        if (BahceMasalar.bahceMasaNo == i)
                        {
                            string masaNo = "Bahce" + i;
                            bg.Open();
                            string sql = "select * from " + masaNo + "";
                            SqlCommand komut5 = new SqlCommand(sql, bg);
                            SqlDataReader dr5 = komut5.ExecuteReader();
                            while (dr5.Read())
                            {
                                yazdirdiMi = (bool)dr5["yazdir"];
                                adet = (int)dr5["adet"];
                                isim = (string)dr5["isim"];
                                fiyatt = (int)dr5["fiyat"];
                                stokKategori = (string)dr5["stokKategori"];
                                kategori = (string)dr5["kategori"];

                                if (yazdirdiMi == false)
                                    yazdir = "0";
                                if (yazdirdiMi == true)
                                    yazdir = "1";

                                string listbox = yazdir + "/" + adet + "/" + isim + "/" + fiyatt + "/" + stokKategori + "/" + kategori;
                                char ayrac2 = '/';
                                string[] Urun = listbox.Split(ayrac2);
                                var satir = new ListViewItem(Urun);
                                lstViewSiparis.Items.Add(satir);
                            }
                            bg.Close();
                        }
                    }
                }

                int fiyat = 0;
                bg.Open();
                SqlCommand cmd2 = new SqlCommand("select * from Masalar where masaNo=" + BahceMasalar.bahceMasaNo + " and masaYeri='Bahçe'", bg);
                dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    fiyat = (int)dr2["fiyat"];
                }
                bg.Close();

                txtBxToplamTutar.Text = "Toplam Tutar: " + fiyat;
                toplamTutar = fiyat;
            }
            if (AdisyonRapor.siparisSecildiMi == true)
            {
                btnMasaSayisi.Text = AdisyonRapor.islem;
                string adisyonIcerik = "";
                int tutar = 0;
                bg.Open();
                SqlCommand komut = new SqlCommand("select * from GunlukAdisyon where adisyonNo=" + AdisyonRapor.adisyonNo + "", bg);
                SqlDataReader dr2 = komut.ExecuteReader();
                while (dr2.Read())
                {
                    adisyonIcerik = (string)dr2["adisyonIcerik"];
                    char ayrac = ',';
                    char ayrac2 = '/';
                    string[] Urun = adisyonIcerik.Split(ayrac);
                    int sonEleman = Urun.Length - 1;
                    for (int i = 0; i < Urun.Length; i++)
                    {
                        if (i != sonEleman)
                        {
                            string[] Urun2 = Urun[i].Split(ayrac2);
                            var satir = new ListViewItem(Urun2);
                            lstViewSiparis.Items.Add(satir);
                        }
                    }
                    tutar = (int)dr2["tutar"];
                    txtBxToplamTutar.Text = "Toplam Tutar: " + tutar.ToString();
                    toplamTutar = tutar;
                }
                bg.Close();
            }


            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from IcecekStok", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CocaCola = (int)dr["Cola"]; Fanta = (int)dr["Fanta"]; Sprite = (int)dr["Sprite"]; MAIceTea = (int)dr["mangoAnanasIceTea"];
                seftaliIceTea = (int)dr["seftaliIceTea"]; limonIceTea = (int)dr["limonIceTea"]; karisikMS = (int)dr["karisikMeyveSuyu"];
                seftaliMS = (int)dr["seftaliMeyveSuyu"]; kayisiMS = (int)dr["kayisiMeyveSuyu"]; ICocaCola = (int)dr["ILCola"];
                IICocaCola = (int)dr["IILCola"]; IIICocaCola = (int)dr["IIILCola"]; IFanta = (int)dr["ILFanta"];
                IIFanta = (int)dr["IILFanta"]; IIIFanta = (int)dr["IIILFanta"]; Ayran = (int)dr["Ayran"];
                Su = (int)dr["Su"]; Soda = (int)dr["Soda"]; Salgam = (int)dr["Salgam"];
            }
            bg.Close();

            //YiyecekButton
            int urunAdet = 0;
            bg.Open();
            cmd = new SqlCommand("select count(urunId) from FiyatListesi where kategori='Yiyecek'", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            { urunAdet = (int)dr[0]; }
            bg.Close();

            List<string> urunIsim = new List<string>();
            List<int> urunFiyat = new List<int>();
            List<string> urunStok = new List<string>();
            int urunId = 0;
            for (int i = 1; i <= urunAdet; i++)
            {
                bg.Open();
                cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY urunId) indexer, * from FiyatListesi where kategori='Yiyecek') tablo where tablo.indexer=" + i + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { urunId = ((int)dr["urunId"]); }
                bg.Close();
                bg.Open();
                cmd = new SqlCommand("Select * From FiyatListesi where kategori='Yiyecek' and urunID=" + urunId + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    urunIsim.Add((string)dr["urunIsim"]);
                    urunFiyat.Add((int)dr["fiyat"]);
                    urunStok.Add((string)dr["stokKategori"]);
                }
                bg.Close();
            }

            for (int i = 1; i <= urunAdet; i++)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Name = "Buton" + i.ToString();
                btn.Size = new Size(125, 122);
                btn.Text = (urunIsim[(i - 1)] + " " + urunFiyat[(i - 1)] + ".00");
                btn.Margin = new Padding(0);
                btn.Font = new Font("Microsoft JhengHei", 12, FontStyle.Bold);
                btn.BackColor = Color.Firebrick;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                YiyecekPanel.Controls.Add(btn);
                btn.Click += new EventHandler(dinamikMetodYiyecek);
                btn.TabIndex = i;
            }

            //İçecekButton
            int urunAdet2 = 0;
            bg.Open();
            cmd = new SqlCommand("select count(urunId) from FiyatListesi where kategori='İçecek'", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            { urunAdet2 = (int)dr[0]; }
            bg.Close();

            List<string> urunIsim2 = new List<string>();
            List<int> urunFiyat2 = new List<int>();
            List<string> urunStok2 = new List<string>();
            int urunId2 = 0;

            for (int i = 1; i <= urunAdet2; i++)
            {
                bg.Open();
                cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY urunId) indexer, * from FiyatListesi where kategori='İçecek') tablo where tablo.indexer=" + i + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { urunId2 = ((int)dr["urunId"]); }
                bg.Close();
                bg.Open();
                cmd = new SqlCommand("Select * From FiyatListesi where kategori='İçecek' and urunId=" + urunId2 + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    urunIsim2.Add((string)dr["urunIsim"]);
                    urunFiyat2.Add((int)dr["fiyat"]);
                    urunStok2.Add((string)dr["stokKategori"]);
                }
                bg.Close();
            }

            for (int i = 1; i <= urunAdet2; i++)
            {
                System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
                btn2.Name = "btn" + i.ToString();
                btn2.Size = new Size(150, 122);
                btn2.Text = (urunIsim2[(i - 1)] + " " + urunFiyat2[(i - 1)] + ".00");
                btn2.Margin = new Padding(0);
                btn2.Font = new Font("Microsoft JhengHei", 12, FontStyle.Bold);
                btn2.BackColor = Color.Blue;
                btn2.ForeColor = Color.White;
                btn2.FlatStyle = FlatStyle.Flat;
                IcecekPanel.Controls.Add(btn2);
                btn2.Click += new EventHandler(dinamikMetodIcecek);
                btn2.TabIndex = i;

                if (urunStok2[i - 1] == "Cola")
                {
                    if (CocaCola <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "Fanta")
                {
                    if (Fanta <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "Sprite")
                {
                    if (Sprite <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "mangoAnanasAIceTea")
                {
                    if (MAIceTea <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "seftaliIceTea")
                {
                    if (seftaliIceTea <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "limonIceTea")
                {
                    if (limonIceTea <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "karisikMeyveSuyu")
                {
                    if (karisikMS <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "seftaliMeyveSuyu")
                {
                    if (seftaliMS <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "kayisiMeyveSuyu")
                {
                    if (kayisiMS <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "ILCola")
                {
                    if (ICocaCola <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "IILCola")
                {
                    if (IICocaCola <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "IIILCola")
                {
                    if (IIICocaCola <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "ILFanta")
                {
                    if (IFanta <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "IILFanta")
                {
                    if (IIFanta <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "IIILFanta")
                {
                    if (IIIFanta <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "Ayran")
                {
                    if (Ayran <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "Su")
                {
                    if (Su <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "Soda")
                {
                    if (Soda <= 0)
                        btn2.Enabled = false;
                }
                if (urunStok2[i - 1] == "Salgam")
                {
                    if (Salgam <= 0)
                        btn2.Enabled = false;
                }
            }

            int row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13, row14, row15, row16, row17, row18, row19, row20;
            bg.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='Cola'", bg);
            row1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='Fanta'", bg);
            row2 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='Sprite'", bg);
            row3 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='mangoAnanasIceTea'", bg);
            row4 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='seftaliIceTea'", bg);
            row5 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='limonIceTea'", bg);
            row6 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='karisikMeyveSuyu'", bg);
            row7 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='seftaliMeyveSuyu'", bg);
            row8 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='kayisiMeyveSuyu'", bg);
            row9 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='ILCola'", bg);
            row10 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='IILCola'", bg);
            row11 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='IIILCola'", bg);
            row12 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='ILFanta'", bg);
            row13 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='IILFanta'", bg);
            row14 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='IIILFanta'", bg);
            row15 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='Ayran'", bg);
            row16 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='Su'", bg);
            row17 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='Soda'", bg);
            row18 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM FiyatListesi WHERE kategori='İçecek' and stokKategori='Salgam'", bg);
            row19 = (int)cmd.ExecuteScalar();
            bg.Close();

            if (row1 > 0)
                VeriTabanı.stokUyarı(CocaCola, "Cola");
            if (row2 > 0)
                VeriTabanı.stokUyarı(Fanta, "Fanta");
            if (row3 > 0)
                VeriTabanı.stokUyarı(Sprite, "Sprite");
            if (row4 > 0)
                VeriTabanı.stokUyarı(MAIceTea, "mangoAnanasIceTea");
            if (row5 > 0)
                VeriTabanı.stokUyarı(seftaliIceTea, "seftaliIceTea");
            if (row6 > 0)
                VeriTabanı.stokUyarı(limonIceTea, "limonIceTea");
            if (row7 > 0)
                VeriTabanı.stokUyarı(karisikMS, "karisikMeyveSuyu");
            if (row8 > 0)
                VeriTabanı.stokUyarı(seftaliMS, "seftaliMeyveSuyu");
            if (row9 > 0)
                VeriTabanı.stokUyarı(kayisiMS, "kirazliMeyveSuyu");
            if (row10 > 0)
                VeriTabanı.stokUyarı(ICocaCola, "ILCocaCola");
            if (row11 > 0)
                VeriTabanı.stokUyarı(IICocaCola, "IILCocaCola");
            if (row12 > 0)
                VeriTabanı.stokUyarı(IIICocaCola, "IIILCocaCola");
            if (row13 > 0)
                VeriTabanı.stokUyarı(IFanta, "ILFanta");
            if (row14 > 0)
                VeriTabanı.stokUyarı(IIFanta, "IILFanta");
            if (row15 > 0)
                VeriTabanı.stokUyarı(IIIFanta, "IIILFanta");
            if (row16 > 0)
                VeriTabanı.stokUyarı(Ayran, "Ayran");
            if (row17 > 0)
                VeriTabanı.stokUyarı(Su, "Su");
            if (row18 > 0)
                VeriTabanı.stokUyarı(Soda, "Soda");
            if (row19 > 0)
                VeriTabanı.stokUyarı(Salgam, "Salgam");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            if (SalonMasalar.salonMasa == true)
            {
                bool durum = true;
                if (lstViewSiparis.Items.Count != 0)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        durum = (bool)dr["durum"];
                    }
                    bg.Close();


                    VeriTabanı.masaVeriKaydet(SalonMasalar.salonMasaNo, "Salon", (int)toplamTutar);

                    if (durum == false)
                    {
                        string adisyonAcilisSaat = DateTime.Now.ToLongTimeString();
                        string listbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            listbox = listbox + dizi[i];
                        }
                        try
                        {
                            bg.Open();
                            string kayit = "insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)";
                            komut = new SqlCommand(kayit, bg);
                            komut.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                            komut.Parameters.AddWithValue("@adisyonKapanisSaat", "");
                            komut.Parameters.AddWithValue("@adisyonIcerik", listbox);
                            komut.Parameters.AddWithValue("@odemeDurumu", "");
                            komut.Parameters.AddWithValue("@islem", ("Salon/" + SalonMasalar.salonMasaNo));
                            komut.Parameters.AddWithValue("@tutar", toplamTutar);
                            komut.ExecuteNonQuery();
                            bg.Close();
                        }
                        catch (Exception hata)
                        { MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message); }

                        string AcilisSaat = DateTime.Now.ToLongTimeString();
                        bg.Open();
                        SqlCommand cmd = new SqlCommand("update ListboxKontrol set listbox=@listbox, tutar=@fiyat, durum=@durum, fisNotu=@fisNotu where masaYeri=@masaYeri and masaNo=@masaNo", bg);
                        cmd.Parameters.AddWithValue("@listbox", listbox);
                        cmd.Parameters.AddWithValue("@fiyat", toplamTutar);
                        cmd.Parameters.AddWithValue("@durum", 1);
                        cmd.Parameters.AddWithValue("@masaYeri", "Salon");
                        cmd.Parameters.AddWithValue("@masaNo", SalonMasalar.salonMasaNo);
                        cmd.Parameters.AddWithValue("@fisNotu", fisNotu);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        int masaAdet = 0;
                        bg.Open();
                        komut = new SqlCommand("select count(*) as masaAdet from Masalar where masaYeri='Salon'", bg);
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        { masaAdet = (int)dr["masaAdet"]; }
                        bg.Close();

                        for (int i = 1; i <= masaAdet; i++)
                        {
                            if (SalonMasalar.salonMasaNo == i)
                            {
                                string yazdir = "";
                                int adet = 0;
                                string isim = "";
                                int fiyat = 0;
                                string stokKategori = "";
                                string kategori = "";
                                for (int j = 0; j < lstViewSiparis.Items.Count; j++)
                                {
                                    yazdir = lstViewSiparis.Items[j].SubItems[0].Text;
                                    adet = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[1].Text);
                                    isim = lstViewSiparis.Items[j].SubItems[2].Text;
                                    try { fiyat = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[3].Text); }
                                    catch (Exception) { }
                                    stokKategori = lstViewSiparis.Items[j].SubItems[4].Text;
                                    kategori = lstViewSiparis.Items[j].SubItems[5].Text;

                                    bool yazdirdiMi = false;
                                    if (yazdir == "0")
                                        yazdirdiMi = false;
                                    if (yazdir == "1")
                                        yazdirdiMi = true;

                                    string masaNo = "Salon" + i;
                                    bg.Open();
                                    cmd = new SqlCommand("insert into " + masaNo + "(yazdir, adet, isim, fiyat, stokKategori, kategori) values (@yazdir, @adet, @isim, @fiyat, @stokKategori, @kategori)", bg);
                                    cmd.Parameters.AddWithValue("@yazdir", yazdirdiMi);
                                    cmd.Parameters.AddWithValue("@adet", adet);
                                    cmd.Parameters.AddWithValue("@isim", isim);
                                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                                    cmd.Parameters.AddWithValue("@stokKategori", stokKategori);
                                    cmd.Parameters.AddWithValue("@kategori", kategori);
                                    cmd.ExecuteNonQuery();
                                    bg.Close();
                                }
                            }
                        }
                    }

                    if (durum == true)
                    {
                        string guncelFisNotu = "";
                        bg.Open();
                        komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        { guncelFisNotu = (string)dr["fisNotu"]; }
                        bg.Close();

                        if (fisNotu != guncelFisNotu)
                            guncelFisNotu = fisNotu;

                        string listbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            listbox = listbox + dizi[i];
                        }
                        string AcilisSaat = DateTime.Now.ToLongTimeString();
                        bg.Open();
                        string sql = "update ListboxKontrol set listbox=@listbox, tutar=@fiyat, durum=@durum, fisNotu=@fisNotu where masaYeri=@masaYeri and masaNo=@masaNo";
                        SqlCommand cmd = new SqlCommand(sql, bg);
                        cmd.Parameters.AddWithValue("@listbox", listbox);
                        cmd.Parameters.AddWithValue("@fiyat", toplamTutar);
                        cmd.Parameters.AddWithValue("@durum", 1);
                        cmd.Parameters.AddWithValue("@masaYeri", "Salon");
                        cmd.Parameters.AddWithValue("@masaNo", SalonMasalar.salonMasaNo);
                        cmd.Parameters.AddWithValue("@fisNotu", fisNotu);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        string guncelListbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            guncelListbox = guncelListbox + dizi[i];
                        }
                        bg.Open();
                        SqlCommand guncel = new SqlCommand("update GunlukAdisyon set adisyonIcerik=@adisyonIcerik, tutar=@tutar where islem='Salon/" + SalonMasalar.salonMasaNo + "' and odemeDurumu=''", bg);
                        guncel.Parameters.AddWithValue("@adisyonIcerik", guncelListbox);
                        guncel.Parameters.AddWithValue("@tutar", toplamTutar);
                        guncel.ExecuteNonQuery();
                        bg.Close();

                        int masaAdet = 0;
                        bg.Open();
                        komut = new SqlCommand("select count(*) as masaAdet from Masalar where masaYeri='Salon'", bg);
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        { masaAdet = (int)dr["masaAdet"]; }
                        bg.Close();

                        for (int i = 1; i <= masaAdet; i++)
                        {
                            if (SalonMasalar.salonMasaNo == i)
                            {
                                string masaNo = "Salon" + i;

                                bg.Open();
                                cmd = new SqlCommand("delete from " + masaNo + "", bg);
                                cmd.ExecuteNonQuery();
                                bg.Close();

                                string yazdir = "";
                                int adet = 0;
                                string isim = "";
                                int fiyat = 0;
                                string stokKategori = "";
                                string kategori = "";
                                for (int j = 0; j < lstViewSiparis.Items.Count; j++)
                                {
                                    yazdir = lstViewSiparis.Items[j].SubItems[0].Text;
                                    adet = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[1].Text);
                                    isim = lstViewSiparis.Items[j].SubItems[2].Text;
                                    fiyat = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[3].Text);
                                    stokKategori = lstViewSiparis.Items[j].SubItems[4].Text;
                                    kategori = lstViewSiparis.Items[j].SubItems[5].Text;

                                    bool yazdirdiMi = false;
                                    if (yazdir == "0")
                                        yazdirdiMi = false;
                                    if (yazdir == "1")
                                        yazdirdiMi = true;

                                    bg.Open();
                                    sql = "insert into " + masaNo + "(yazdir, adet, isim, fiyat, stokKategori, kategori) values (@yazdir, @adet, @isim, @fiyat, @stokKategori, @kategori)";
                                    cmd = new SqlCommand(sql, bg);
                                    cmd.Parameters.AddWithValue("@yazdir", yazdirdiMi);
                                    cmd.Parameters.AddWithValue("@adet", adet);
                                    cmd.Parameters.AddWithValue("@isim", isim);
                                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                                    cmd.Parameters.AddWithValue("@stokKategori", stokKategori);
                                    cmd.Parameters.AddWithValue("@kategori", kategori);
                                    cmd.ExecuteNonQuery();
                                    bg.Close();
                                }
                            }
                        }
                    }
                }

                toplamTutar = 0;

                SalonMasalar salonMasa = new SalonMasalar();
                salonMasa.Show();
                this.Hide();
            }
            else if (BahceMasalar.bahceMasa == true)
            {
                bool durum = true;
                int fiyat2 = 0;
                if (lstViewSiparis.Items.Count != 0)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        durum = (bool)dr["durum"];
                        fiyat2 = (int)dr["tutar"];
                    }
                    bg.Close();

                    VeriTabanı.masaVeriKaydet(BahceMasalar.bahceMasaNo, "Bahçe", (int)toplamTutar);

                    if (durum == false)
                    {
                        string adisyonAcilisSaat = DateTime.Now.ToLongTimeString();
                        string listbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            listbox = listbox + dizi[i];
                        }
                        bg.Open();
                        string kayit = "insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)";
                        komut = new SqlCommand(kayit, bg);
                        komut.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                        komut.Parameters.AddWithValue("@adisyonKapanisSaat", "");
                        komut.Parameters.AddWithValue("@adisyonIcerik", listbox);
                        komut.Parameters.AddWithValue("@odemeDurumu", "");
                        komut.Parameters.AddWithValue("@islem", ("Bahçe/" + BahceMasalar.bahceMasaNo));
                        komut.Parameters.AddWithValue("@tutar", toplamTutar);
                        komut.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        string sql = "update ListboxKontrol set listbox=@listbox, tutar=@fiyat, durum=@durum, fisNotu=@fisNotu where masaYeri=@masaYeri and masaNo=@masaNo";
                        SqlCommand cmd = new SqlCommand(sql, bg);
                        cmd.Parameters.AddWithValue("@listbox", listbox);
                        cmd.Parameters.AddWithValue("@fiyat", toplamTutar);
                        cmd.Parameters.AddWithValue("@durum", 1);
                        cmd.Parameters.AddWithValue("@masaYeri", "Bahçe");
                        cmd.Parameters.AddWithValue("@masaNo", BahceMasalar.bahceMasaNo);
                        cmd.Parameters.AddWithValue("@fisNotu", fisNotu);
                        cmd.ExecuteNonQuery();
                        bg.Close();


                        int masaAdet = 0;
                        bg.Open();
                        komut = new SqlCommand("select count(*) as masaAdet from Masalar where masaYeri='Bahçe'", bg);
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            masaAdet = (int)dr["masaAdet"];
                        }
                        bg.Close();

                        for (int i = 1; i <= masaAdet; i++)
                        {
                            if (BahceMasalar.bahceMasaNo == i)
                            {
                                string yazdir = "";
                                int adet = 0;
                                string isim = "";
                                int fiyat = 0;
                                string stokKategori = "";
                                string kategori = "";
                                for (int j = 0; j < lstViewSiparis.Items.Count; j++)
                                {
                                    yazdir = lstViewSiparis.Items[j].SubItems[0].Text;
                                    adet = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[1].Text);
                                    isim = lstViewSiparis.Items[j].SubItems[2].Text;
                                    fiyat = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[3].Text);
                                    stokKategori = lstViewSiparis.Items[j].SubItems[4].Text;
                                    kategori = lstViewSiparis.Items[j].SubItems[5].Text;

                                    bool yazdirdiMi = false;
                                    if (yazdir == "0")
                                        yazdirdiMi = false;
                                    if (yazdir == "1")
                                        yazdirdiMi = true;

                                    string masaNo = "Bahce" + i;
                                    bg.Open();
                                    sql = "insert into " + masaNo + "(yazdir, adet, isim, fiyat, stokKategori, kategori) values (@yazdir, @adet, @isim, @fiyat, @stokKategori, @kategori)";
                                    cmd = new SqlCommand(sql, bg);
                                    cmd.Parameters.AddWithValue("@yazdir", yazdirdiMi);
                                    cmd.Parameters.AddWithValue("@adet", adet);
                                    cmd.Parameters.AddWithValue("@isim", isim);
                                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                                    cmd.Parameters.AddWithValue("@stokKategori", stokKategori);
                                    cmd.Parameters.AddWithValue("@kategori", kategori);
                                    cmd.ExecuteNonQuery();
                                    bg.Close();
                                }
                            }
                        }
                    }

                    if (durum == true)
                    {
                        string guncelFisNotu = "";
                        bg.Open();
                        komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            guncelFisNotu = (string)dr["fisNotu"];
                        }
                        bg.Close();
                        if (fisNotu != guncelFisNotu)
                        {
                            guncelFisNotu = fisNotu;
                        }
                        bg.Open();

                        string listbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            listbox = listbox + dizi[i];
                        }
                        string AcilisSaat = DateTime.Now.ToLongTimeString();
                        string sql = "update ListboxKontrol set listbox=@listbox, tutar=@fiyat, durum=@durum, fisNotu=@fisNotu where masaYeri=@masaYeri and masaNo=@masaNo";
                        SqlCommand cmd = new SqlCommand(sql, bg);
                        cmd.Parameters.AddWithValue("@listbox", listbox);
                        cmd.Parameters.AddWithValue("@fiyat", toplamTutar);
                        cmd.Parameters.AddWithValue("@durum", 1);
                        cmd.Parameters.AddWithValue("@masaYeri", "Bahçe");
                        cmd.Parameters.AddWithValue("@masaNo", BahceMasalar.bahceMasaNo);
                        cmd.Parameters.AddWithValue("@fisNotu", fisNotu);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        string guncelListbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            guncelListbox = guncelListbox + dizi[i];
                        }
                        bg.Open();
                        SqlCommand guncel = new SqlCommand("update GunlukAdisyon set adisyonIcerik=@adisyonIcerik, tutar=@tutar where islem='Bahçe/" + BahceMasalar.bahceMasaNo + "' and odemeDurumu=''", bg);
                        guncel.Parameters.AddWithValue("@adisyonIcerik", guncelListbox);
                        guncel.Parameters.AddWithValue("@tutar", toplamTutar);
                        guncel.ExecuteNonQuery();
                        bg.Close();

                        int masaAdet = 0;
                        bg.Open();
                        komut = new SqlCommand("select count(*) as masaAdet from Masalar where masaYeri='Bahçe'", bg);
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            masaAdet = (int)dr["masaAdet"];
                        }
                        bg.Close();

                        for (int i = 1; i <= masaAdet; i++)
                        {
                            if (BahceMasalar.bahceMasaNo == i)
                            {
                                string masaNo = "Bahce" + i;

                                bg.Open();
                                cmd = new SqlCommand("delete from " + masaNo + "", bg);
                                cmd.ExecuteNonQuery();
                                bg.Close();

                                string yazdir = "";
                                int adet = 0;
                                string isim = "";
                                int fiyat = 0;
                                string stokKategori = "";
                                string kategori = "";
                                for (int j = 0; j < lstViewSiparis.Items.Count; j++)
                                {
                                    yazdir = lstViewSiparis.Items[j].SubItems[0].Text;
                                    adet = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[1].Text);
                                    isim = lstViewSiparis.Items[j].SubItems[2].Text;
                                    fiyat = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[3].Text);
                                    stokKategori = lstViewSiparis.Items[j].SubItems[4].Text;
                                    kategori = lstViewSiparis.Items[j].SubItems[5].Text;

                                    bool yazdirdiMi = false;
                                    if (yazdir == "0")
                                        yazdirdiMi = false;
                                    if (yazdir == "1")
                                        yazdirdiMi = true;

                                    bg.Open();
                                    sql = "insert into " + masaNo + "(yazdir, adet, isim, fiyat, stokKategori, kategori) values (@yazdir, @adet, @isim, @fiyat, @stokKategori, @kategori)";
                                    cmd = new SqlCommand(sql, bg);
                                    cmd.Parameters.AddWithValue("@yazdir", yazdirdiMi);
                                    cmd.Parameters.AddWithValue("@adet", adet);
                                    cmd.Parameters.AddWithValue("@isim", isim);
                                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                                    cmd.Parameters.AddWithValue("@stokKategori", stokKategori);
                                    cmd.Parameters.AddWithValue("@kategori", kategori);
                                    cmd.ExecuteNonQuery();
                                    bg.Close();
                                }
                            }
                        }
                    }
                }

                toplamTutar = 0;

                BahceMasalar bahceMasa = new BahceMasalar();
                bahceMasa.Show();
                this.Hide();
            }
            else if (Anasayfa.pesinSatis == true)
            {
                if (txtBxToplamTutar.Text == "Toplam Tutar: 0.00" || txtBxToplamTutar.Text == "Toplam Tutar: 0")
                {
                    Anasayfa anaSayfa = new Anasayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
            }
            else if (AdisyonRapor.siparisSecildiMi == true)
            {
                string listbox = "";
                for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                {
                    string[] dizi = new string[lstViewSiparis.Items.Count];
                    dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                    listbox = listbox + dizi[i];
                }
                bg.Open();
                SqlCommand komut = new SqlCommand("update GunlukAdisyon set adisyonIcerik='" + listbox + "', tutar=" + toplamTutar + " where adisyonNo=" + AdisyonRapor.adisyonNo + "", bg);
                komut.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                komut = new SqlCommand("update ZRapor set tutar=" + toplamTutar + " where siparisId=" + AdisyonRapor.adisyonNo + "", bg);
                komut.ExecuteNonQuery();
                bg.Close();

                AdisyonRapor adisyonRapor = new AdisyonRapor();
                adisyonRapor.Show();
                this.Hide();
                AdisyonRapor.siparisSecildiMi = false;
            }
            fisNotu = "";
        }

        private void lstViewSiparis_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewSiparis.FullRowSelect = true;
            string items = "";
            if (lstViewSiparis.SelectedItems.Count == 1)
            {
                for (int i = 0; i <= 5; i++)
                {
                    try { items = lstViewSiparis.SelectedItems[0].SubItems[i].Text.ToString(); }
                    catch (Exception) { }
                    if (i == 1)
                        urunAdet = Convert.ToInt32(items);
                    if (i == 2)
                        urunIsim = items;
                    if (i == 3)
                        urunFiyat = Convert.ToInt32(items);
                    if (i == 4)
                        urunStokKategori = items;
                    if (i == 5)
                        urunKategori = items;
                }
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int elemanSayisi = 0;
            elemanSayisi = lstViewSiparis.Items.Count;
            int iptalIcecek = 0;
            int iptalYiyecek = 0;
            int iptalIcecekUcret = 0;
            int iptalYiyecekUcret = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from IcecekStok", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CocaCola = (int)dr["Cola"]; Fanta = (int)dr["Fanta"]; Sprite = (int)dr["Sprite"];
                MAIceTea = (int)dr["mangoAnanasIceTea"]; seftaliIceTea = (int)dr["seftaliIceTea"]; limonIceTea = (int)dr["limonIceTea"];
                karisikMS = (int)dr["karisikMeyveSuyu"]; seftaliMS = (int)dr["seftaliMeyveSuyu"]; kayisiMS = (int)dr["kayisiMeyveSuyu"];
                ICocaCola = (int)dr["ILCola"]; IICocaCola = (int)dr["IILCola"]; IIICocaCola = (int)dr["IIILCola"];
                IFanta = (int)dr["ILFanta"]; IIFanta = (int)dr["IILFanta"]; IIIFanta = (int)dr["IIILFanta"];
                Ayran = (int)dr["Ayran"]; Su = (int)dr["Su"]; Soda = (int)dr["Soda"]; Salgam = (int)dr["Salgam"];
            }
            bg.Close();
            if (lstViewSiparis.SelectedItems.Count == 1)
            {
                if (AdisyonRapor.siparisSecildiMi == true)
                {
                    string urunIsim2 = "";
                    bg.Open();
                    cmd = new SqlCommand("select * from FiyatListesi where kategori='Yiyecek'", bg);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        urunIsim2 = (string)dr["urunIsim"];
                        if (urunIsim == urunIsim2)
                        {
                            Yiyecek = Yiyecek - urunAdet;
                            iptalYiyecek = iptalYiyecek + urunAdet;
                        }
                    }
                    bg.Close();

                    string urunIsim3 = "";
                    bg.Open();
                    cmd = new SqlCommand("select * from FiyatListesi where kategori='İçecek'", bg);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        urunIsim3 = (string)dr["urunIsim"];
                        if (urunIsim == urunIsim3)
                        {
                            Icecek = Icecek - urunAdet;
                            iptalIcecek = iptalIcecek + urunAdet;
                        }
                    }
                    bg.Close();
                }


                if (urunStokKategori == "Cola")
                {
                    CocaCola = CocaCola + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "Fanta")
                {
                    Fanta = Fanta + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "Sprite")
                {
                    Sprite = Sprite + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "mangoAnanasIceTea")
                {
                    MAIceTea = MAIceTea + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "seftaliIceTea")
                {
                    seftaliIceTea = seftaliIceTea + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "limonIceTea")
                {
                    limonIceTea = limonIceTea + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "karisikMeyveSuyu")
                {
                    karisikMS = karisikMS + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "seftaliMeyveSuyu")
                {
                    seftaliMS = seftaliMS + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "kayisiMeyveSuyu")
                {
                    kayisiMS = kayisiMS + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "ILCola")
                {
                    ICocaCola = ICocaCola + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "IILCola")
                {
                    IICocaCola = IICocaCola + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "IIILCola")
                {
                    IIICocaCola = IIICocaCola + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "ILFanta")
                {
                    IFanta = IFanta + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "IILFanta")
                {
                    IIFanta = IIFanta + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "IIILFanta")
                {
                    IIIFanta = IIIFanta + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "Ayran")
                {
                    Ayran = Ayran + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "Su")
                {
                    Su = Su + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "Soda")
                {
                    Soda = Soda + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }
                if (urunStokKategori == "Salgam")
                {
                    Salgam = Salgam + urunAdet;
                    Icecek = Icecek - urunAdet;
                    iptalIcecek = iptalIcecek + urunAdet;
                }

                if (urunKategori == "Yiyecek")
                {
                    Yiyecek = Yiyecek - urunAdet;
                    iptalYiyecek = iptalYiyecek + urunAdet;
                }

                bg.Open();
                SqlCommand guncel = new SqlCommand("update IcecekStok set Cola=@Cola, Fanta=@Fanta, Sprite=@Sprite, mangoAnanasIceTea=@mangoAnanasIceTea, seftaliIceTea=@seftaliIceTea, limonIceTea=@limonIceTea, karisikMeyveSuyu=@karisikMeyveSuyu, seftaliMeyveSuyu=@seftaliMeyveSuyu, kayisiMeyveSuyu=@kayisiMeyveSuyu, ILCola=@ILCola, IILCola=@IILCola, IIILCola=@IIILCola, ILFanta=@ILFanta, IILFanta=@IILFanta, IIILFanta=@IIILFanta, Ayran=@Ayran, Su=@Su, Soda=@Soda, Salgam=@Salgam", bg);
                guncel.Parameters.AddWithValue("@Cola", CocaCola);
                guncel.Parameters.AddWithValue("@Fanta", Fanta);
                guncel.Parameters.AddWithValue("@Sprite", Sprite);
                guncel.Parameters.AddWithValue("@mangoAnanasIceTea", MAIceTea);
                guncel.Parameters.AddWithValue("@seftaliIceTea", seftaliIceTea);
                guncel.Parameters.AddWithValue("@limonIceTea", limonIceTea);
                guncel.Parameters.AddWithValue("@karisikMeyveSuyu", karisikMS);
                guncel.Parameters.AddWithValue("@seftaliMeyveSuyu", seftaliMS);
                guncel.Parameters.AddWithValue("@kayisiMeyveSuyu", kayisiMS);
                guncel.Parameters.AddWithValue("@ILCola", ICocaCola);
                guncel.Parameters.AddWithValue("@IILCola", IICocaCola);
                guncel.Parameters.AddWithValue("@IIILCola", IIICocaCola);
                guncel.Parameters.AddWithValue("@ILFanta", IFanta);
                guncel.Parameters.AddWithValue("@IILFanta", IIFanta);
                guncel.Parameters.AddWithValue("@IIILFanta", IIIFanta);
                guncel.Parameters.AddWithValue("@Ayran", Ayran);
                guncel.Parameters.AddWithValue("@Su", Su);
                guncel.Parameters.AddWithValue("@Soda", Soda);
                guncel.Parameters.AddWithValue("@Salgam", Salgam);
                guncel.ExecuteNonQuery();
                bg.Close();

                if (urunKategori == "Yiyecek")
                {
                    bg.Open();
                    SqlCommand oku = new SqlCommand("update GunSonu set iptalYiyecek=iptalYiyecek+" + iptalYiyecek + ", yiyecek=yiyecek-" + iptalYiyecek + "", bg);
                    oku.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    oku = new SqlCommand("update GunSonuFiyatlar set iptalYiyecek=iptalYiyecek+" + urunFiyat + ", yiyecek=yiyecek-" + urunFiyat + "", bg);
                    oku.ExecuteNonQuery();
                    bg.Close();
                }

                if (urunKategori == "İçecek")
                {
                    bg.Open();
                    SqlCommand oku = new SqlCommand("update GunSonu set iptalIcecek=iptalIcecek+" + iptalIcecek + ", icecek=icecek-" + iptalIcecek + "", bg);
                    oku.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    oku = new SqlCommand("update GunSonuFiyatlar set iptalIcecek=iptalIcecek+" + urunFiyat + ", icecek=icecek-" + urunFiyat + "", bg);
                    oku.ExecuteNonQuery();
                    bg.Close();
                }

                if (urunFiyat != 0)
                {
                    if (urunAdet != 0)
                    {
                        toplamTutar = toplamTutar - urunFiyat;
                        txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;
                        lstViewSiparis.Items.Remove(lstViewSiparis.SelectedItems[0]);
                    }
                }
            }
        }

        private void btnUrunIkram_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int elemanSayisi = 0;
            elemanSayisi = lstViewSiparis.Items.Count;
            if (urunFiyat != 0)
            {
                if (urunAdet != 0)
                {
                    toplamTutar = toplamTutar - urunFiyat;
                    txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;
                    lstViewSiparis.SelectedItems[0].SubItems[3].Text = "İkram";

                    bg.Open();
                    SqlCommand cmd = new SqlCommand("update GunSonu set ikram=ikram+" + urunAdet + "", bg);
                    cmd.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    cmd = new SqlCommand("update GunSonuFiyatlar set ikram=ikram+" + urunFiyat + "", bg);
                    cmd.ExecuteNonQuery();
                    bg.Close();
                    if (urunKategori == "Yiyecek")
                    {
                        bg.Open();
                        cmd = new SqlCommand("update GunSonuFiyatlar set yiyecek=yiyecek-" + urunFiyat + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update GunSonu set yiyecek=yiyecek-" + urunAdet + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }
                    if (urunKategori == "İçecek")
                    {
                        bg.Open();
                        cmd = new SqlCommand("update GunSonuFiyatlar set icecek=icecek-" + urunFiyat + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update GunSonu set icecek=icecek-" + urunAdet + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }
                }
            }
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            int yazdırılan = 0;
            for (int i = 0; i < lstViewSiparis.Items.Count; i++)
            {
                if (lstViewSiparis.Items[i].SubItems[0].Text == "0")
                    yazdırılan++;
            }
            if (yazdırılan > 0)
                printPreviewDialogMutfak.ShowDialog();
            for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                lstViewSiparis.Items[i].SubItems[0].Text = "1";
        }
        private void printDocumentMutfak_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            int adisyonAralik = 0;
            int aralik = 30;
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                // Pen kalem = new Pen(Color.Black);
                e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);

                font = new Font("Arial", 15, FontStyle.Bold);
                Font cizgi = new Font("Arial", 12);
                e.Graphics.DrawString("Bölüm", font, firca, 100, 70);
                e.Graphics.DrawString("-------------", cizgi, firca, 96, 82);
                e.Graphics.DrawString("Masa", font, firca, 200, 70);
                e.Graphics.DrawString("-----------", cizgi, firca, 197, 82);
                e.Graphics.DrawString("Adisyon No", font, firca, 285, 70);
                e.Graphics.DrawString("---------------------", cizgi, firca, 282, 82);

                font = new Font("Arial", 16);
                if (Anasayfa.pesinSatis == true)
                {
                    e.Graphics.DrawString("Peşin Satış", font, firca, 73, 100);
                    e.Graphics.DrawString("", font, firca, 215, 100);
                }
                else if (BahceMasalar.bahceMasa == true)
                {
                    e.Graphics.DrawString("Bahçe", font, firca, 100, 100);
                    e.Graphics.DrawString(BahceMasalar.bahceMasaNo.ToString(), font, firca, 215, 100);
                }
                else if (SalonMasalar.salonMasa == true)
                {
                    e.Graphics.DrawString("Salon", font, firca, 100, 100);
                    e.Graphics.DrawString(SalonMasalar.salonMasaNo.ToString(), font, firca, 215, 100);
                }

                int adisyonNo = 0;
                bg.Open();
                SqlCommand komut = new SqlCommand("select Count(adisyonNo) as AdisyonNo from GunlukAdisyon", bg);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                { adisyonNo = (int)dr["AdisyonNo"]; }
                bg.Close();
                e.Graphics.DrawString((adisyonNo + 1).ToString(), font, firca, 325, 100);

                for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                {
                    font = new Font("Arial", 16);
                    if (lstViewSiparis.Items[i].SubItems[0].Text == "0")
                    {
                        string[] dizi = new string[lstViewSiparis.Items.Count];
                        dizi[i] = lstViewSiparis.Items[i].SubItems[1].Text + " - " + lstViewSiparis.Items[i].SubItems[2].Text + " - " + lstViewSiparis.Items[i].SubItems[3].Text;
                        if (i == 0)
                            e.Graphics.DrawString(dizi[i], font, firca, 100, 148);
                        else
                            e.Graphics.DrawString(dizi[i], font, firca, 100, (148 + (aralik * i)));
                        adisyonAralik = 148 + (aralik * i);
                    }

                }
                font = new Font("Arial", 16, FontStyle.Bold);
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, (adisyonAralik + aralik + 5));
                e.Graphics.DrawString(("Fiş Notu: " + fisNotu), font, firca, 100, (adisyonAralik + 67));

            }
            catch (Exception) { }
        }

        private void btnAdisyon_Click(object sender, EventArgs e)
        {
            if (Anasayfa.pesinSatis == true)
                printPreviewDialogAdisyon.ShowDialog();
        }
        private void printDocumentAdisyon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int adisyonNo = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand komut = new SqlCommand("select Count(*) as AdisyonNo from GunlukAdisyon", bg);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            { adisyonNo = (int)dr["AdisyonNo"]; }
            int aralik = 30;
            int adisyonAralik = 0;
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
                e.Graphics.DrawString("Üniversite Pizza Paket Fişi", baslik, firca, 100, 100);
                e.Graphics.DrawString(("Adisyon No: " + (adisyonNo + 1).ToString()), font, firca, 100, 175);
                e.Graphics.DrawString(("Telefon No: " + paketServisTelefon), font, firca, 100, 207);
                e.Graphics.DrawString(("Adres: " + Adres.adres), font, firca, 100, 239);
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, 285);
                font = new Font("Arial", 16, FontStyle.Bold);
                e.Graphics.DrawString(("Fiş Notu: " + fisNotu), font, firca, 100, 310);
                for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                {
                    font = new Font("Arial", 16);

                    string[] dizi = new string[lstViewSiparis.Items.Count];
                    dizi[i] = lstViewSiparis.Items[i].SubItems[1].Text + " - " + lstViewSiparis.Items[i].SubItems[2].Text + " -" +
                        " " + lstViewSiparis.Items[i].SubItems[3].Text;
                    if (i == 0)
                        e.Graphics.DrawString(dizi[i], font2, firca, 100, 370);
                    else
                        e.Graphics.DrawString(dizi[i], font2, firca, 100, (370 + (aralik * i)));
                    adisyonAralik = 370 + (aralik * i);
                }
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, (adisyonAralik + aralik));
                e.Graphics.DrawString(("Toplam Ücret: " + toplamTutar), font3, firca, 200, (adisyonAralik + aralik + 20));

            }
            catch (Exception) { }
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            if (lstViewSiparis.Items.Count != 0)
            {
                if (SalonMasalar.salonMasa == true)
                {
                    VeriTabanı.MasaNakit(SalonMasalar.salonMasaNo, "Salon");

                    bg.Open();
                    SqlCommand guncel = new SqlCommand("update IcecekStok set Cola=@CocaCola, Fanta=@Fanta, Sprite=@Sprite, mangoAnanasIceTea=@MAIceTea, seftaliIceTea=@seftaliIceTea, limonIceTea=@limonIceTea, karisikMeyveSuyu=@karisikMS, seftaliMeyveSuyu=@seftaliMS, kayisiMeyveSuyu=@kayisiMS, ILCola=@ILCocaCola, IILCola=@IILCocaCola, IIILCola=@IIILCocaCola, ILFanta=@ILFanta, IILFanta=@IILFanta, IIILFanta=@IIILFanta, Ayran=@Ayran, Su=@Su, Soda=@Soda, Salgam=@Salgam", bg);
                    guncel.Parameters.AddWithValue("@CocaCola", CocaCola);
                    guncel.Parameters.AddWithValue("@Fanta", Fanta);
                    guncel.Parameters.AddWithValue("@Sprite", Sprite);
                    guncel.Parameters.AddWithValue("@MAIceTea", MAIceTea);
                    guncel.Parameters.AddWithValue("@seftaliIceTea", seftaliIceTea);
                    guncel.Parameters.AddWithValue("@limonIceTea", limonIceTea);
                    guncel.Parameters.AddWithValue("@karisikMS", karisikMS);
                    guncel.Parameters.AddWithValue("@seftaliMS", seftaliMS);
                    guncel.Parameters.AddWithValue("@kayisiMS", kayisiMS);
                    guncel.Parameters.AddWithValue("@ILCocaCola", ICocaCola);
                    guncel.Parameters.AddWithValue("@IILCocaCola", IICocaCola);
                    guncel.Parameters.AddWithValue("@IIILCocaCola", IIICocaCola);
                    guncel.Parameters.AddWithValue("@ILFanta", IFanta);
                    guncel.Parameters.AddWithValue("@IILFanta", IIFanta);
                    guncel.Parameters.AddWithValue("@IIILFanta", IIIFanta);
                    guncel.Parameters.AddWithValue("@Ayran", Ayran);
                    guncel.Parameters.AddWithValue("@Su", Su);
                    guncel.Parameters.AddWithValue("@Soda", Soda);
                    guncel.Parameters.AddWithValue("@Salgam", Salgam);
                    guncel.ExecuteNonQuery();
                    bg.Close();

                    bool masaVarmi = false;
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select * from ListboxKontrol where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    { masaVarmi = (bool)dr["durum"]; }
                    bg.Close();

                    if (masaVarmi == true)
                    {
                        string listbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            listbox = listbox + dizi[i];
                        }
                        string KapanisSaat = DateTime.Now.ToLongTimeString();
                        bg.Open();
                        cmd = new SqlCommand("update GunlukAdisyon set adisyonKapanisSaat=@adisyonKapanisSaat, adisyonIcerik=@adisyonIcerik, odemeDurumu='Ödendi', tutar=@tutar where islem='Salon/" + SalonMasalar.salonMasaNo + "' and odemeDurumu=''", bg);
                        cmd.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        cmd.Parameters.AddWithValue("@adisyonIcerik", listbox);
                        cmd.Parameters.AddWithValue("@tutar", toplamTutar);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }
                    else
                    {
                        string listbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            listbox = listbox + dizi[i];
                        }
                        string KapanisSaat = DateTime.Now.ToLongTimeString();
                        bg.Open();
                        SqlCommand komut2 = new SqlCommand("insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)", bg);
                        komut2.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                        komut2.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        komut2.Parameters.AddWithValue("@adisyonIcerik", listbox);
                        komut2.Parameters.AddWithValue("@odemeDurumu", "Ödendi");
                        komut2.Parameters.AddWithValue("@islem", ("Salon/" + SalonMasalar.salonMasaNo.ToString()));
                        komut2.Parameters.AddWithValue("@tutar", toplamTutar);
                        komut2.ExecuteNonQuery();
                        bg.Close();
                    }

                    bg.Open();
                    cmd = new SqlCommand("update ListboxKontrol set listbox=@listbox, tutar=@fiyat, durum=@durum, fisNotu=@fisNotu where masaYeri=@masaYeri and masaNo=@masaNo", bg);
                    cmd.Parameters.AddWithValue("@listbox", "");
                    cmd.Parameters.AddWithValue("@fiyat", 0);
                    cmd.Parameters.AddWithValue("@durum", 0);
                    cmd.Parameters.AddWithValue("@masaYeri", "Salon");
                    cmd.Parameters.AddWithValue("@masaNo", SalonMasalar.salonMasaNo);
                    cmd.Parameters.AddWithValue("@fisNotu", "");
                    cmd.ExecuteNonQuery();
                    bg.Close();


                    bg.Open();
                    cmd = new SqlCommand("update Masalar set durum=@durum, fiyat=@fiyat, mutfak=@mutfak where masaYeri=@masaYeri and masaNo=@masaNo", bg);
                    cmd.Parameters.AddWithValue("@masaNo", SalonMasalar.salonMasaNo);
                    cmd.Parameters.AddWithValue("@masaYeri", "Salon");
                    cmd.Parameters.AddWithValue("@durum", 0);
                    cmd.Parameters.AddWithValue("@fiyat", 0);
                    cmd.Parameters.AddWithValue("@mutfak", 0);
                    cmd.ExecuteNonQuery();
                    bg.Close();

                    int masaAdet = 0;
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select count(*) as masaAdet from Masalar where masaYeri='Salon'", bg);
                    dr = komut.ExecuteReader();
                    while (dr.Read())
                    { masaAdet = (int)dr["masaAdet"]; }
                    bg.Close();

                    for (int i = 1; i <= masaAdet; i++)
                    {
                        if (SalonMasalar.salonMasaNo == i)
                        {
                            string masaNo = "Salon" + i;
                            bg.Open();
                            cmd = new SqlCommand("delete from " + masaNo + "", bg);
                            cmd.ExecuteNonQuery();
                            bg.Close();
                        }
                    }

                    SalonMasalar salonMasalar = new SalonMasalar();
                    salonMasalar.Show();
                    this.Hide();
                }
                if (BahceMasalar.bahceMasa == true)
                {
                    VeriTabanı.MasaNakit(BahceMasalar.bahceMasaNo, "Bahçe");

                    bg.Open();
                    SqlCommand guncel = new SqlCommand("update IcecekStok set Cola=@CocaCola, Fanta=@Fanta, Sprite=@Sprite, mangoAnanasIceTea=@MAIceTea, seftaliIceTea=@seftaliIceTea, limonIceTea=@limonIceTea, karisikMeyveSuyu=@karisikMS, seftaliMeyveSuyu=@seftaliMS, kayisiMeyveSuyu=@kayisiMS, ILCola=@ILCocaCola, IILCola=@IILCocaCola, IIILCola=@IIILCocaCola, ILFanta=@ILFanta, IILFanta=@IILFanta, IIILFanta=@IIILFanta, Ayran=@Ayran, Su=@Su, Soda=@Soda, Salgam=@Salgam", bg);
                    guncel.Parameters.AddWithValue("@CocaCola", CocaCola);
                    guncel.Parameters.AddWithValue("@Fanta", Fanta);
                    guncel.Parameters.AddWithValue("@Sprite", Sprite);
                    guncel.Parameters.AddWithValue("@MAIceTea", MAIceTea);
                    guncel.Parameters.AddWithValue("@seftaliIceTea", seftaliIceTea);
                    guncel.Parameters.AddWithValue("@limonIceTea", limonIceTea);
                    guncel.Parameters.AddWithValue("@karisikMS", karisikMS);
                    guncel.Parameters.AddWithValue("@seftaliMS", seftaliMS);
                    guncel.Parameters.AddWithValue("@kayisiMS", kayisiMS);
                    guncel.Parameters.AddWithValue("@ILCocaCola", ICocaCola);
                    guncel.Parameters.AddWithValue("@IILCocaCola", IICocaCola);
                    guncel.Parameters.AddWithValue("@IIILCocaCola", IIICocaCola);
                    guncel.Parameters.AddWithValue("@ILFanta", IFanta);
                    guncel.Parameters.AddWithValue("@IILFanta", IIFanta);
                    guncel.Parameters.AddWithValue("@IIILFanta", IIIFanta);
                    guncel.Parameters.AddWithValue("@Ayran", Ayran);
                    guncel.Parameters.AddWithValue("@Su", Su);
                    guncel.Parameters.AddWithValue("@Soda", Soda);
                    guncel.Parameters.AddWithValue("@Salgam", Salgam);
                    guncel.ExecuteNonQuery();
                    bg.Close();

                    bool masaVarmi = false;
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select * from ListboxKontrol where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    { masaVarmi = (bool)dr["durum"]; }
                    bg.Close();

                    if (masaVarmi == true)
                    {
                        string listbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            listbox = listbox + dizi[i];
                        }
                        string KapanisSaat = DateTime.Now.ToLongTimeString();
                        bg.Open();
                        cmd = new SqlCommand("update GunlukAdisyon set adisyonKapanisSaat=@adisyonKapanisSaat, adisyonIcerik=@adisyonIcerik, odemeDurumu='Ödendi', tutar=@tutar where islem='Bahçe/" + BahceMasalar.bahceMasaNo + "' and odemeDurumu=''", bg);
                        cmd.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        cmd.Parameters.AddWithValue("@adisyonIcerik", listbox);
                        cmd.Parameters.AddWithValue("@tutar", toplamTutar);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }
                    else
                    {
                        string listbox = "";
                        for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                        {
                            string[] dizi = new string[lstViewSiparis.Items.Count];
                            dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                            listbox = listbox + dizi[i];
                        }
                        string KapanisSaat = DateTime.Now.ToLongTimeString();
                        bg.Open();
                        SqlCommand komut2 = new SqlCommand("insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)", bg);
                        komut2.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                        komut2.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        komut2.Parameters.AddWithValue("@adisyonIcerik", listbox);
                        komut2.Parameters.AddWithValue("@odemeDurumu", "Ödendi");
                        komut2.Parameters.AddWithValue("@islem", ("Bahçe/" + BahceMasalar.bahceMasaNo.ToString()));
                        komut2.Parameters.AddWithValue("@tutar", toplamTutar);
                        komut2.ExecuteNonQuery();
                        bg.Close();
                    }

                    bg.Open();
                    cmd = new SqlCommand("update ListboxKontrol set listbox=@listbox, tutar=@fiyat, durum=@durum, fisNotu=@fisNotu where masaYeri=@masaYeri and masaNo=@masaNo", bg);
                    cmd.Parameters.AddWithValue("@listbox", "");
                    cmd.Parameters.AddWithValue("@fiyat", 0);
                    cmd.Parameters.AddWithValue("@durum", 0);
                    cmd.Parameters.AddWithValue("@masaYeri", "Bahçe");
                    cmd.Parameters.AddWithValue("@masaNo", BahceMasalar.bahceMasaNo);
                    cmd.Parameters.AddWithValue("@fisNotu", "");
                    cmd.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    cmd = new SqlCommand("update Masalar set durum=@durum, fiyat=@fiyat, mutfak=@mutfak where masaYeri=@masaYeri and masaNo=@masaNo", bg);
                    cmd.Parameters.AddWithValue("@masaNo", BahceMasalar.bahceMasaNo);
                    cmd.Parameters.AddWithValue("@masaYeri", "Bahçe");
                    cmd.Parameters.AddWithValue("@durum", 0);
                    cmd.Parameters.AddWithValue("@fiyat", 0);
                    cmd.Parameters.AddWithValue("@mutfak", 0);
                    cmd.ExecuteNonQuery();
                    bg.Close();

                    int masaAdet = 0;
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select count(*) as masaAdet from Masalar where masaYeri='Bahçe'", bg);
                    dr = komut.ExecuteReader();
                    while (dr.Read())
                    { masaAdet = (int)dr["masaAdet"]; }
                    bg.Close();

                    for (int i = 1; i <= masaAdet; i++)
                    {
                        if (BahceMasalar.bahceMasaNo == i)
                        {
                            string masaNo = "Bahce" + i;
                            bg.Open();
                            cmd = new SqlCommand("delete from " + masaNo + "", bg);
                            cmd.ExecuteNonQuery();
                            bg.Close();
                        }
                    }

                    BahceMasalar bahceMasalar = new BahceMasalar();
                    bahceMasalar.Show();
                    this.Hide();
                }
                if (Anasayfa.pesinSatis == true)
                {
                    VeriTabanı.pesinSatisNakit();

                    string kapanisSaat = DateTime.Now.ToLongTimeString();
                    string listbox = "";
                    for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                    {
                        string[] dizi = new string[lstViewSiparis.Items.Count];
                        dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                        listbox = listbox + dizi[i];
                    }
                    bg.Open();
                    SqlCommand komut2 = new SqlCommand("insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)", bg);
                    komut2.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                    komut2.Parameters.AddWithValue("@adisyonKapanisSaat", kapanisSaat);
                    komut2.Parameters.AddWithValue("@adisyonIcerik", listbox);
                    komut2.Parameters.AddWithValue("@odemeDurumu", "Ödendi");
                    komut2.Parameters.AddWithValue("@islem", "Peşin Satış");
                    komut2.Parameters.AddWithValue("@tutar", toplamTutar);
                    komut2.ExecuteNonQuery();
                    bg.Close();

                    int musteriKayitliMi = 1;
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) as varMi from KayitliMusteriler where telefon='" + paketServisTelefon + "'", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    { musteriKayitliMi = (int)dr["varMi"]; }
                    bg.Close();

                    if (paketServisTelefon != "")
                    {
                        if (paketServisAdres != "")
                        {
                            bg.Open();
                            komut2 = new SqlCommand("insert into PaketServis(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, adres, telefon, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @adres, @telefon, @tutar)", bg);
                            komut2.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                            komut2.Parameters.AddWithValue("@adisyonKapanisSaat", kapanisSaat);
                            komut2.Parameters.AddWithValue("@adisyonIcerik", listbox);
                            komut2.Parameters.AddWithValue("@adres", paketServisAdres);
                            komut2.Parameters.AddWithValue("@telefon", paketServisTelefon);
                            komut2.Parameters.AddWithValue("@tutar", toplamTutar);
                            komut2.ExecuteNonQuery();
                            bg.Close();
                            if (musteriKayitliMi == 0)
                            {
                                bg.Open();
                                komut2 = new SqlCommand("insert into KayitliMusteriler(telefon, adres) values (@telefon, @adres)", bg);
                                komut2.Parameters.AddWithValue("@adres", paketServisAdres);
                                komut2.Parameters.AddWithValue("@telefon", paketServisTelefon);
                                komut2.ExecuteNonQuery();
                                bg.Close();
                            }
                        }
                    }
                    Anasayfa anaSayfa = new Anasayfa();
                    anaSayfa.Show();
                    this.Hide();
                }

                paketServisTelefon = "";
                paketServisAdres = "";
                toplamTutar = 0;
                fisNotu = "";
            }
        }

        private void btnFisİptal_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from IcecekStok", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CocaCola = (int)dr["Cola"]; Fanta = (int)dr["Fanta"]; Sprite = (int)dr["Sprite"];
                MAIceTea = (int)dr["mangoAnanasIceTea"]; seftaliIceTea = (int)dr["seftaliIceTea"]; limonIceTea = (int)dr["limonIceTea"];
                karisikMS = (int)dr["karisikMeyveSuyu"]; seftaliMS = (int)dr["seftaliMeyveSuyu"]; kayisiMS = (int)dr["kayisiMeyveSuyu"];
                Salgam = (int)dr["Salgam"]; ICocaCola = (int)dr["ILCola"]; IICocaCola = (int)dr["IILCola"];
                IIICocaCola = (int)dr["IIILCola"]; IFanta = (int)dr["ILFanta"]; IIFanta = (int)dr["IILFanta"]; IIIFanta = (int)dr["IIILFanta"];
                Ayran = (int)dr["Ayran"]; Su = (int)dr["Su"]; Soda = (int)dr["Soda"];
            }
            bg.Close();

            DialogResult dialogResult = MessageBox.Show("Fişi İptal Etmek İstiyormusnuz?", "Uyarı!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (SalonMasalar.salonMasa == true)
                {
                    VeriTabanı.MasaFisİptal(SalonMasalar.salonMasaNo, "Salon");
                    string KapanisSaat = DateTime.Now.ToLongTimeString();
                    bool masaVarmi = false;

                    bg.Open();
                    cmd = new SqlCommand("select * from ListboxKontrol where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        masaVarmi = (bool)dr["durum"];
                    }
                    bg.Close();

                    if (masaVarmi == true)
                    {
                        bg.Open();
                        cmd = new SqlCommand("update GunlukAdisyon set adisyonKapanisSaat=@adisyonKapanisSaat, odemeDurumu='Fiş İptal' where islem='Salon/" + SalonMasalar.salonMasaNo + "'", bg);
                        cmd.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update ListboxKontrol set listbox='', tutar=0, durum='false', fisNotu='' where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update Masalar set fiyat=0, durum='false', mutfak=0 where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }

                    int masaAdet = 0;
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select count(*) as masaAdet from Masalar where masaYeri='Salon'", bg);
                    dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        masaAdet = (int)dr["masaAdet"];
                    }
                    bg.Close();

                    for (int i = 1; i <= masaAdet; i++)
                    {
                        if (SalonMasalar.salonMasaNo == i)
                        {
                            string masaNo = "Salon" + i;
                            bg.Open();
                            cmd = new SqlCommand("delete from " + masaNo + "", bg);
                            cmd.ExecuteNonQuery();
                            bg.Close();
                        }
                    }
                }
                if (BahceMasalar.bahceMasa == true)
                {
                    VeriTabanı.MasaFisİptal(BahceMasalar.bahceMasaNo, "Bahçe");
                    string KapanisSaat = DateTime.Now.ToLongTimeString();
                    bool masaVarmi = false;

                    bg.Open();
                    cmd = new SqlCommand("select * from ListboxKontrol where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        masaVarmi = (bool)dr["durum"];
                    }
                    bg.Close();

                    if (masaVarmi == true)
                    {
                        bg.Open();
                        cmd = new SqlCommand("update GunlukAdisyon set adisyonKapanisSaat=@adisyonKapanisSaat, odemeDurumu='Fiş İptal' where islem='Bahçe/" + BahceMasalar.bahceMasaNo + "'", bg);
                        cmd.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update ListboxKontrol set listbox='', tutar=0, durum='false', fisNotu='' where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update Masalar set fiyat=0, durum='false', mutfak=0 where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }

                    int masaAdet = 0;
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select count(*) as masaAdet from Masalar where masaYeri='Bahçe'", bg);
                    dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        masaAdet = (int)dr["masaAdet"];
                    }
                    bg.Close();

                    for (int i = 1; i <= masaAdet; i++)
                    {
                        if (BahceMasalar.bahceMasaNo == i)
                        {
                            string masaNo = "Bahce" + i;
                            bg.Open();
                            cmd = new SqlCommand("delete from " + masaNo + "", bg);
                            cmd.ExecuteNonQuery();
                            bg.Close();
                        }
                    }
                }
                if (Anasayfa.pesinSatis == true)
                {
                    VeriTabanı.pesinSatisFisİptal();
                    string Saat = DateTime.Now.ToLongTimeString();
                    string listbox = "";
                    for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                    {
                        string[] dizi = new string[lstViewSiparis.Items.Count];
                        dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                        listbox = listbox + dizi[i];
                    }
                    try
                    {
                        bg.Open();
                        SqlCommand komut = new SqlCommand("insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)", bg);
                        komut.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                        komut.Parameters.AddWithValue("@adisyonKapanisSaat", Saat);
                        komut.Parameters.AddWithValue("@adisyonIcerik", listbox);
                        komut.Parameters.AddWithValue("@odemeDurumu", "Fiş İptal");
                        komut.Parameters.AddWithValue("@islem", "Peşin Satış");
                        komut.Parameters.AddWithValue("@tutar", toplamTutar);
                        komut.ExecuteNonQuery();
                        bg.Close();
                    }
                    catch (Exception) { }
                }
                if (AdisyonRapor.siparisSecildiMi == true)
                {
                    string listbox = "";
                    for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                    {
                        string[] dizi = new string[lstViewSiparis.Items.Count];
                        dizi[i] = lstViewSiparis.Items[i].SubItems[0].Text + "/" + lstViewSiparis.Items[i].SubItems[1].Text + "/" + lstViewSiparis.Items[i].SubItems[2].Text + "/" + lstViewSiparis.Items[i].SubItems[3].Text + ",";
                        listbox = listbox + dizi[i];
                    }
                    bg.Open();
                    SqlCommand komut = new SqlCommand("update GunlukAdisyon set odemeDurumu='Fiş İptal', adisyonIcerik='" + listbox + "', tutar=" + toplamTutar + " where adisyonNo=" + AdisyonRapor.adisyonNo + "", bg);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    komut = new SqlCommand("update ZRapor set odemeDurumu='Fiş İptal', tutar=" + toplamTutar + " where siparisId=" + AdisyonRapor.adisyonNo + "", bg);
                    komut.ExecuteNonQuery();
                    bg.Close();
                }

                string[] dizi2 = new string[lstViewSiparis.Items.Count];
                string[] dizi3 = new string[lstViewSiparis.Items.Count];
                string[] dizi4 = new string[lstViewSiparis.Items.Count];
                string[] dizi5 = new string[lstViewSiparis.Items.Count];
                try
                {
                    for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                    {
                        dizi2[i] = lstViewSiparis.Items[i].SubItems[4].Text;
                        dizi3[i] = lstViewSiparis.Items[i].SubItems[1].Text;
                        dizi4[i] = lstViewSiparis.Items[i].SubItems[3].Text;
                        dizi5[i] = lstViewSiparis.Items[i].SubItems[5].Text;

                    }
                }
                catch (Exception) { }

                int iptalIcecek = 0; int iptalYiyecek = 0;
                int iptalIcecekUcret = 0; int iptalYiyecekUcret = 0;


                if (AdisyonRapor.siparisSecildiMi == true)
                {
                    string[] dizi6 = new string[lstViewSiparis.Items.Count];
                    string[] dizi7 = new string[lstViewSiparis.Items.Count];
                    string[] dizi8 = new string[lstViewSiparis.Items.Count];
                    for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                    {
                        dizi7[i] = lstViewSiparis.Items[i].SubItems[1].Text;
                        dizi6[i] = lstViewSiparis.Items[i].SubItems[2].Text;
                        dizi8[i] = lstViewSiparis.Items[i].SubItems[3].Text;
                    }

                    for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                    {
                        string urunIsim = "";
                        bg.Open();
                        cmd = new SqlCommand("select * from FiyatListesi where kategori='Yiyecek'", bg);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            urunIsim = (string)dr["urunIsim"];

                            if (dizi6[i] == urunIsim)
                            {
                                int urunAdet2 = Convert.ToInt32(dizi7[i]);
                                Yiyecek = Yiyecek - urunAdet2;
                                iptalYiyecek = iptalYiyecek + urunAdet2;
                                if (dizi4[i] != "İkram")
                                {
                                    int iptalUcret3 = Convert.ToInt32(dizi8[i]);
                                    iptalYiyecekUcret = iptalYiyecekUcret + iptalUcret3;
                                }
                            }
                        }
                        bg.Close();


                        string urunIsim2 = "";
                        bg.Open();
                        cmd = new SqlCommand("select * from FiyatListesi where kategori='İçecek'", bg);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            urunIsim2 = (string)dr["urunIsim"];
                            if (dizi6[i] == urunIsim2)
                            {
                                int urunAdet2 = Convert.ToInt32(dizi7[i]);
                                Icecek = Icecek - urunAdet2;
                                iptalIcecek = iptalIcecek + urunAdet2;
                                if (dizi8[i] != "İkram")
                                {
                                    int iptalUcret3 = Convert.ToInt32(dizi8[i]);
                                    iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                                }
                            }
                        }
                        bg.Close();
                    }
                }
                else
                {
                    for (int i = 0; i < dizi2.Count(); i++)
                    {
                        if (dizi2[i] == "Cola")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            CocaCola = CocaCola + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "Fanta")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            Fanta = Fanta + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalYiyecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "Sprite")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            Sprite = Sprite + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "mangoAnanasIceTea")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            MAIceTea = MAIceTea + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "seftaliIceTea")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            seftaliIceTea = seftaliIceTea + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "limonIceTea")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            limonIceTea = limonIceTea + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "karisikMeyveSuyu")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            karisikMS = karisikMS + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "seftaliMeyveSuyu")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            seftaliMS = seftaliMS + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "kayisiMeyveSuyu")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            kayisiMS = kayisiMS + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "ILCola")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            ICocaCola = ICocaCola + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "IILCola")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            IICocaCola = IICocaCola + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "IIILCola")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            IIICocaCola = IIICocaCola + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "ILFanta")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            IFanta = IFanta + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "IILFanta")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            IIFanta = IIFanta + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "IIILFanta")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            IIIFanta = IIIFanta + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "Ayran")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            Ayran = Ayran + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "Su")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            Su = Su + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "Soda")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            Soda = Soda + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }
                        if (dizi2[i] == "Şalgam")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            Salgam = Salgam + urunAdet2;
                            Icecek = Icecek - urunAdet2;
                            iptalIcecek = iptalIcecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                            }
                        }

                        if (dizi5[i] == "Yiyecek")
                        {
                            int urunAdet2 = Convert.ToInt32(dizi3[i]);
                            Yiyecek = Yiyecek - urunAdet2;
                            iptalYiyecek = iptalYiyecek + urunAdet2;
                            if (dizi4[i] != "İkram")
                            {
                                int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                                iptalYiyecekUcret = iptalYiyecekUcret + iptalUcret3;
                            }
                        }
                    }
                }


                bg.Open();
                SqlCommand guncel = new SqlCommand("update IcecekStok set Cola=@Cola, Fanta=@Fanta, Sprite=@Sprite, mangoAnanasIceTea=@mangoAnanasIceTea, seftaliIceTea=@seftaliIceTea, limonIceTea=@limonIceTea, karisikMeyveSuyu=@karisikMeyveSuyu, seftaliMeyveSuyu=@seftaliMeyveSuyu, kayisiMeyveSuyu=@kayisiMeyveSuyu, ILCola=@ILCola, IILCola=@IILCola, IIILCola=@IIILCola, ILFanta=@ILFanta, IILFanta=@IILFanta, IIILFanta=@IIILFanta, Ayran=@Ayran, Su=@Su, Soda=@Soda, Salgam=@Salgam", bg);
                guncel.Parameters.AddWithValue("@Cola", CocaCola);
                guncel.Parameters.AddWithValue("@Fanta", Fanta);
                guncel.Parameters.AddWithValue("@Sprite", Sprite);
                guncel.Parameters.AddWithValue("@mangoAnanasIceTea", MAIceTea);
                guncel.Parameters.AddWithValue("@seftaliIceTea", seftaliIceTea);
                guncel.Parameters.AddWithValue("@limonIceTea", limonIceTea);
                guncel.Parameters.AddWithValue("@karisikMeyveSuyu", karisikMS);
                guncel.Parameters.AddWithValue("@seftaliMeyveSuyu", seftaliMS);
                guncel.Parameters.AddWithValue("@kayisiMeyveSuyu", kayisiMS);
                guncel.Parameters.AddWithValue("@ILCola", ICocaCola);
                guncel.Parameters.AddWithValue("@IILCola", IICocaCola);
                guncel.Parameters.AddWithValue("@IIILCola", IIICocaCola);
                guncel.Parameters.AddWithValue("@ILFanta", IFanta);
                guncel.Parameters.AddWithValue("@IILFanta", IIFanta);
                guncel.Parameters.AddWithValue("@IIILFanta", IIIFanta);
                guncel.Parameters.AddWithValue("@Ayran", Ayran);
                guncel.Parameters.AddWithValue("@Su", Su);
                guncel.Parameters.AddWithValue("@Soda", Soda);
                guncel.Parameters.AddWithValue("@Salgam", Salgam);
                guncel.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                cmd = new SqlCommand("update GunSonu set iptalYiyecek=iptalYiyecek+@iptalYiyecek, iptalIcecek=iptalIcecek+@iptalIcecek, yiyecek=yiyecek-@iptalYiyecek, icecek=icecek-@iptalIcecek", bg);
                cmd.Parameters.AddWithValue("@iptalYiyecek", iptalYiyecek);
                cmd.Parameters.AddWithValue("@iptalIcecek", iptalIcecek);
                cmd.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                cmd = new SqlCommand("update GunSonuFiyatlar set iptalYiyecek=iptalYiyecek+@iptalYiyecek, iptalIcecek=iptalIcecek+@iptalIcecek, yiyecek=yiyecek-@iptalYiyecek, icecek=icecek-@iptalIcecek", bg);
                cmd.Parameters.AddWithValue("@iptalYiyecek", iptalYiyecekUcret);
                cmd.Parameters.AddWithValue("@iptalIcecek", iptalIcecekUcret);
                cmd.ExecuteNonQuery();
                bg.Close();

                toplamTutar = 0;

                if (SalonMasalar.salonMasa == true)
                {
                    SalonMasalar salonMasalar = new SalonMasalar();
                    salonMasalar.Show();
                    this.Hide();
                }
                if (BahceMasalar.bahceMasa == true)
                {
                    BahceMasalar bahceMasa = new BahceMasalar();
                    bahceMasa.Show();
                    this.Hide();
                }
                if (Anasayfa.pesinSatis == true)
                {
                    Anasayfa anaSayfa = new Anasayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                if (AdisyonRapor.siparisSecildiMi == true)
                {
                    AdisyonRapor adisyonRapor = new AdisyonRapor();
                    adisyonRapor.Show();
                    this.Hide();
                    AdisyonRapor.siparisSecildiMi = false;
                }

            }
        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            Telefon telefon = new Telefon();
            telefon.Show();
        }
        private void btnAdres_Click(object sender, EventArgs e)
        {
            Adres adres = new Adres();
            adres.Show();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Numarator.Numara("1", txtUrunAdet);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Numarator.Numara("2", txtUrunAdet);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Numarator.Numara("3", txtUrunAdet);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Numarator.Numara("4", txtUrunAdet);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Numarator.Numara("5", txtUrunAdet);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            Numarator.Numara("6", txtUrunAdet);

        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Numarator.Numara("7", txtUrunAdet);

        }
        private void btn8_Click(object sender, EventArgs e)
        {
            Numarator.Numara("8", txtUrunAdet);

        }
        private void btn9_Click(object sender, EventArgs e)
        {
            Numarator.Numara("9", txtUrunAdet);

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            Numarator.Numara("0", txtUrunAdet);
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Numarator.Sil(txtUrunAdet);
        }
        private void btnFisNotu_Click(object sender, EventArgs e)
        {
            FisNotu fisNotu = new FisNotu();
            fisNotu.Show();
        }
        private void btnIndirimKodu_Click(object sender, EventArgs e)
        {
            Timer1.Start();
            Indirim ındirim = new Indirim();
            ındirim.Show();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar.ToString();
        }
        private void btnTahsilat_Click(object sender, EventArgs e)
        {
            Tahsilat tahsilat = new Tahsilat();
            tahsilat.Show();
        }
    }
}
