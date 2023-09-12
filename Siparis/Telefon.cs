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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzaciSon1.Siparis
{
    public partial class Telefon : Form
    {
        public Telefon()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";
        public static int telefonNo;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string kayitliAdres = "";
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from KayitliMusteriler where telefon='" + txtBxTelefon.Text + "'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kayitliAdres = (string)dr["adres"];
            }
            bg.Close();

            SiparisAna.paketServisTelefon = txtBxTelefon.Text;
            if (kayitliAdres != "")
            {
                SiparisAna.paketServisAdres = kayitliAdres;
                MessageBox.Show("Telefon Eklendi");
                MessageBox.Show("Adres Eklendi");
            }
            else
            {
                MessageBox.Show("Telefon Eklendi");
            }

            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamları ve kontrol tuşlarını kabul et
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Sadece 11 karaktere izin ver
            if (txtBxTelefon.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Telefon_Load(object sender, EventArgs e)
        {

        }
    }
}
