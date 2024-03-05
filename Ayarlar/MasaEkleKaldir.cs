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

namespace PizzaciSon1.Ayarlar
{
    public partial class MasaEkleKaldir : Form
    {
        public MasaEkleKaldir()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        int masaNo = 0;
        string masaYeri = "";

        public void Listele(string masaYeriSecim)
        {
            lstViewMasalar.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Masalar where masaYeri='" + masaYeriSecim + "' order by masaNo", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = oku["masaNo"].ToString();
                listele.SubItems.Add(oku["masaYeri"].ToString());
                lstViewMasalar.Items.Add(listele);
            }
            bg.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string masaYeriSecim = "";
            masaYeriSecim = cmbBxMasaYeri.Text;
            Listele(masaYeriSecim);

            int masaAdet = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select Count(*) as masaAdet from Masalar where masaYeri='" + masaYeriSecim + "'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                masaAdet = (int)oku["masaAdet"];
            }
            bg.Close();
            masaAdet += 1;
            cmbBxMasaNo.Text = masaAdet.ToString();
            cmbBxMasaYeri2.Text = masaYeriSecim;
        }

        private void lstViewMasalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if (lstViewMasalar.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    items = lstViewMasalar.SelectedItems[0].SubItems[i].Text;
                    if (i == 0)
                        masaNo = Convert.ToInt32(items);
                    if (i == 1)
                        masaYeri = items;
                }
            }
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand guncel = new SqlCommand("delete Masalar where masaNo=@masaNo and masaYeri=@masaYeri", bg);
            guncel.Parameters.AddWithValue("@masaNo", masaNo);
            guncel.Parameters.AddWithValue("@masaYeri", masaYeri);
            guncel.ExecuteNonQuery();
            bg.Close();

            bg.Open();
            guncel = new SqlCommand("delete ListboxKontrol where masaNo=@masaNo and masaYeri=@masaYeri", bg);
            guncel.Parameters.AddWithValue("@masaNo", masaNo);
            guncel.Parameters.AddWithValue("@masaYeri", masaYeri);
            guncel.ExecuteNonQuery();
            bg.Close();

            if (masaYeri == "Bahçe")
                masaYeri = "Bahce";

            string masa = masaYeri + masaNo;
            bg.Open();
            SqlCommand cmd = new SqlCommand("drop table " + masa + "", bg);
            cmd.ExecuteNonQuery();
            bg.Close();

            string masaYeriSecim = "";
            masaYeriSecim = cmbBxMasaYeri.Text;
            Listele(masaYeriSecim);

            int masaAdet = 0;
            bg.Open();
            cmd = new SqlCommand("select Count(*) as masaAdet from Masalar where masaYeri='" + masaYeriSecim + "'", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                masaAdet = (int)oku["masaAdet"];
            }
            bg.Close();
            masaAdet += 1;
            cmbBxMasaNo.Text = masaAdet.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string yeniMasaYeri = "";
            int yeniMasaNo = 0;

            if (cmbBxMasaYeri2.Text != "")
                yeniMasaYeri = cmbBxMasaYeri2.Text;
            if (cmbBxMasaNo.Text != "")
                yeniMasaNo = Convert.ToInt32(cmbBxMasaNo.Text);

            SqlConnection bg = new SqlConnection(ConnectionString);
            if (yeniMasaYeri != "" && yeniMasaNo != 0)
            {
                bg.Open();
                SqlCommand guncel = new SqlCommand("insert into Masalar(masaNo, masaYeri, durum, fiyat) values(@masaNo, @masaYeri, 'false', 0)", bg);
                guncel.Parameters.AddWithValue("@masaNo", yeniMasaNo);
                guncel.Parameters.AddWithValue("@masaYeri", yeniMasaYeri);
                guncel.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                guncel = new SqlCommand("insert into ListboxKontrol(listbox, tutar, durum, masaYeri, masaNo, fisNotu) values('', 0, 'false', @masaYeri, @masaNo, '')", bg);
                guncel.Parameters.AddWithValue("@masaNo", yeniMasaNo);
                guncel.Parameters.AddWithValue("@masaYeri", yeniMasaYeri);
                guncel.ExecuteNonQuery();
                bg.Close();

                if (yeniMasaYeri == "Bahçe")
                    yeniMasaYeri = "Bahce";
                string masa = yeniMasaYeri + yeniMasaNo;
                bg.Open();
                guncel = new SqlCommand("create table " + masa + "(yazdir bit, adet int, isim nvarchar(50), fiyat nvarchar(10), stokKategori nvarchar(30), kategori nvarchar(10));", bg);
                guncel.ExecuteNonQuery();
                bg.Close();

                string masaYeriSecim = "";
                masaYeriSecim = cmbBxMasaYeri.Text;
                Listele(masaYeriSecim);
                cmbBxMasaNo.Text = (yeniMasaNo + 1).ToString();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            AyarlarAna ayarlarAna = new AyarlarAna();
            ayarlarAna.Show();
            this.Hide();
        }
        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            UrunDuzenle urunDuzenle = new UrunDuzenle();
            urunDuzenle.Show();
            this.Hide();
        }
        private void btnUrunEkleKaldir_Click(object sender, EventArgs e)
        {
            UrunEkleKaldir urunEkleKaldir = new UrunEkleKaldir();
            urunEkleKaldir.Show();
            this.Hide();
        }
    }
}
