using PizzaciSon1.Siparis;
using PizzaciSon1.Class;
using PizzaciSon1.Masalar;
using PizzaciSon1.Raporlar;
using PizzaciSon1.Ayarlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon1.Masalar
{
    public partial class BahceMasalar : Form
    {
        public BahceMasalar()
        {
            InitializeComponent();
        }

        public static bool bahceMasa;
        public static int bahceMasaNo = 0;
        public static int bahceMasaAdet;
        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";

        public void dinamikMetod(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int urunAdet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(masaNo) from Masalar where masaYeri='Bahçe'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                urunAdet = (int)dr[0];
            }
            bg.Close();

            for (int i = 0; i <= urunAdet; i++)
            {
                if ((sender as System.Windows.Forms.Button).TabIndex == i)
                {
                    bahceMasaNo = i;
                    SiparisAna siparis = new SiparisAna();
                    siparis.Show();
                    this.Hide();
                }
            }
        }

        private void BahceMasalar_Load(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToString("HH:mm");
            btnSaat.Text = saat;

            int toplamMiktar = 0;
            int doluMasa = 0;
            int urunAdet = 0;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(masaNo) from Masalar where masaYeri='Bahçe'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                urunAdet = (int)dr[0];

            bg.Close();

            List<string> urunIsim = new List<string>();
            int masaNo = 0;
            for (int i = 1; i <= urunAdet; i++)
            {
                bg.Open();
                cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY masaNo) indexer, * from Masalar where masaYeri='Bahçe') tablo where tablo.indexer=" + i + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    masaNo = ((int)dr["masaNo"]);

                bg.Close();
            }
            bahceMasaAdet = urunAdet;
            for (int i = 1; i <= urunAdet; i++)
            {
                int mutfak = 0;
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Name = "btn" + i.ToString();
                btn.Size = new Size(214, 195);
                btn.Text = i.ToString();
                btn.Margin = new Padding(0);
                btn.Font = new Font("Microsoft JhengHei", 15, FontStyle.Bold);
                btn.BackColor = Color.CornflowerBlue;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                PanelMasalar.Controls.Add(btn);
                btn.Click += new EventHandler(dinamikMetod);
                btn.TabIndex = i;

                if (VeriTabanı.veriVarmi("select * from Masalar where masaNo=" + i + " AND durum=1 AND masaYeri='Bahçe'"))
                {
                    doluMasa++;
                    VeriTabanı.masaHesapGoster(btn, i, "Bahçe", i);
                }
                try
                {
                    bg.Open();
                    cmd = new SqlCommand("select mutfak from Masalar where masaYeri='Bahçe' and masaNo=" + i + "", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                        mutfak = (int)dr[0];
                    bg.Close();
                }
                catch (Exception)
                { }
                if (mutfak == 1)
                    btn.BackColor = Color.Orange;
                if (mutfak == 2)
                    btn.BackColor = Color.Green;
                if (mutfak == 3)
                    btn.BackColor = Color.Turquoise;
                if (mutfak == 4)
                    btn.BackColor = Color.Red;
            }

            if (VeriTabanı.veriVarmi("select * from Masalar where masaYeri='Bahçe' and durum=1"))
            {
                btnMasaSayisi.Text = "Toplam Masa/Dolu Masa: " + urunAdet + "/" + doluMasa.ToString();
                bg.Open();
                SqlCommand cmd2 = new SqlCommand("select sum(fiyat) as toplamUcret from Masalar where durum=1 and masaYeri='Bahçe'", bg);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                    toplamMiktar = (int)dr2["toplamUcret"];

                btnToplamUcret.Text = "Toplam Ücret: " + toplamMiktar.ToString();
                bg.Close();
            }
            else
            {
                btnToplamUcret.Text = "Toplam Ücret: 0";
                btnMasaSayisi.Text = "Toplam Masa/Dolu Masa: " + urunAdet + "/0";
            }
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            SalonMasalar.salonMasa = true;
            bahceMasa = false;
            Anasayfa.pesinSatis = false;
            SalonMasalar salonMasalar = new SalonMasalar();
            salonMasalar.Show();
            this.Hide();
        }

        private void btnAcikMasalar_Click(object sender, EventArgs e)
        {
            SalonMasalar.salonMasa = false;
            bahceMasa = false;
            Anasayfa.pesinSatis = false;
            AcikMasalar acikMasalar = new AcikMasalar();
            acikMasalar.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            bahceMasa = false;
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
