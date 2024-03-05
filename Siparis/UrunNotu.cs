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
    public partial class UrunNotu : Form
    {
        private SiparisAna siparisAna;

        public UrunNotu(SiparisAna siparisAna)
        {
            InitializeComponent();
            this.siparisAna = siparisAna;
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        


        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] ozellikler = new string[10];
            foreach (DataGridViewRow row in gridViewOzellikler.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Secim"] as DataGridViewCheckBoxCell;

                // CheckBox seçiliyse, satırı dataGridView2'ye ekle
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    string ozellik = "";
                    ozellik = ((string)row.Cells[1].Value);
                    ozellikler[i] = ozellik+", ";
                    row.Cells[0].Value = false;
                }
                i++;
            }
            string ozellikk = "";
            for (int j = 0; j < ozellikler.Length; j++)
            {
                ozellikk += ozellikler[j];
            }
            SiparisAna siparisAna = new SiparisAna();
            //SiparisAna.OzellikEkle(ozellikk);
            MessageBox.Show(ozellikk);
            MessageBox.Show(SiparisAna.index.ToString());
            this.Hide();
        }

        private void UrunNotu_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from Ozellikler", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                gridViewOzellikler.Rows.Add(false, dr["ozellikIsmi"]);
            }
            bg.Close();
            gridViewOzellikler.Columns["Ozellik"].ReadOnly = true;


        }
    }
}
