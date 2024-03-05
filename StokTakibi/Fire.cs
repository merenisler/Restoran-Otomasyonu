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

namespace PizzaciSon1.StokTakibi
{
    public partial class Fire : Form
    {
        public Fire()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";


        private void Fire_Load(object sender, EventArgs e)
        {
            int fireToplam = 0;
            int fireToplamYiyecek = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            try
            {
                bg.Open();
                SqlCommand oku = new SqlCommand("select sum(fiyat) as fireToplam from Fire", bg);
                SqlDataReader dr = oku.ExecuteReader();
                while (dr.Read())
                {
                    fireToplam = (int)dr["fireToplam"];
                }
                bg.Close();
            }
            catch (Exception)
            { }

            lblFire.Text = "Toplam Fire Tutarı: " + fireToplam.ToString();
            try
            {
                bg.Open();
                SqlCommand oku = new SqlCommand("select sum(fiyat) as fireToplam from Fire where kategori='Yiyecek'", bg);
                SqlDataReader dr = oku.ExecuteReader();
                while (dr.Read())
                {
                    fireToplamYiyecek = (int)dr["fireToplam"];
                }
                bg.Close();
            }
            catch (Exception)
            { }

            lblFireYiyecek.Text = "Yiyecek Fire Tutarı: " + fireToplamYiyecek.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();
            int fire = 0;
            if (txtBxMiktar.Text != "")
                fire = Convert.ToInt32(txtBxMiktar.Text);
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (fire != 0)
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("insert into Fire(saat, fiyat, kategori) values('" + saat + "', " + fire + ", 'Yiyecek')", bg);
                cmd.ExecuteNonQuery();
                bg.Close();
            }

            txtBxMiktar.Text = "";

            int fireToplam = 0;
            int fireToplamYiyecek = 0;
            try
            {
                bg.Open();
                SqlCommand oku = new SqlCommand("select sum(fiyat) as fireToplam from Fire", bg);
                SqlDataReader dr = oku.ExecuteReader();
                while (dr.Read())
                {
                    fireToplam = (int)dr["fireToplam"];
                }
                bg.Close();
            }
            catch (Exception)
            { }
            lblFire.Text = "Toplam Fire Tutarı: " + fireToplam.ToString();
            try
            {
                bg.Open();
                SqlCommand oku = new SqlCommand("select sum(fiyat) as fireToplam from Fire where kategori='Yiyecek'", bg);
                SqlDataReader dr = oku.ExecuteReader();
                while (dr.Read())
                {
                    fireToplamYiyecek = (int)dr["fireToplam"];
                }
                bg.Close();
            }
            catch (Exception)
            { }

            lblFireYiyecek.Text = "Yiyecek Fire Tutarı: " + fireToplamYiyecek.ToString();
            txtBxMiktar.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
