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

namespace PizzaciSon1.Raporlar
{
    public partial class RaporlarAna : Form
    {
        public RaporlarAna()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnZRapor_Click(object sender, EventArgs e)
        {
            ZRapor zRapor = new ZRapor();
            zRapor.Show();
            this.Hide();
        }

        private void btnAdisyonRapor_Click(object sender, EventArgs e)
        {
            AdisyonRapor adisyonRapor = new AdisyonRapor();
            adisyonRapor.Show();
            this.Hide();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            PaketServis paketServis = new PaketServis();
            paketServis.Show();
            this.Hide();
        }

        private void btnBahşiş_Click(object sender, EventArgs e)
        {
            int toplamBahsis = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            try
            {
                bg.Open();
                SqlCommand komut = new SqlCommand("select SUM(tutar) as toplamBahsis from Bahsis", bg);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    toplamBahsis = (int)dr["toplamBahsis"];
                }
                bg.Close();
            }
            catch (Exception) { }

            MessageBox.Show("Bugünkü Bahşiş Miktarı " + toplamBahsis + "TL");
        }
    }
}
