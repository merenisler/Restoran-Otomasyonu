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
    public partial class Tahsilat : Form
    {
        public Tahsilat()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";
        public static int toplam;
        public static int veriOkuma = 0;

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Tahsilat_Load(object sender, EventArgs e)
        {
            txtBxToplamTutar.Text = SiparisAna.toplamTutar.ToString();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (veriOkuma == 0)
            {
                toplam = Convert.ToInt32(txtBxToplamTutar.Text);
                veriOkuma++;
            }
            int odenen = Convert.ToInt32(txtBxOdenen.Text);
            int kalan = toplam - odenen;
            if (kalan < 0)
            {
                kalan = kalan * -1;
                txtBxBahsis.Text = kalan.ToString();
                txtBxKalan.Text = "0";
            }
            else
                txtBxKalan.Text = kalan.ToString();
            txtBxOdenen.Text = "";
            toplam = kalan;

            string Saat = DateTime.Now.ToLongTimeString();
            if (txtBxBahsis.Text != "")
            {
                int bahsis = Convert.ToInt32(txtBxBahsis.Text);

                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("insert into Bahsis(saat, tutar) values('" + Saat + "', " + bahsis + ")", bg);
                cmd.ExecuteNonQuery();
                bg.Close();
            }

        }

        private void txtBxToplamTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
