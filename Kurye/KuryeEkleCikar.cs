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

namespace PizzaciSon1.Kurye
{
    public partial class KuryeEkleCikar : Form
    {
        public KuryeEkleCikar()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        public static int kuryeId = 0;

        public void Listele()
        {
            lstViewKuryeler.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from KuryeListesi", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem listView = new ListViewItem();
                listView.Text = ((int)dr["KuryeId"]).ToString();
                listView.SubItems.Add((string)dr["AdSoyad"]);
                listView.SubItems.Add((string)dr["Telefon"]);
                listView.SubItems.Add((string)dr["TCNo"]);
                lstViewKuryeler.Items.Add(listView);
            }
            bg.Close();
        }

        private void KuryeEkleCikar_Load(object sender, EventArgs e)
        {
            Listele();

            SqlConnection bg = new SqlConnection(ConnectionString);
            int adet = 0;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(*) as adet from KuryeListesi", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            { adet = (int)dr["adet"]; }
            bg.Close();
            adet++;
            txtBxId.Text = adet.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adiSoyadi = "", telefon = "", tcNo = "";
            if (txtBxAdiSoyadi.Text != "")
                adiSoyadi = txtBxAdiSoyadi.Text;
            if (txtBxTelefon.Text != "")
                telefon = txtBxTelefon.Text;
            if (txtBxTCNo.Text != "")
                tcNo = txtBxTCNo.Text;

            if (adiSoyadi != "" && telefon != "" && tcNo != "")
            {
                SqlConnection bg = new SqlConnection(ConnectionString);
                bg.Open();
                SqlCommand cmd = new SqlCommand("insert into KuryeListesi(AdSoyad, Telefon, TCNo) values(@AdSoyad, @Telefon, @TCNo)", bg);
                cmd.Parameters.AddWithValue("@AdSoyad", adiSoyadi);
                cmd.Parameters.AddWithValue("@Telefon", telefon);
                cmd.Parameters.AddWithValue("@TCNo", tcNo);
                cmd.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                cmd = new SqlCommand("insert into KuryePaket(AdSoyad, YoldaMi) values(@AdSoyad, 0)", bg);
                cmd.Parameters.AddWithValue("@AdSoyad", adiSoyadi);
                cmd.ExecuteNonQuery();
                bg.Close();

                Listele();

                int adet = 0;
                bg.Open();
                cmd = new SqlCommand("select count(*) as adet from KuryeListesi", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { adet = (int)dr["adet"]; }
                bg.Close();
                adet++;
                txtBxId.Text = adet.ToString();

                txtBxId2.Text = "";
                txtBxAdiSoyadi.Text = "";
                txtBxTelefon.Text = "";
                txtBxTCNo.Text = "";
                txtBxAdiSoyadi2.Text = "";
                txtBxTelefon2.Text = "";
                txtBxTCNo2.Text = "";
            }
            else
                MessageBox.Show("Kurye Eklemesi Yapmadan Önce İlgili Alanları Doldurmanız Gerek!");

        }

        private void lstViewKuryeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string adSoyad = "", telefon = "", tcNo = "";
            string items = "";
            if (lstViewKuryeler.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    items = lstViewKuryeler.SelectedItems[0].SubItems[i].Text;
                    if (i == 0)
                        kuryeId = Convert.ToInt32(items);
                    if (i == 1)
                        adSoyad = items;
                    if (i == 2)
                        telefon = items;
                    if (i == 3)
                        tcNo = items;
                }
            }

            txtBxId2.Text = kuryeId.ToString();
            txtBxAdiSoyadi2.Text = adSoyad;
            txtBxTelefon2.Text = telefon;
            txtBxTCNo2.Text = tcNo;
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("delete KuryeListesi where KuryeId=@KuryeId", bg);
            cmd.Parameters.AddWithValue("@KuryeId", kuryeId);
            cmd.ExecuteNonQuery();
            bg.Close();

            bg.Open();
            cmd = new SqlCommand("delete KuryePaket where KuryeId=@KuryeId", bg);
            cmd.Parameters.AddWithValue("@KuryeId", kuryeId);
            cmd.ExecuteNonQuery();
            bg.Close();

            Listele();

            int adet = 0;
            bg.Open();
            cmd = new SqlCommand("select count(*) as adet from KuryeListesi", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            { adet = (int)dr["adet"]; }
            bg.Close();
            adet++;
            txtBxId.Text = adet.ToString();

            txtBxId2.Text = "";
            txtBxAdiSoyadi.Text = "";
            txtBxTelefon.Text = "";
            txtBxTCNo.Text = "";
            txtBxAdiSoyadi2.Text = "";
            txtBxTelefon2.Text = "";
            txtBxTCNo2.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int id = Convert.ToInt32(txtBxId2.Text);
            string adsoyad = "", telefon = "", tcNo = "";
            if (txtBxAdiSoyadi2.Text!="")
                adsoyad = txtBxAdiSoyadi2.Text;
            if (txtBxTelefon2.Text!="")
                telefon = txtBxTelefon2.Text;
            if (txtBxTCNo2.Text!="")
                tcNo = txtBxTCNo2.Text;

            if (adsoyad!="" && telefon!="" && tcNo!="")
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("update KuryeListesi set AdSoyad=@AdSoyad, Telefon=@Telefon, TCNo=@TCNo where KuryeId=@KuryeId", bg);
                cmd.Parameters.AddWithValue("@AdSoyad", adsoyad);
                cmd.Parameters.AddWithValue("@Telefon", telefon);
                cmd.Parameters.AddWithValue("@TCNo", tcNo);
                cmd.Parameters.AddWithValue("@KuryeId", id);
                cmd.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                cmd = new SqlCommand("update KuryePaket set AdSoyad=@AdSoyad where KuryeId=@KuryeId", bg);
                cmd.Parameters.AddWithValue("@AdSoyad", adsoyad);
                cmd.Parameters.AddWithValue("@KuryeId", id);
                cmd.ExecuteNonQuery();
                bg.Close();
            }

            Listele(); 

            txtBxId2.Text = "";
            txtBxAdiSoyadi.Text = "";
            txtBxTelefon.Text = "";
            txtBxTCNo.Text = "";
            txtBxAdiSoyadi2.Text = "";
            txtBxTelefon2.Text = "";
            txtBxTCNo2.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        private void btnSiparisAtama_Click(object sender, EventArgs e)
        {
            SiparisAtama siparisAtama = new SiparisAtama();
            siparisAtama.Show();
            this.Hide();
        }
        private void btnKuryeIstatistik_Click(object sender, EventArgs e)
        {
            KuryeIstatistik kuryeIstatistik = new KuryeIstatistik();
            kuryeIstatistik.Show();
            this.Hide();
        }
    }
}
