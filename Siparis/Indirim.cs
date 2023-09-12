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
    public partial class Indirim : Form
    {
        public Indirim()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";
        public static int tutar = 0;

        private void Indirim_Load(object sender, EventArgs e)
        {
            txtBxToplamTutar.Text = SiparisAna.toplamTutar.ToString();
            txtBxToplamTutar.Enabled = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int indirimYuzdesi = 0;
            try
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from IndirimKodu where IndirimKodu='" + txtBxIndırımKodu.Text + "'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    indirimYuzdesi = (int)dr["IndirimYuzdesi"];
                }
                bg.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli İndirim Kodu Değil!");
            }
            int toplamTutar = Convert.ToInt32(txtBxToplamTutar.Text);
            toplamTutar = toplamTutar - ((toplamTutar * indirimYuzdesi) / 100);
            txtBxIndırımlıTutar.Text = toplamTutar.ToString();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            SiparisAna.toplamTutar = Convert.ToInt32(txtBxIndırımlıTutar.Text);
            this.Hide();
        }
    }
}
