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
    public partial class Indırım : Form
    {
        public Indırım()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        public static string indirimKodu = "";
        public static string sonTarih = "";
        public static int id = 0;
        public static int indirimOrani = 0;

        public void Listele()
        {
            int ID = 0;
            lstViewIndırımKodları.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from IndirimKodu order by Id", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ID++;
                ListViewItem listele = new ListViewItem();
                listele.Text = oku["IndirimKodu"].ToString();
                listele.SubItems.Add(oku["IndirimOrani"].ToString());
                listele.SubItems.Add(oku["SonKullanmaTarihi"].ToString());
                listele.SubItems.Add(oku["Id"].ToString());
                lstViewIndırımKodları.Items.Add(listele);
            }
            bg.Close();
            txtBxId.Text = (ID + 1).ToString();
        }

        private void Indırım_Load(object sender, EventArgs e)
        {
            txtBxId.Enabled = false;
            txtBxId2.Enabled = false;
            Listele();
        }

        private void lstViewIndırımKodları_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if (lstViewIndırımKodları.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    items = lstViewIndırımKodları.SelectedItems[0].SubItems[i].Text;
                    if (i == 0)
                        indirimKodu = items;
                    if (i == 1)
                        indirimOrani = Convert.ToInt32(items);
                    if (i == 2)
                        sonTarih = items;
                    if (i == 3)
                        id = Convert.ToInt32(items);
                }
            }
            txtBxId2.Text = id.ToString();
            txtBxIndirimOrani2.Text = indirimOrani.ToString();
            txtBxIndırımKodu2.Text = indirimKodu;
            sonKullanmaTarihi2.Text = sonTarih;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id2 = Convert.ToInt32(txtBxId.Text);
            int indirimOrani2 = Convert.ToInt32(txtBxIndirimOrani.Text);
            string indirimKodu = txtBxIndırımKodu.Text;
            string sonTarih2 = sonKullanmaTarihi.Text;
            char ayrac = '.';
            string[] tarih = sonTarih2.Split(ayrac);
            string yıl = tarih[2];
            string ay = tarih[1];
            string gun = tarih[0];
            string tarihİlk = yıl + "-" + ay + "-" + gun;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand guncel = new SqlCommand("insert into IndirimKodu(IndirimKodu, IndirimOrani, SonKullanmaTarihi) values(@p1, @p2, @p3)", bg);
            guncel.Parameters.AddWithValue("@p1", indirimKodu);
            guncel.Parameters.AddWithValue("@p2", indirimOrani2);
            guncel.Parameters.AddWithValue("@p3", tarihİlk);
            guncel.ExecuteNonQuery();
            bg.Close();

            Listele();

            txtBxIndirimOrani.Text = "";
            txtBxIndırımKodu.Text = "";
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int id2 = Convert.ToInt32(txtBxId2.Text);
            int indirimOrani2 = Convert.ToInt32(txtBxIndirimOrani2.Text);
            string indirimKodu = txtBxIndırımKodu2.Text;
            string sonTarih2 = sonKullanmaTarihi2.Text;
            char ayrac = '.';
            string[] tarih = sonTarih2.Split(ayrac);
            string yıl = tarih[2];
            string ay = tarih[1];
            string gun = tarih[0];
            string tarihİlk = yıl + "-" + ay + "-" + gun;

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand guncel = new SqlCommand("update IndirimKodu set IndirimKodu=@p1, SonKullanmaTarihi=@p2, IndirimOrani=@p3 where Id=@p4", bg);
            guncel.Parameters.AddWithValue("@p1", indirimKodu);
            guncel.Parameters.AddWithValue("@p2", tarihİlk);
            guncel.Parameters.AddWithValue("@p3", indirimOrani2);
            guncel.Parameters.AddWithValue("@p4", id2);
            guncel.ExecuteNonQuery();
            bg.Close();

            Listele();

            txtBxId2.Text = "";
            txtBxIndirimOrani2.Text = "";
            txtBxIndırımKodu2.Text = "";
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand guncel = new SqlCommand("delete IndirimKodu where Id=@Id", bg);
            guncel.Parameters.AddWithValue("@Id", id);
            guncel.ExecuteNonQuery();
            bg.Close();

            Listele();

            txtBxId2.Text = "";
            txtBxIndirimOrani2.Text = "";
            txtBxIndırımKodu2.Text = "";
        }


        private void txtBxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtBxId2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            AyarlarAna ayarlarAna = new AyarlarAna();
            ayarlarAna.Show();
            this.Hide();
        }
    }
}
