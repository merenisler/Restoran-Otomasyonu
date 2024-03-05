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
    public partial class GunSonu : Form
    {
        public GunSonu()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";


        private void GunSonu_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from GunSonu", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = oku["ikram"].ToString();
                listele.SubItems.Add(oku["yiyecek"].ToString());
                listele.SubItems.Add(oku["icecek"].ToString());
                listele.SubItems.Add(oku["iptalYiyecek"].ToString());
                listele.SubItems.Add(oku["iptalIcecek"].ToString());
                lstViewGunSonu.Items.Add(listele);
            }
            bg.Close();

            bg.Open();
            cmd = new SqlCommand("select * from GunSonuFiyatlar", bg);
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = oku["ikram"].ToString();
                listele.SubItems.Add(oku["yiyecek"].ToString());
                listele.SubItems.Add(oku["icecek"].ToString());
                listele.SubItems.Add(oku["iptalYiyecek"].ToString());
                listele.SubItems.Add(oku["iptalIcecek"].ToString());
                lstViewGunSonuFiyatlar.Items.Add(listele);
            }
            bg.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            RaporlarAna raporlarAna = new RaporlarAna();
            raporlarAna.Show();
            this.Hide();
        }
    }
}
