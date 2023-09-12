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

namespace PizzaciSon1.Siparis
{
    public partial class Adres : Form
    {
        public Adres()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";
        public static string adres;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            adres = txtBxAdres.Text;
            SiparisAna.paketServisAdres = txtBxAdres.Text;

            string kayitliAdres = "";
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand komut = new SqlCommand("select * from KayitliMusteriler where telefon='" + SiparisAna.paketServisTelefon + "'", bg);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kayitliAdres = (string)dr["adres"];
            }
            bg.Close();
            if (kayitliAdres != "")
            {
                if (kayitliAdres != txtBxAdres.Text)
                {
                    bg.Open();
                    string sql = "update KayitliMusteriler set adres=@adres where telefon='" + SiparisAna.paketServisTelefon + "'";
                    SqlCommand cmd = new SqlCommand(sql, bg);
                    cmd.Parameters.AddWithValue("@adres", txtBxAdres.Text);
                    cmd.ExecuteNonQuery();
                    bg.Close();
                    MessageBox.Show("Adres Güncellendi");
                }
            }
            else
            {
                MessageBox.Show("Adres Eklendi");
            }
            this.Hide();
        }

        private void Adres_Load(object sender, EventArgs e)
        {
            txtBxAdres.Text = SiparisAna.paketServisAdres;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
