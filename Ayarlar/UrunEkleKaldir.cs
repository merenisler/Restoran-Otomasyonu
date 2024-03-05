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
    public partial class UrunEkleKaldir : Form
    {
        public UrunEkleKaldir()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        string secilenUrunAdi = "";
        int secilenUrunFiyat = 0;
        string secilenUrunKategori = "";
        int secilenUrunId = 0;

        private void Listele(string kategoriSecim)
        {
            lstViewUrunler.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from FiyatListesi where kategori='" + kategoriSecim + "' order by urunId", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = oku["urunIsim"].ToString();
                listele.SubItems.Add(oku["fiyat"].ToString());
                listele.SubItems.Add(oku["kategori"].ToString());
                listele.SubItems.Add(oku["urunId"].ToString());
                lstViewUrunler.Items.Add(listele);
            }
            bg.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string kategoriSecim = "";
            kategoriSecim = cmbBxKategori.Text;
            Listele(kategoriSecim);
        }

        private void lstViewUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if (lstViewUrunler.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    items = lstViewUrunler.SelectedItems[0].SubItems[i].Text;
                    if (i == 0)
                        secilenUrunAdi = items;
                    if (i == 1)
                        secilenUrunFiyat = Convert.ToInt32(items);
                    if (i == 2)
                        secilenUrunKategori = items;
                    if (i == 3)
                        secilenUrunId = Convert.ToInt32(items);
                }
            }
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            if (secilenUrunAdi!="" && secilenUrunFiyat!=0 && secilenUrunKategori=="" && secilenUrunId!=0)
            {
                SqlConnection bg = new SqlConnection(ConnectionString);
                string stokAdi = "";
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from FiyatListesi where urunId=" + secilenUrunId + " and urunIsim='" + secilenUrunAdi + "'", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    stokAdi = (string)oku["stokKategori"];
                }
                bg.Close();

                bg.Open();
                SqlCommand guncel = new SqlCommand("delete FiyatListesi where urunId=@urunId and urunIsim=@urunIsim and fiyat=@fiyat", bg);
                guncel.Parameters.AddWithValue("@urunIsim", secilenUrunAdi);
                guncel.Parameters.AddWithValue("@fiyat", secilenUrunFiyat);
                guncel.Parameters.AddWithValue("@urunId", secilenUrunId);
                guncel.ExecuteNonQuery();
                bg.Close();

                if (secilenUrunKategori == "İçecek")
                {
                    bg.Open();
                    guncel = new SqlCommand("alter table IcecekStok drop column " + stokAdi + "", bg);
                    guncel.ExecuteNonQuery();
                    bg.Close();
                }

                string kategoriSecim = "";
                kategoriSecim = cmbBxKategori.Text;
                Listele(kategoriSecim);
                txtBxUrunAdi.Text = "";
                txtBxUrunFiyati.Text = "";
                cmbBxKategori.Text = "";
                cmbBxStokKategori.Text = "";
            }
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string yeniUrunAdi = ""; int yeniUrunFiyat = 0;
            string yeniUrunKategori = ""; string yeniUrunStokKategori = "";

            if (txtBxUrunAdi.Text != "")
                yeniUrunAdi = txtBxUrunAdi.Text;
            if (txtBxUrunFiyati.Text != "")
                yeniUrunFiyat = Convert.ToInt32(txtBxUrunFiyati.Text);
            if (cmbBxUrunKategori.Text != "")
                yeniUrunKategori = cmbBxUrunKategori.Text;
            if (cmbBxStokKategori.Text != "")
                yeniUrunStokKategori = cmbBxStokKategori.Text;

            SqlConnection bg = new SqlConnection(ConnectionString);
            if (yeniUrunAdi != "" && yeniUrunFiyat != 0 && yeniUrunKategori != "")
            {
                bg.Open();
                SqlCommand guncel = new SqlCommand("insert into FiyatListesi(urunIsim, fiyat, kategori, stokKategori) values(@urunIsim, @fiyat, @kategori, @stokKategori)", bg);
                guncel.Parameters.AddWithValue("@urunIsim", yeniUrunAdi);
                guncel.Parameters.AddWithValue("@fiyat", yeniUrunFiyat);
                guncel.Parameters.AddWithValue("@kategori", yeniUrunKategori);
                guncel.Parameters.AddWithValue("@stokKategori", yeniUrunStokKategori);
                guncel.ExecuteNonQuery();
                bg.Close();

                if (yeniUrunKategori == "İçecek")
                {
                    bg.Open();
                    guncel = new SqlCommand("alter table IcecekStok add " + yeniUrunAdi + " int", bg);
                    guncel.ExecuteNonQuery();
                    bg.Close();

                    bg.Open();
                    guncel = new SqlCommand("update IcecekStok set " + yeniUrunAdi + "=0", bg);
                    guncel.ExecuteNonQuery();
                    bg.Close();
                }

                string kategoriSecim = "";
                kategoriSecim = cmbBxKategori.Text;
                Listele(kategoriSecim);
                txtBxUrunAdi.Text = "";
                txtBxUrunFiyati.Text = "";
                cmbBxKategori.Text = "";
                cmbBxStokKategori.Text = "";
            }
            else
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!!");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            AyarlarAna anasayfa = new AyarlarAna();
            anasayfa.Show();
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

        private void cmbBxUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxKategori.Text == "İçecek")
            {

            }
        }
    }
}
