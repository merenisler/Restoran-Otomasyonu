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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzaciSon1.Siparis
{
    public partial class SiparisAna : Form
    {
        public SiparisAna()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";

        public static double toplamTutar = 0;

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

                    int miktarInt = 0;
                    if (txtUrunAdet.Text != "")
                    {
                        miktarInt = Convert.ToInt32(txtUrunAdet.Text);
                        fiyat = fiyat * miktarInt;
                        toplamTutar = toplamTutar + fiyat;
                        ListViewItem listele = new ListViewItem();
                        listele.Text = ("0");
                        listele.SubItems.Add((miktarInt + " ").ToString());
                        listele.SubItems.Add(urunIsim.ToString());
                        listele.SubItems.Add(fiyat.ToString());
                        listele.SubItems.Add(stokKategori);
                        listele.SubItems.Add("Yiyecek");
                        listele.SubItems.Add("");
                        lstViewSiparis.Items.Add(listele);
                        txtUrunAdet.Text = "";

                        bg.Open();
                        cmd = new SqlCommand("update GunSonu set Yiyecek=Yiyecek+" + miktarInt + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        fiyat = miktarInt * fiyat;
                        bg.Open();
                        cmd = new SqlCommand("update GunSonuFiyatlar set Yiyecek=Yiyecek+" + fiyat + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

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
                        listele.SubItems.Add("Yiyecek");
                        listele.SubItems.Add("");
                        lstViewSiparis.Items.Add(listele);
                        txtUrunAdet.Text = "";

                        bg.Open();
                        cmd = new SqlCommand("update GunSonu set Yiyecek=Yiyecek+1", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update GunSonuFiyatlar set Yiyecek=Yiyecek+" + fiyat + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }
                    txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;
                }
            }
        }

        public void dinamikMetodIcecek(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            int adet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) as adet FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'IcecekStok';", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adet = (int)dr["adet"];
            }
            bg.Close();

            string[] stokAdi = new string[adet];

            bg.Open();
            cmd = new SqlCommand("select * from IcecekStok", bg);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable schemaTable = dr.GetSchemaTable();
                for (int j = 0; j < adet; j++)
                {
                    stokAdi[j] = (string)schemaTable.Rows[j]["ColumnName"];
                }
            }
            bg.Close();

            int urunId = 0;
            string urunIsim = "";
            string stokKategori = "";
            int fiyat = 0;
            for (int i = 1; i <= adet; i++)
            {
                if ((sender as System.Windows.Forms.Button).TabIndex == i)
                {
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
                        int miktarInt = 0;
                        miktarInt = Convert.ToInt32(txtUrunAdet.Text);
                        fiyat = fiyat * miktarInt;
                        toplamTutar = toplamTutar + fiyat;
                        ListViewItem listele = new ListViewItem();
                        listele.Text = ("0");
                        listele.SubItems.Add((miktarInt + " ").ToString());
                        listele.SubItems.Add(urunIsim.ToString());
                        listele.SubItems.Add(fiyat.ToString());
                        listele.SubItems.Add(stokKategori);
                        listele.SubItems.Add("İçecek");
                        listele.SubItems.Add("");
                        lstViewSiparis.Items.Add(listele);
                        txtUrunAdet.Text = "";
                        txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;

                        bg.Open();
                        cmd = new SqlCommand("update GunSonu set icecek=icecek+" + miktarInt + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        fiyat = miktarInt * fiyat;
                        bg.Open();
                        cmd = new SqlCommand("update GunSonuFiyatlar set icecek=icecek+" + fiyat + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        for (int j = 0; j < adet; j++)
                        {
                            if (stokAdi[j] == stokKategori)
                            {
                                bg.Open();
                                cmd = new SqlCommand("update IcecekStok set " + stokAdi[j] + "=" + stokAdi[j] + "-" + miktarInt + "", bg);
                                cmd.ExecuteNonQuery();
                                bg.Close();
                            }
                        }
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
                        listele.SubItems.Add("");
                        lstViewSiparis.Items.Add(listele);
                        txtUrunAdet.Text = "";
                        txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;

                        bg.Open();
                        cmd = new SqlCommand("update GunSonu set icecek=icecek+1", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update GunSonuFiyatlar set icecek=icecek+" + fiyat + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        for (int j = 0; j < adet; j++)
                        {
                            if (stokAdi[j] == stokKategori)
                            {
                                bg.Open();
                                cmd = new SqlCommand("update IcecekStok set " + stokAdi[j] + "=" + stokAdi[j] + "-1", bg);
                                cmd.ExecuteNonQuery();
                                bg.Close();
                            }
                        }
                    }
                }
            }
        }

        private void SiparisAna_Load(object sender, EventArgs e)
        {
            // Timer'ı başlat
            Timer2.Start();
            btnUrunNotu.Visible = false; btnFisNotu.Visible = true;

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
                string fiyatt = "";
                string stokKategori = "";
                string kategori = "";
                string urunNotu = "";
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
                                fiyatt = (string)dr2["fiyat"];
                                stokKategori = (string)dr2["stokKategori"];
                                kategori = (string)dr2["kategori"];
                                urunNotu = (string)dr2["ozellik"];

                                if (yazdirdiMi == false)
                                    yazdir = "0";
                                if (yazdirdiMi == true)
                                    yazdir = "1";

                                string listbox = yazdir + "/" + adet + "/" + isim + "/" + fiyatt + "/" + stokKategori + "/" + kategori + "/" + urunNotu;
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
                string fiyatt = "";
                string stokKategori = "";
                string kategori = "";
                string urunNotu = "";
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
                                fiyatt = (string)dr5["fiyat"];
                                stokKategori = (string)dr5["stokKategori"];
                                kategori = (string)dr5["kategori"];
                                urunNotu = (string)dr5["ozellik"];

                                if (yazdirdiMi == false)
                                    yazdir = "0";
                                if (yazdirdiMi == true)
                                    yazdir = "1";

                                string listbox = yazdir + "/" + adet + "/" + isim + "/" + fiyatt + "/" + stokKategori + "/" + kategori + "/" + urunNotu;
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


            //YiyecekButton
            int urunAdet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(urunId) from FiyatListesi where kategori='Yiyecek'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
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
            List<int> stokAdet = new List<int>();
            string[] stokAd = new string[urunAdet2];
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
                }
                bg.Close();
            }

            bg.Open();
            cmd = new SqlCommand("select * from IcecekStok", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    stokAdet.Add((int)dr[i]);
                }
            }
            bg.Close();

            bg.Open();
            cmd = new SqlCommand("select * from IcecekStok", bg);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable schemaTable = dr.GetSchemaTable();
                for (int j = 0; j < urunAdet2; j++)
                {
                    stokAd[j] = (string)schemaTable.Rows[j]["ColumnName"];
                }
            }
            bg.Close();

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

                if (stokAdet[i - 1] == 0)
                {
                    btn2.Enabled = false;
                }
            }

            for (int i = 0; i < urunAdet2; i++)
            {
                if (stokAdet[i] <= 20)
                    MessageBox.Show(stokAd[i] + " Stoğu Azalıyor Kalan: " + stokAdet[i]);
            }
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
                            komut = new SqlCommand("insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)", bg);
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
                                string fiyat = "";
                                string stokKategori = "";
                                string kategori = "";
                                string urunNotu = "";
                                for (int j = 0; j < lstViewSiparis.Items.Count; j++)
                                {
                                    yazdir = lstViewSiparis.Items[j].SubItems[0].Text;
                                    adet = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[1].Text);
                                    isim = lstViewSiparis.Items[j].SubItems[2].Text;
                                    fiyat = lstViewSiparis.Items[j].SubItems[3].Text;
                                    stokKategori = lstViewSiparis.Items[j].SubItems[4].Text;
                                    kategori = lstViewSiparis.Items[j].SubItems[5].Text;
                                    urunNotu = lstViewSiparis.Items[j].SubItems[6].Text;

                                    bool yazdirdiMi = false;
                                    if (yazdir == "0")
                                        yazdirdiMi = false;
                                    if (yazdir == "1")
                                        yazdirdiMi = true;

                                    string masaNo = "Salon" + i;
                                    bg.Open();
                                    cmd = new SqlCommand("insert into " + masaNo + "(yazdir, adet, isim, fiyat, stokKategori, kategori, ozellik) values (@yazdir, @adet, @isim, @fiyat, @stokKategori, @kategori, @ozellik)", bg);
                                    cmd.Parameters.AddWithValue("@yazdir", yazdirdiMi);
                                    cmd.Parameters.AddWithValue("@adet", adet);
                                    cmd.Parameters.AddWithValue("@isim", isim);
                                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                                    cmd.Parameters.AddWithValue("@stokKategori", stokKategori);
                                    cmd.Parameters.AddWithValue("@kategori", kategori);
                                    cmd.Parameters.AddWithValue("@ozellik", urunNotu);
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
                        SqlCommand cmd = new SqlCommand("update ListboxKontrol set listbox=@listbox, tutar=@fiyat, durum=@durum, fisNotu=@fisNotu where masaYeri=@masaYeri and masaNo=@masaNo", bg);
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
                                string fiyat = "";
                                string stokKategori = "";
                                string kategori = "";
                                string urunNotu = "";
                                for (int j = 0; j < lstViewSiparis.Items.Count; j++)
                                {
                                    yazdir = lstViewSiparis.Items[j].SubItems[0].Text;
                                    adet = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[1].Text);
                                    isim = lstViewSiparis.Items[j].SubItems[2].Text;
                                    fiyat = lstViewSiparis.Items[j].SubItems[3].Text;
                                    stokKategori = lstViewSiparis.Items[j].SubItems[4].Text;
                                    kategori = lstViewSiparis.Items[j].SubItems[5].Text;
                                    urunNotu = lstViewSiparis.Items[j].SubItems[6].Text;

                                    bool yazdirdiMi = false;
                                    if (yazdir == "0")
                                        yazdirdiMi = false;
                                    if (yazdir == "1")
                                        yazdirdiMi = true;

                                    bg.Open();
                                    cmd = new SqlCommand("insert into " + masaNo + "(yazdir, adet, isim, fiyat, stokKategori, kategori, ozellik) values (@yazdir, @adet, @isim, @fiyat, @stokKategori, @kategori, @ozellik)", bg);
                                    cmd.Parameters.AddWithValue("@yazdir", yazdirdiMi);
                                    cmd.Parameters.AddWithValue("@adet", adet);
                                    cmd.Parameters.AddWithValue("@isim", isim);
                                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                                    cmd.Parameters.AddWithValue("@stokKategori", stokKategori);
                                    cmd.Parameters.AddWithValue("@kategori", kategori);
                                    cmd.Parameters.AddWithValue("@ozellik", urunNotu);
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
                if (lstViewSiparis.Items.Count != 0)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select * from ListboxKontrol where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        durum = (bool)dr["durum"];
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
                                string fiyat = "";
                                string stokKategori = "";
                                string kategori = "";
                                string urunNotu = "";
                                for (int j = 0; j < lstViewSiparis.Items.Count; j++)
                                {
                                    yazdir = lstViewSiparis.Items[j].SubItems[0].Text;
                                    adet = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[1].Text);
                                    isim = lstViewSiparis.Items[j].SubItems[2].Text;
                                    fiyat = lstViewSiparis.Items[j].SubItems[3].Text;
                                    stokKategori = lstViewSiparis.Items[j].SubItems[4].Text;
                                    kategori = lstViewSiparis.Items[j].SubItems[5].Text;
                                    urunNotu = lstViewSiparis.Items[j].SubItems[6].Text;

                                    bool yazdirdiMi = false;
                                    if (yazdir == "0")
                                        yazdirdiMi = false;
                                    if (yazdir == "1")
                                        yazdirdiMi = true;

                                    string masaNo = "Bahce" + i;
                                    bg.Open();
                                    sql = "insert into " + masaNo + "(yazdir, adet, isim, fiyat, stokKategori, kategori, ozellik) values (@yazdir, @adet, @isim, @fiyat, @stokKategori, @kategori, @ozellik)";
                                    cmd = new SqlCommand(sql, bg);
                                    cmd.Parameters.AddWithValue("@yazdir", yazdirdiMi);
                                    cmd.Parameters.AddWithValue("@adet", adet);
                                    cmd.Parameters.AddWithValue("@isim", isim);
                                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                                    cmd.Parameters.AddWithValue("@stokKategori", stokKategori);
                                    cmd.Parameters.AddWithValue("@kategori", kategori);
                                    cmd.Parameters.AddWithValue("@ozellik", urunNotu);
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
                                string fiyat = "";
                                string stokKategori = "";
                                string kategori = "";
                                string urunNotu = "";
                                for (int j = 0; j < lstViewSiparis.Items.Count; j++)
                                {
                                    yazdir = lstViewSiparis.Items[j].SubItems[0].Text;
                                    adet = Convert.ToInt32(lstViewSiparis.Items[j].SubItems[1].Text);
                                    isim = lstViewSiparis.Items[j].SubItems[2].Text;
                                    fiyat = lstViewSiparis.Items[j].SubItems[3].Text;
                                    stokKategori = lstViewSiparis.Items[j].SubItems[4].Text;
                                    kategori = lstViewSiparis.Items[j].SubItems[5].Text;
                                    urunNotu = lstViewSiparis.Items[j].SubItems[6].Text;

                                    bool yazdirdiMi = false;
                                    if (yazdir == "0")
                                        yazdirdiMi = false;
                                    if (yazdir == "1")
                                        yazdirdiMi = true;

                                    bg.Open();
                                    sql = "insert into " + masaNo + "(yazdir, adet, isim, fiyat, stokKategori, kategori, ozellik) values (@yazdir, @adet, @isim, @fiyat, @stokKategori, @kategori, @ozellik)";
                                    cmd = new SqlCommand(sql, bg);
                                    cmd.Parameters.AddWithValue("@yazdir", yazdirdiMi);
                                    cmd.Parameters.AddWithValue("@adet", adet);
                                    cmd.Parameters.AddWithValue("@isim", isim);
                                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                                    cmd.Parameters.AddWithValue("@stokKategori", stokKategori);
                                    cmd.Parameters.AddWithValue("@kategori", kategori);
                                    cmd.Parameters.AddWithValue("@ozellik", urunNotu);
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
                if (Telefon.telefonNo!=0 && Adres.adres!="")
                {
                    MessageBox.Show("Paket Servis Kaydı Yapıldı");
                    Anasayfa anaSayfa = new Anasayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else if (txtBxToplamTutar.Text == "Toplam Tutar: 0.00" || txtBxToplamTutar.Text == "Toplam Tutar: 0")
                {
                    Anasayfa anaSayfa = new Anasayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Çıkış Yapamazsınız!");
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
            int iptalIcecek = 0;
            int iptalYiyecek = 0;
            int urunAdet2 = 0;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(urunId) from FiyatListesi where kategori='İçecek'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { urunAdet2 = (int)dr[0]; }
            bg.Close();
            List<int> stokAdet = new List<int>();
            string[] stokAd = new string[urunAdet2];
            bg.Open();
            cmd = new SqlCommand("select * from IcecekStok", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    stokAdet.Add((int)dr[i]);
                }
            }
            bg.Close();

            bg.Open();
            cmd = new SqlCommand("select * from IcecekStok", bg);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable schemaTable = dr.GetSchemaTable();
                for (int j = 0; j < urunAdet2; j++)
                {
                    stokAd[j] = (string)schemaTable.Rows[j]["ColumnName"];
                }
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

                for (int i = 0; i < urunAdet2; i++)
                {
                    if (urunStokKategori == stokAd[i])
                    {
                        bg.Open();
                        SqlCommand oku = new SqlCommand("update IcecekStok set " + urunStokKategori + "=" + urunStokKategori + "+" + urunAdet + "", bg);
                        oku.ExecuteNonQuery();
                        bg.Close();

                        Icecek = Icecek - urunAdet;
                        iptalIcecek = iptalIcecek + urunAdet;
                    }
                }

                if (urunKategori == "Yiyecek")
                {
                    Yiyecek = Yiyecek - urunAdet;
                    iptalYiyecek = iptalYiyecek + urunAdet;
                }

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
                if (SalonMasalar.salonMasa == true)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select * from Masalar where masaNo=" + SalonMasalar.salonMasaNo + " and masaYeri='Salon'", bg);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    { adisyonNo = (int)dr["adisyonNo"]; }
                    bg.Close();
                }
                if (BahceMasalar.bahceMasa == true)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select * from Masalar where masaNo=" + BahceMasalar.bahceMasaNo + " and masaYeri='Bahçe'", bg);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    { adisyonNo = (int)dr["adisyonNo"]; }
                    bg.Close();
                }
                if (adisyonNo == 0)
                {
                    bg.Open();
                    SqlCommand komut = new SqlCommand("select Count(adisyonNo) as AdisyonNo from GunlukAdisyon", bg);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    { adisyonNo = (int)dr["AdisyonNo"]; }
                    bg.Close();
                    adisyonNo++;
                }
                int adisyonAralik = 0;
                int aralik = 30;
                int a = 0;
                e.Graphics.DrawString(adisyonNo.ToString(), font, firca, 325, 100);
                Font ozellikFont = new Font("Arial", 13);
                for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                {
                    font = new Font("Arial", 16);
                    if (lstViewSiparis.Items[i].SubItems[0].Text == "0")
                    {
                        string[] dizi = new string[lstViewSiparis.Items.Count];
                        dizi[i] = lstViewSiparis.Items[i].SubItems[1].Text + " - " + lstViewSiparis.Items[i].SubItems[2].Text + " - " + lstViewSiparis.Items[i].SubItems[3].Text;

                        if (i == 0)
                        {
                            e.Graphics.DrawString(dizi[i], font, firca, 100, 148);
                            a++;
                            if (lstViewSiparis.Items[i].SubItems[6].Text != "")
                            {
                                string ozellik = "";
                                ozellik = lstViewSiparis.Items[i].SubItems[6].Text;
                                string[] ozellikk = ozellik.Split(',');
                                for (int j = 0; j < ozellikk.Length; j++)
                                {
                                    e.Graphics.DrawString(ozellikk[j], ozellikFont, firca, 150, (148 + (aralik * a)));
                                    if ((ozellikk.Length-1)>j)
                                        a++;
                                }
                            }
                        }
                        else
                        {
                            e.Graphics.DrawString(dizi[i], font, firca, 100, (148 + (aralik * a)));
                            a++;
                            if (lstViewSiparis.Items[i].SubItems[6].Text != "")
                            {
                                string ozellik = "";
                                ozellik = lstViewSiparis.Items[i].SubItems[6].Text;
                                string[] ozellikk = ozellik.Split(',');
                                for (int j = 0; j < ozellikk.Length; j++)
                                {
                                    e.Graphics.DrawString(ozellikk[j], ozellikFont, firca, 150, (148 + (aralik * a)));
                                    if ((ozellikk.Length - 1) > j)
                                        a++;
                                }
                            }
                        }
                    }
                }
                font = new Font("Arial", 16, FontStyle.Bold);
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, (148 + (aralik * a)));
                e.Graphics.DrawString(("Fiş Notu: " + fisNotu), font, firca, 100, (160 + (aralik * a)));

            }
            catch (Exception) { }
        }

        private void btnAdisyon_Click(object sender, EventArgs e)
        {
            if (paketServisTelefon != "" && paketServisAdres != "")
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
            {
                try
                { adisyonNo = (int)dr["AdisyonNo"]; }
                catch (Exception)
                { }
            }
            bg.Close();
            adisyonNo++;
            int paketServis = 0;
            bg.Open();
            komut = new SqlCommand("select Count(*) as AdisyonNo from PaketServis", bg);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                try
                { paketServis = (int)dr["AdisyonNo"]; }
                catch (Exception)
                { }
            }
            paketServis++;
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
                e.Graphics.DrawString("Adisyon No: " + adisyonNo.ToString(), font, firca, 100, 145);
                e.Graphics.DrawString("Paket Servis No: " + paketServis.ToString(), font, firca, 100, 175);
                e.Graphics.DrawString(("Telefon No: " + paketServisTelefon), font, firca, 100, 207);
                e.Graphics.DrawString(("Adres: " + paketServisAdres), font, firca, 100, 239);
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, 285);
                font = new Font("Arial", 16, FontStyle.Bold);
                e.Graphics.DrawString(("Fiş Notu: " + fisNotu), font, firca, 100, 310);
                Font ozellikFont = new Font("Arial", 13);
                int a = 0;
                int aralik = 30;
                int adisyonAralik = 0;
                for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                {
                    font = new Font("Arial", 16);

                    string[] dizi = new string[lstViewSiparis.Items.Count];
                    dizi[i] = lstViewSiparis.Items[i].SubItems[1].Text + " - " + lstViewSiparis.Items[i].SubItems[2].Text + " -" +
                        " " + lstViewSiparis.Items[i].SubItems[3].Text;
                    if (i == 0)
                    {
                        e.Graphics.DrawString(dizi[i], font2, firca, 100, 370);
                        a++;
                        if (lstViewSiparis.Items[i].SubItems[6].Text != "")
                        {
                            string ozellik = "";
                            ozellik = lstViewSiparis.Items[i].SubItems[6].Text;
                            string[] ozellikk = ozellik.Split(',');
                            for (int j = 0; j < ozellikk.Length; j++)
                            {
                                e.Graphics.DrawString(ozellikk[j], ozellikFont, firca, 150, (370 + (aralik * a)));
                                if ((ozellikk.Length - 1) > j)
                                    a++;
                            }
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString(dizi[i], font2, firca, 100, (370 + (aralik * a)));
                        a++;
                        if (lstViewSiparis.Items[i].SubItems[6].Text != "")
                        {
                            string ozellik = "";
                            ozellik = lstViewSiparis.Items[i].SubItems[6].Text;
                            string[] ozellikk = ozellik.Split(',');
                            for (int j = 0; j < ozellikk.Length; j++)
                            {
                                e.Graphics.DrawString(ozellikk[j], ozellikFont, firca, 150, (370 + (aralik * a)));
                                if ((ozellikk.Length - 1) > j)
                                    a++;
                            }
                        }
                    }
                }
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, (370 + (aralik*a)));
                e.Graphics.DrawString(("Toplam Ücret: " + toplamTutar), font3, firca, 200, (390 + (aralik * a)));

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

                        int adisyonNo = 0;
                        bg.Open();
                        cmd = new SqlCommand("select * from Masalar where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            adisyonNo = (int)dr["adisyonNo"];
                        }
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update GunlukAdisyon set adisyonKapanisSaat=@adisyonKapanisSaat, adisyonIcerik=@adisyonIcerik, odemeDurumu='Ödendi', tutar=@tutar where adisyonNo=@adisyonNo and odemeDurumu=''", bg);
                        cmd.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        cmd.Parameters.AddWithValue("@adisyonIcerik", listbox);
                        cmd.Parameters.AddWithValue("@tutar", toplamTutar);
                        cmd.Parameters.AddWithValue("@adisyonNo", adisyonNo);
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

                        int adisyonNo = 0;
                        bg.Open();
                        cmd = new SqlCommand("select * from Masalar where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            adisyonNo = (int)dr["adisyonNo"];
                        }
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update GunlukAdisyon set adisyonKapanisSaat=@adisyonKapanisSaat, adisyonIcerik=@adisyonIcerik, odemeDurumu='Ödendi', tutar=@tutar where adisyonNo=@adisyonNo and odemeDurumu=''", bg);
                        cmd.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        cmd.Parameters.AddWithValue("@adisyonIcerik", listbox);
                        cmd.Parameters.AddWithValue("@adisyonNo", adisyonNo);
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

                            int id = 0;
                            bg.Open();
                            SqlCommand cmd = new SqlCommand("select count(*) as id from PaketServis", bg);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            { id = (int)dr["id"]; }
                            bg.Close();

                            bg.Open();
                            komut2 = new SqlCommand("insert into PaketAtama(KuryeId, SiparisId, YolaCikisSaat, GelisSaat, Durum) values (0, @SiparisId, @p1, @p2, @Durum)", bg);
                            komut2.Parameters.AddWithValue("@SiparisId", id);
                            komut2.Parameters.AddWithValue("@p1", "00:00:00");
                            komut2.Parameters.AddWithValue("@p2", "00:00:00");
                            komut2.Parameters.AddWithValue("@Durum", "Siparis Geldi");
                            komut2.ExecuteNonQuery();
                            bg.Close();

                            MessageBox.Show("Paket Servis Kaydı Yapıldı.");
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
            DialogResult dialogResult = MessageBox.Show("Fişi İptal Etmek İstiyormusnuz?", "Uyarı!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
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

                int urunAdet3 = 0;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select count(urunId) from FiyatListesi where kategori='İçecek'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { urunAdet3 = (int)dr[0]; }
                bg.Close();
                string[] stokAd = new string[urunAdet3];
                bg.Open();
                cmd = new SqlCommand("select * from IcecekStok", bg);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable schemaTable = dr.GetSchemaTable();
                    for (int j = 0; j < urunAdet3; j++)
                    {
                        stokAd[j] = (string)schemaTable.Rows[j]["ColumnName"];
                    }
                }
                bg.Close();


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

                }

                for (int i = 0; i < dizi2.Count(); i++)
                {
                    if (dizi5[i] == "Yiyecek")
                    {
                        int urunAdet2 = Convert.ToInt32(dizi3[i]);
                        iptalYiyecek = iptalYiyecek + urunAdet2;
                        if (dizi4[i] != "İkram")
                        {
                            int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                            iptalYiyecekUcret = iptalYiyecekUcret + iptalUcret3;
                        }
                    }
                    else
                    {
                        int urunAdet2 = Convert.ToInt32(dizi3[i]);
                        iptalIcecek = iptalIcecek + urunAdet2;
                        if (dizi4[i] != "İkram")
                        {
                            int iptalUcret3 = Convert.ToInt32(dizi4[i]);
                            iptalIcecekUcret = iptalIcecekUcret + iptalUcret3;
                        }

                        for (int j = 0; j < urunAdet3; j++)
                        {
                            if (dizi2[i] == stokAd[j])
                            {
                                bg.Open();
                                cmd = new SqlCommand("update IcecekStok set " + stokAd[j] + "=" + stokAd[j] + "+" + urunAdet2 + "", bg);
                                cmd.ExecuteNonQuery();
                                bg.Close();
                            }
                        }
                    }
                }

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
                        int adisyonNo = 0;
                        bg.Open();
                        cmd = new SqlCommand("select * from Masalar where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            adisyonNo = (int)dr["adisyonNo"];
                        }
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update GunlukAdisyon set adisyonKapanisSaat=@adisyonKapanisSaat, tutar=@tutar, odemeDurumu='Fiş İptal' where adisyonNo=" + adisyonNo + "", bg);
                        cmd.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        cmd.Parameters.AddWithValue("@tutar", toplamTutar);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update ListboxKontrol set listbox='', tutar=0, durum='false', fisNotu='' where masaYeri='Salon' and masaNo=" + SalonMasalar.salonMasaNo + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }
                    else
                    {
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
                            string islem = "Salon/" + SalonMasalar.salonMasaNo.ToString();
                            bg.Open();
                            cmd = new SqlCommand("insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)", bg);
                            cmd.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                            cmd.Parameters.AddWithValue("@adisyonKapanisSaat", Saat);
                            cmd.Parameters.AddWithValue("@adisyonIcerik", listbox);
                            cmd.Parameters.AddWithValue("@odemeDurumu", "Fiş İptal");
                            cmd.Parameters.AddWithValue("@islem", islem);
                            cmd.Parameters.AddWithValue("@tutar", toplamTutar);
                            cmd.ExecuteNonQuery();
                            bg.Close();
                        }
                        catch (Exception) { }
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
                        int adisyonNo = 0;
                        bg.Open();
                        cmd = new SqlCommand("select * from Masalar where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            adisyonNo = (int)dr["adisyonNo"];
                        }
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update GunlukAdisyon set adisyonKapanisSaat=@adisyonKapanisSaat, tutar=@tutar, odemeDurumu='Fiş İptal' where adisyonNo=" + adisyonNo + "", bg);
                        cmd.Parameters.AddWithValue("@adisyonKapanisSaat", KapanisSaat);
                        cmd.Parameters.AddWithValue("@tutar", toplamTutar);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update ListboxKontrol set listbox='', tutar=0, durum='false', fisNotu='' where masaYeri='Bahçe' and masaNo=" + BahceMasalar.bahceMasaNo + "", bg);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                    }
                    else
                    {
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
                            string islem = "Bahçe/" + BahceMasalar.bahceMasaNo.ToString();
                            bg.Open();
                            cmd = new SqlCommand("insert into GunlukAdisyon(adisyonAcilisSaat, adisyonKapanisSaat, adisyonIcerik, odemeDurumu, islem, tutar) values (@adisyonAcilisSaat, @adisyonKapanisSaat, @adisyonIcerik, @odemeDurumu, @islem, @tutar)", bg);
                            cmd.Parameters.AddWithValue("@adisyonAcilisSaat", adisyonAcilisSaat);
                            cmd.Parameters.AddWithValue("@adisyonKapanisSaat", Saat);
                            cmd.Parameters.AddWithValue("@adisyonIcerik", listbox);
                            cmd.Parameters.AddWithValue("@odemeDurumu", "Fiş İptal");
                            cmd.Parameters.AddWithValue("@islem", islem);
                            cmd.Parameters.AddWithValue("@tutar", toplamTutar);
                            cmd.ExecuteNonQuery();
                            bg.Close();
                        }
                        catch (Exception) { }
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
            Timer1.Start();
            Tahsilat tahsilat = new Tahsilat();
            tahsilat.Show();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // Her zaman kontrol etmek istiyorsanız, bu metodu kullanabilirsiniz.
            CheckListViewSelection();
        }
        private void CheckListViewSelection()
        {
            if (lstViewSiparis.SelectedItems.Count > 0)
            {
                // Bir veya daha fazla satır seçilmiş
                btnUrunNotu.Visible = true; btnFisNotu.Visible = false;
            }
            else
            {
                // Hiçbir satır seçilmemiş
                btnUrunNotu.Visible = false; btnFisNotu.Visible = true;
            }
        }
        public static int index = 0;
        private void btnUrunNotu_Click(object sender, EventArgs e)
        {
            string ozellikk = "";
            ozellikk = lstViewSiparis.SelectedItems[0].SubItems[6].Text;
            string[] ozellik = ozellikk.Split(',');
            gridViewOzellikler.Rows.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Ozellikler", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < ozellik.Length; i++)
                {
                    if ((string)dr["ozellikIsmi"] == ozellik[i])
                    {
                        gridViewOzellikler.Rows.Add(true, dr["ozellikIsmi"]);
                        goto devam;
                    }
                }
                gridViewOzellikler.Rows.Add(false, dr["ozellikIsmi"]);
            devam:
                int a = 0;
            }
            bg.Close();
            gridViewOzellikler.Rows.Add(false, "");
            gridViewOzellikler.Columns["Ozellik"].ReadOnly = true;
            gridViewOzellikler.Visible = true;
            btnOzellikOnayla.Visible = true;
            btnOzellikCikis.Visible = true;
        }

        private void btnOzellikOnayla_Click(object sender, EventArgs e)
        {
            gridViewOzellikler.Visible = false;
            btnOzellikOnayla.Visible = false;
            btnOzellikCikis.Visible = false;

            int i = 0;
            string[] ozellikler = new string[15];
            foreach (DataGridViewRow row in gridViewOzellikler.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Secim"] as DataGridViewCheckBoxCell;

                // CheckBox seçiliyse, satırı dataGridView2'ye ekle
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    string ozellik = "";
                    ozellik = ((string)row.Cells[1].Value);
                    ozellikler[i] = ozellik + ",";
                }
                i++;
            }
            string ozellikk = "";
            for (int j = 0; j < ozellikler.Length; j++)
            {
                ozellikk += ozellikler[j];
            }
            lstViewSiparis.SelectedItems[0].SubItems[6].Text = ozellikk;

        }

        private void btnOzellikCikis_Click(object sender, EventArgs e)
        {
            gridViewOzellikler.Visible = false;
            btnOzellikOnayla.Visible = false;
            btnOzellikCikis.Visible = false;
        }
    }
}
