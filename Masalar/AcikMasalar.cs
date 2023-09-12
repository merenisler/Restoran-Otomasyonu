using PizzaciSon1.Class;
using PizzaciSon1.Siparis;
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
    public partial class AcikMasalar : Form
    {
        public AcikMasalar()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";

        public void dinamikMetodSalon(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int urunAdet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(masaNo) from Masalar where masaYeri='Salon'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                urunAdet = (int)dr[0];
            }
            bg.Close();

            int masaNo = 0;
            string urunIsim = "";
            string stokKategori = "";
            int fiyat = 0;

            for (int i = 0; i <= urunAdet; i++)
            {
                if ((sender as System.Windows.Forms.Button).TabIndex == i)
                {
                    //bg.Open();
                    //cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY masaNo) indexer, * from Masalar where masaYeri='Salon') tablo where tablo.indexer=" + i + "", bg);
                    //dr = cmd.ExecuteReader();
                    //if (dr.Read())
                    //{
                    //    masaNo = ((int)dr["masaNo"]);
                    //}
                    //bg.Close();

                    //SalonMasalar.salonMasaNo = masaNo;
                    //SalonMasalar.salonMasa = true;
                    //BahceMasalar.bahceMasa = false;
                    //Anasayfa.pesinSatis = false;
                    //SiparisAna siparis = new SiparisAna();
                    //siparis.Show();
                    //this.Hide();
                }

            }
        }

        public void dinamikMetodBahce(object sender, EventArgs e)
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

                }
            }
        }

        private void AcikMasalar_Load(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToString("HH:mm");
            btnSaat.Text = saat;

            int toplamMiktar = 0;
            int doluMasa = 0;
            int urunAdet = 0;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(masaNo) from Masalar where Durum=1 and masaYeri='Salon'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                urunAdet = (int)dr[0];
            }
            bg.Close();

            int urunAdet4 = 0;
            bg.Open();
            cmd = new SqlCommand("select count(masaNo) from Masalar where masaYeri='Salon'", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                urunAdet4 = (int)dr[0];
            }
            bg.Close();

            int[] fiyat = new int[urunAdet];
            int[] masaNo = new int[urunAdet4];
            int a = 0;
            for (int i = 0; i < urunAdet4; i++)
            {
                if (VeriTabanı.veriVarmi("select * from Masalar where masaNo=" + i + " AND Durum=1 AND masaYeri='Salon'"))
                {
                    doluMasa++;
                    bg.Open();
                    cmd = new SqlCommand("select * from Masalar where masaNo=" + i + " AND Durum=1 AND masaYeri='Salon'", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        fiyat[a] = (int)dr["fiyat"];
                        masaNo[a] = (int)dr["masaNo"];
                        a++;
                    }
                    bg.Close();
                }
            }

            for (int i = 1; i <= urunAdet; i++)
            {
                int mutfak = 0;
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Name = "btn" + i.ToString();
                btn.Size = new Size(214, 195);
                btn.Text = "Salon " + masaNo[i - 1] + "\n\n" + fiyat[i - 1] + "TL";
                btn.Margin = new Padding(0);
                btn.Font = new Font("Microsoft JhengHei", 15, FontStyle.Bold);
                btn.BackColor = Color.Orange;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                PanelMasalar.Controls.Add(btn);
                btn.Click += new EventHandler(dinamikMetodSalon);
                btn.TabIndex = i;

                bg.Open();
                cmd = new SqlCommand("select mutfak from Masalar where masaYeri='Salon' and masaNo=" + masaNo[i - 1] + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    mutfak = (int)dr[0];
                bg.Close();
                if (mutfak == 1)
                    btn.BackColor = Color.Orange;
                if (mutfak == 2)
                    btn.BackColor = Color.Green;
                if (mutfak == 3)
                    btn.BackColor = Color.Turquoise;
                if (mutfak == 4)
                    btn.BackColor = Color.Red;
            }

            int toplamMiktar2 = 0;
            int urunAdet2 = 0;
            bg.Open();
            cmd = new SqlCommand("select count(masaNo) from Masalar where masaYeri='Bahçe' and Durum=1", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                urunAdet2 = (int)dr[0];
            }
            bg.Close();

            int urunAdet3 = 0;
            bg.Open();
            cmd = new SqlCommand("select count(masaNo) from Masalar where masaYeri='Bahçe'", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                urunAdet3 = (int)dr[0];
            }
            bg.Close();

            int[] fiyat2 = new int[urunAdet2];
            int[] masaNo2 = new int[urunAdet2];
            int b = 0;
            for (int i = 0; i < urunAdet3; i++)
            {
                if (VeriTabanı.veriVarmi("select * from Masalar where masaNo=" + i + " AND Durum=1 AND masaYeri='Bahçe'"))
                {
                    doluMasa++;
                    bg.Open();
                    cmd = new SqlCommand("select * from Masalar where masaNo=" + i + " AND durum=1 AND masaYeri='Bahçe'", bg);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        fiyat2[b] = (int)dr["fiyat"];
                        masaNo2[b] = (int)dr["masaNo"];
                        b++;
                    }
                    bg.Close();
                }
            }


            for (int i = 1; i <= urunAdet2; i++)
            {
                int mutfak = 0;
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Name = "btn" + i.ToString();
                btn.Size = new Size(214, 195);
                btn.Text = "Bahçe " + masaNo2[i - 1] + "\n\n" + fiyat2[i - 1] + "TL";
                btn.Margin = new Padding(0);
                btn.Font = new Font("Microsoft JhengHei", 15, FontStyle.Bold);
                btn.BackColor = Color.Orange;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                PanelMasalar.Controls.Add(btn);
                btn.Click += new EventHandler(dinamikMetodBahce);
                btn.TabIndex = i;

                bg.Open();
                cmd = new SqlCommand("select mutfak from Masalar where masaYeri='Bahçe' and masaNo=" + masaNo2[i - 1] + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    mutfak = (int)dr[0];
                bg.Close();
                if (mutfak == 1)
                    btn.BackColor = Color.Orange;
                if (mutfak == 2)
                    btn.BackColor = Color.Green;
                if (mutfak == 3)
                    btn.BackColor = Color.Turquoise;
                if (mutfak == 4)
                    btn.BackColor = Color.Red;
            }

            if (VeriTabanı.veriVarmi("select * from Masalar where Durum=1 and masaYeri='Bahçe' or masaYeri='Salon'"))
            {
                bg.Open();
                SqlCommand cmd2 = new SqlCommand("select sum(fiyat) as toplamUcret from Masalar where masaYeri='Bahçe' or masaYeri='Salon'", bg);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    toplamMiktar2 = (int)dr2["toplamUcret"];
                }
                toplamMiktar = toplamMiktar + toplamMiktar2;
                btnToplamUcret.Text = "Toplam Ücret: " + toplamMiktar.ToString();
                bg.Close();
            }
            else
                btnToplamUcret.Text = "Toplam Ücret: 0";
            int toplamMasa = SalonMasalar.salonMasaAdet + BahceMasalar.bahceMasaAdet;
            btnMasaSayisi.Text = "Toplam Masa/Dolu Masa: " + toplamMasa + "/" + doluMasa.ToString();
        }


        private void btnSalon_Click(object sender, EventArgs e)
        {
            SalonMasalar.salonMasa = true;
            BahceMasalar.bahceMasa = false;
            Anasayfa.pesinSatis = false;
            SalonMasalar salonMasalar = new SalonMasalar();
            salonMasalar.Show();
            this.Hide();
        }

        private void btnBahce_Click(object sender, EventArgs e)
        {
            SalonMasalar.salonMasa = false;
            BahceMasalar.bahceMasa = true;
            Anasayfa.pesinSatis = false;
            BahceMasalar bahceMasalar = new BahceMasalar();
            bahceMasalar.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void PanelMasalar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
