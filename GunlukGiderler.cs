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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PizzaciSon1
{
    public partial class GunlukGiderler : Form
    {
        public GunlukGiderler()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";
        string seciliPersonelAd = "";
        int seciliPersonelUcret = 0;
        int seciliMarketGider = 0;
        int seciliMutfakGider = 0;
        bool marketMutfakSecildiMi = false;
        bool personelSecildiMi = false;

        private void GunlukGiderler_Load(object sender, EventArgs e)
        {
            string personelAd = "";
            int personelUcret = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from PersonelGider", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                personelAd = (string)dr["personelAdSoyad"];
                personelUcret = (int)dr["personelUcret"];
                ListViewItem item = new ListViewItem();
                item.Text = personelAd;
                item.SubItems.Add(personelUcret.ToString());
                lstViewPersonel.Items.Add(item);
            }
            bg.Close();

            int marketGider = 0;
            int mutfakGider = 0;
            bg.Open();
            cmd = new SqlCommand("select * from MarketMutfakGider", bg);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                marketGider = (int)dr["marketGider"];
                mutfakGider = (int)dr["mutfakGider"];
                ListViewItem item = new ListViewItem();
                item.Text = marketGider.ToString();
                item.SubItems.Add(mutfakGider.ToString());
                lstViewMarketMutfak.Items.Add(item);
            }
            bg.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void txtBxPesonelAd_Click(object sender, EventArgs e)
        {
            txtBxPesonelAd.Text = "";
            txtBxPesonelAd.ForeColor = Color.Black;
        }

        private void txtBxPesonelFiyat_Click(object sender, EventArgs e)
        {
            txtBxPesonelFiyat.Text = "";
            txtBxPesonelFiyat.ForeColor = Color.Black;
        }

        private void txtBxPesonelFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBxMarket_Click(object sender, EventArgs e)
        {
            txtBxMarket.Text = "";
            txtBxMarket.ForeColor = Color.Black;
        }

        private void txtBxMarket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBxMutfak_Click(object sender, EventArgs e)
        {
            txtBxMutfak.Text = "";
            txtBxMutfak.ForeColor = Color.Black;
        }

        private void txtBxMutfak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            string personelAd = "";
            int personelUcret = 0;

            if (txtBxPesonelAd.Text != "" && txtBxPesonelAd.Text != "Personel Adı")
            {
                personelAd = txtBxPesonelAd.Text;
                if (txtBxPesonelFiyat.Text != "" && txtBxPesonelFiyat.Text != "Ücret")
                {
                    personelUcret = Convert.ToInt32(txtBxPesonelFiyat.Text);
                    bg.Open();
                    string kayit = "insert into PersonelGider(personelAdSoyad, personelUcret) values (@personelAdSoyad, @personelUcret)";
                    SqlCommand komut = new SqlCommand(kayit, bg);
                    komut.Parameters.AddWithValue("@personelAdSoyad", personelAd);
                    komut.Parameters.AddWithValue("@personelUcret", personelUcret);
                    komut.ExecuteNonQuery();
                    bg.Close();

                    txtBxPesonelAd.Text = "";
                    txtBxPesonelFiyat.Text = "";
                }
                else
                    MessageBox.Show("PersonelÜcretini Giriniz!!!");
            }
            else
                MessageBox.Show("Personel Adını Giriniz!!!");

            lstViewPersonel.Items.Clear();

            string personelad = "";
            int personelucret = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from PersonelGider", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                personelad = (string)dr["personelAdSoyad"];
                personelucret = (int)dr["personelUcret"];
                ListViewItem item = new ListViewItem();
                item.Text = personelad;
                item.SubItems.Add(personelucret.ToString());
                lstViewPersonel.Items.Add(item);
            }
            bg.Close();
        }

        private void btnMarketMutfak_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int market = 0;
            int mutfak = 0;
            if (txtBxMarket.Text != "" && txtBxMarket.Text != "Market")
            {
                market = Convert.ToInt32(txtBxMarket.Text);
                txtBxMarket.Text = "";
            }
            if (txtBxMutfak.Text != "" && txtBxMutfak.Text != "Mutfak")
            {
                mutfak = Convert.ToInt32(txtBxMutfak.Text);
                txtBxMutfak.Text = "";
            }

            bg.Open();
            string kayit = "insert into MarketMutfakGider(marketGider, mutfakGider) values (@marketGider, @mutfakGider)";
            SqlCommand komut = new SqlCommand(kayit, bg);
            komut.Parameters.AddWithValue("@marketGider", market);
            komut.Parameters.AddWithValue("@mutfakGider", mutfak);
            komut.ExecuteNonQuery();
            bg.Close();

            lstViewMarketMutfak.Items.Clear();

            int marketGider = 0;
            int mutfakGider = 0;
            bg.Open();
            komut = new SqlCommand("select * from MarketMutfakGider", bg);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                marketGider = (int)dr["marketGider"];
                mutfakGider = (int)dr["mutfakGider"];
                ListViewItem item = new ListViewItem();
                item.Text = marketGider.ToString();
                item.SubItems.Add(mutfakGider.ToString());
                lstViewMarketMutfak.Items.Add(item);
            }
            bg.Close();
        }

        private void lstViewPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliMarketGider = 0;
            seciliMutfakGider = 0;
            marketMutfakSecildiMi = false;
            personelSecildiMi = true;
            string items = "";
            if (lstViewPersonel.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    items = lstViewPersonel.SelectedItems[0].SubItems[i].Text.ToString();
                    if (i == 0)
                        seciliPersonelAd = items;
                    if (i == 1)
                        seciliPersonelUcret = Convert.ToInt32(items);
                }
            }
        }

        private void lstViewMarketMutfak_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliPersonelAd = "";
            seciliPersonelUcret = 0;
            marketMutfakSecildiMi = true;
            personelSecildiMi = false;
            string items = "";
            if (lstViewMarketMutfak.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    items = lstViewMarketMutfak.SelectedItems[0].SubItems[i].Text.ToString();
                    if (i == 0)
                        seciliMarketGider = Convert.ToInt32(items);
                    if (i == 1)
                        seciliMutfakGider = Convert.ToInt32(items);
                }
            }
        }

        private void btnMarketMutfakKaldir_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            if (marketMutfakSecildiMi == true)
            {
                bg.Open();
                string kayit = "delete from MarketMutfakGider where marketGider=" + seciliMarketGider + " and mutfakGider=" + seciliMutfakGider + "";
                SqlCommand komut = new SqlCommand(kayit, bg);
                komut.ExecuteNonQuery();
                bg.Close();

                lstViewMarketMutfak.Items.Clear();

                int marketGider = 0;
                int mutfakGider = 0;
                bg.Open();
                komut = new SqlCommand("select * from MarketMutfakGider", bg);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    marketGider = (int)dr["marketGider"];
                    mutfakGider = (int)dr["mutfakGider"];
                    ListViewItem item = new ListViewItem();
                    item.Text = marketGider.ToString();
                    item.SubItems.Add(mutfakGider.ToString());
                    lstViewMarketMutfak.Items.Add(item);
                }
                bg.Close();
            }
        }

        private void btnPersonelKaldir_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (personelSecildiMi == true)
            {
                bg.Open();
                string kayit = "delete from PersonelGider where personelAdSoyad='" + seciliPersonelAd + "' and personelUcret=" + seciliPersonelUcret + "";
                SqlCommand komut = new SqlCommand(kayit, bg);
                komut.ExecuteNonQuery();
                bg.Close();

                lstViewPersonel.Items.Clear();

                string personelad = "";
                int personelucret = 0;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from PersonelGider", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    personelad = (string)dr["personelAdSoyad"];
                    personelucret = (int)dr["personelUcret"];
                    ListViewItem item = new ListViewItem();
                    item.Text = personelad;
                    item.SubItems.Add(personelucret.ToString());
                    lstViewPersonel.Items.Add(item);
                }
                bg.Close();
            }
        }
    }
}
