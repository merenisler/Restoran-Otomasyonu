using PizzaciSon1.Class;
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
    public partial class AyarlarGiris : Form
    {
        public AyarlarGiris()
        {
            InitializeComponent();
        }

        public static string pozisyon = "";
        public static string girisSaat = "";
        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";

        private bool GirisKontrol(int password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Guvenlik WHERE sifre = @sifre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sifre", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Numarator.Numara("1", txtBxSifre);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Numarator.Numara("2", txtBxSifre);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Numarator.Numara("3", txtBxSifre);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Numarator.Numara("4", txtBxSifre);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Numarator.Numara("5", txtBxSifre);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Numarator.Numara("6", txtBxSifre);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Numarator.Numara("7", txtBxSifre);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Numarator.Numara("8", txtBxSifre);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Numarator.Numara("9", txtBxSifre);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Numarator.Numara("0", txtBxSifre);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Numarator.Sil(txtBxSifre);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int girilenSifre = Convert.ToInt32(txtBxSifre.Text);

            if (GirisKontrol(girilenSifre))
            {
                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from Guvenlik where sifre=" + girilenSifre + "", bg);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        pozisyon = (string)dr["pozisyon"];
                    }
                }
                catch (Exception)
                {

                }
                bg.Close();
                girisSaat = DateTime.Now.ToShortTimeString();
                AyarlarAna ayarlarAna = new AyarlarAna();
                ayarlarAna.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Geçersiz Şifre!");
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
