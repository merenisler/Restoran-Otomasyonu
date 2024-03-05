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

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        public static int telefonNo;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);

            string tlf = "";
            string adres = "";
            if (txtBxTelefon.Text != "")
                tlf = txtBxTelefon.Text;
            if (txtBxAdres.Text != "")
                adres = txtBxAdres.Text;

            if (tlf!="" && adres!="")
            {
                int musteriKayitliMi = 0;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select count(*) as varMi from KayitliMusteriler where telefon='" + tlf + "'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { musteriKayitliMi = (int)dr["varMi"]; }
                bg.Close();
                if (musteriKayitliMi == 0)
                {
                    bg.Open();
                    cmd = new SqlCommand("insert into KayitliMusteriler(telefon, adres) values (@telefon, @adres)", bg);
                    cmd.Parameters.AddWithValue("@telefon", tlf);
                    cmd.Parameters.AddWithValue("@adres", adres);
                    cmd.ExecuteNonQuery();
                    bg.Close();
                    MessageBox.Show("Yeni Müşteri Kaydı Yapıldı.");
                }
                else
                {
                    bg.Open();
                    cmd = new SqlCommand("update KayitliMusteriler set adres=@adres where telefon='" + tlf + "'", bg);
                    cmd.Parameters.AddWithValue("@adres", adres);
                    cmd.ExecuteNonQuery();
                    bg.Close();
                    MessageBox.Show("Müşteri Kaydı Yapıldı.");
                }
                SiparisAna.paketServisTelefon = tlf;
                SiparisAna.paketServisAdres = adres;
                this.Hide();
            }
            else
                MessageBox.Show("Lütfen Alanları Boş Bırakmayınız!");
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

            if (e.KeyChar == (char)Keys.Enter)
            {
                string tlf = "";
                string kayitliAdres = "";
                if (txtBxTelefon.Text!="")
                    tlf = txtBxTelefon.Text;
                
                if (tlf!="")
                {
                    SqlConnection bg = new SqlConnection(ConnectionString);
                    bg.Open();
                    SqlCommand cmd = new SqlCommand("select * from KayitliMusteriler where telefon='" + tlf + "'", bg);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        kayitliAdres = (string)dr["adres"];
                    }
                    bg.Close();
                    if (kayitliAdres!="")
                    {
                        MessageBox.Show("Müşterinin Adresi Eklendi");
                        txtBxAdres.Text = kayitliAdres;
                    }
                }
                e.Handled = true;
            }
        }
    }
}
