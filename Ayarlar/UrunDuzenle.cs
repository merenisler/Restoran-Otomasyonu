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

namespace PizzaciSon1.Ayarlar
{
    public partial class UrunDuzenle : Form
    {
        public UrunDuzenle()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";
        string secilenUrunAdi = "";
        int secilenUrunFiyat = 0;
        string secilenUrunKategori = "";
        int secilenUrunId = 0;



        private void btnCikis_Click(object sender, EventArgs e)
        {
            AyarlarAna anasayfa = new AyarlarAna();
            anasayfa.Show();
            this.Hide();
        }

        private void btnMasaEkleKaldir_Click(object sender, EventArgs e)
        {
            MasaEkleKaldir masaEkleKaldir = new MasaEkleKaldir();
            masaEkleKaldir.Show();
            this.Hide();
        }

        private void btnUrunEkleKaldir_Click(object sender, EventArgs e)
        {
            UrunEkleKaldir urunEkleKaldir = new UrunEkleKaldir();
            urunEkleKaldir.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstViewUrunler.Items.Clear();
            string kategoriSecim = "";
            kategoriSecim = cmbBxKategori.Text;
            SqlConnection bg = new SqlConnection(ConnectionString);
            int adisyonAdet = 1;
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
            txtBxUrunAdi.Text = secilenUrunAdi;
            txtBxUrunFiyati.Text = secilenUrunFiyat.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand guncel = new SqlCommand("update FiyatListesi set urunIsim=@urunIsim, fiyat=@fiyat where urunId=@urunId", bg);
            guncel.Parameters.AddWithValue("@urunIsim", txtBxUrunAdi.Text);
            guncel.Parameters.AddWithValue("@fiyat", Convert.ToInt32(txtBxUrunFiyati.Text));
            guncel.Parameters.AddWithValue("@urunId", secilenUrunId);
            guncel.ExecuteNonQuery();
            bg.Close();

            lstViewUrunler.Items.Clear();
            string kategoriSecim = "";
            kategoriSecim = cmbBxKategori.Text;
            int adisyonAdet = 1;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from FiyatListesi where kategori='" + secilenUrunKategori + "' order by urunId", bg);
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

            txtBxUrunAdi.Text = "";
            txtBxUrunFiyati.Text = "";
        }
    }
}
