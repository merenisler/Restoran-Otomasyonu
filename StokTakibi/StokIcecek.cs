using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon1.StokTakibi
{
    public partial class StokIcecek : Form
    {
        public StokIcecek()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";

        static List<string> GetColumnNames(string tableName)
        {
            List<string> columnNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = $"SELECT * FROM {tableName} WHERE 1 = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable schemaTable = new DataTable();
                    adapter.FillSchema(schemaTable, SchemaType.Source);

                    foreach (DataColumn column in schemaTable.Columns)
                    {
                        string columnName = column.ColumnName;
                        columnNames.Add(columnName);
                    }
                }
            }

            return columnNames;
        }

        private void StokIcecek_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            int fireToplam = 0;
            int fireToplamIcecek = 0;
            try
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("select sum(fiyat) as fireToplam from Fire", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fireToplam = (int)dr["fireToplam"];
                }
                bg.Close();
            }
            catch (Exception) { }
            lblFire.Text = "Toplam Fire Tutarı: " + fireToplam.ToString();

            try
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("select sum(fiyat) as fireToplam from Fire where kategori='İçecek'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fireToplamIcecek = (int)dr["fireToplam"];
                }
                bg.Close();
            }
            catch (Exception) { }
            lblFireIcecek.Text = "İçecek Fire Tutarı: " + fireToplamIcecek.ToString();

            List<string> columnNames = GetColumnNames("IcecekStok");
            foreach (string columnName in columnNames)
            {
                int stokadet = 0;
                ListViewItem listele = new ListViewItem();
                listele.Text = columnName;
                bg.Open();
                SqlCommand cmd2 = new SqlCommand("select * from IcecekStok", bg);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    stokadet = (int)dr2[columnName];
                }
                bg.Close();
                listele.SubItems.Add(stokadet.ToString());
                lstViewStok.Items.Add(listele);
                cmbBxStokAdi.Items.Add(columnName);
                cmbBxStokAdi2.Items.Add(columnName);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int stokadet = 0;
            string stokad = "";
            if (cmbBxStokAdi.Text != "")
                stokad = cmbBxStokAdi.Text;
            if (txtBxMiktar.Text != "")
                stokadet = Convert.ToInt32(txtBxMiktar.Text);
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("update IcecekStok set " + stokad + "=" + stokad + "+" + stokadet + "", bg);
            cmd.ExecuteNonQuery();
            bg.Close();

            lstViewStok.Items.Clear();

            List<string> columnNames = GetColumnNames("IcecekStok");
            foreach (string columnName in columnNames)
            {
                int stokAdet = 0;
                ListViewItem listele = new ListViewItem();
                listele.Text = columnName;
                bg.Open();
                cmd = new SqlCommand("select * from IcecekStok", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    stokadet = (int)dr[columnName];
                }
                bg.Close();
                listele.SubItems.Add(stokadet.ToString());
                lstViewStok.Items.Add(listele);
            }
            txtBxMiktar.Text = "";
        }

        private void btnDus_Click(object sender, EventArgs e)
        {
            int stokadet = 0;
            string stokad = "";
            if (cmbBxStokAdi2.Text != "")
                stokad = cmbBxStokAdi2.Text;
            if (txtBxMiktar2.Text != "")
                stokadet = Convert.ToInt32(txtBxMiktar2.Text);
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("update IcecekStok set " + stokad + "= " + stokad + " - " + stokadet + "", bg);
            cmd.ExecuteNonQuery();
            bg.Close();

            lstViewStok.Items.Clear();

            List<string> columnNames = GetColumnNames("IcecekStok");
            foreach (string columnName in columnNames)
            {
                int stokAdet = 0;
                ListViewItem listele = new ListViewItem();
                listele.Text = columnName;
                bg.Open();
                cmd = new SqlCommand("select * from IcecekStok", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    stokadet = (int)dr[columnName];
                }
                bg.Close();
                listele.SubItems.Add(stokadet.ToString());
                lstViewStok.Items.Add(listele);
            }
            txtBxMiktar2.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            StokTakibiAna stokTakibiAna = new StokTakibiAna();
            stokTakibiAna.Show();
            this.Hide();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();
            int fire = 0;
            if (txtFire.Text != "")
                fire = Convert.ToInt32(txtFire.Text);
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (fire != 0)
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("insert into Fire(saat, fiyat, kategori) values('" + saat + "', " + fire + ", 'İçecek')", bg);
                cmd.ExecuteNonQuery();
                bg.Close();
            }

            txtFire.Text = "";

            int fireToplam = 0;
            int fireToplamIcecek = 0;
            try
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("select sum(fiyat) as fireToplam from Fire", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fireToplam = (int)dr["fireToplam"];
                }
                bg.Close();
            }
            catch (Exception) { }
            lblFire.Text = "Toplam Fire Tutarı: " + fireToplam.ToString();

            try
            {
                bg.Open();
                SqlCommand cmd = new SqlCommand("select sum(fiyat) as fireToplam from Fire where kategori='İçecek'", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fireToplamIcecek = (int)dr["fireToplam"];
                }
                bg.Close();
            }
            catch (Exception) { }
            lblFireIcecek.Text = "İçecek Fire Tutarı: " + fireToplamIcecek.ToString();
        }

        private void lstViewStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewStok.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    string stokAdi = lstViewStok.SelectedItems[0].SubItems[0].Text;
                    cmbBxStokAdi.Text = stokAdi;
                    cmbBxStokAdi2.Text = stokAdi;
                }
            }
        }
    }
}
