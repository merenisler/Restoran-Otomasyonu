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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PizzaciSon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";

        //public void dinamikMetodIcecek(object sender, EventArgs e)
        //{
        //    SqlConnection bg = new SqlConnection(ConnectionString);

        //    int adet = 0;
        //    bg.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) as adet FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'IcecekStok';", bg);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        adet = (int)dr["adet"];
        //    }
        //    bg.Close();

        //    string[] stokAdi = new string[adet];

        //    bg.Open();
        //    cmd = new SqlCommand("select * from IcecekStok", bg);
        //    dr = cmd.ExecuteReader();
        //    if (dr.HasRows)
        //    {
        //        DataTable schemaTable = dr.GetSchemaTable();
        //        for (int j = 0; j < adet; j++)
        //        {
        //            stokAdi[j] = (string)schemaTable.Rows[j]["ColumnName"];
        //        }
        //    }
        //    bg.Close();


        //    int urunId = 0;
        //    string urunIsim = "";
        //    string stokKategori = "";
        //    int fiyat = 0;

        //    for (int i = 1; i <= adet; i++)
        //    {
        //        if ((sender as System.Windows.Forms.Button).TabIndex == i)
        //        {
        //            bg.Open();
        //            cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY urunId) indexer, * from FiyatListesi where kategori='İçecek') tablo where tablo.indexer=" + i + "", bg);
        //            dr = cmd.ExecuteReader();
        //            if (dr.Read())
        //            { urunId = ((int)dr["urunId"]); }
        //            bg.Close();

        //            bg.Open();
        //            cmd = new SqlCommand("Select * From FiyatListesi where kategori='İçecek' and urunId=" + urunId + "", bg);
        //            dr = cmd.ExecuteReader();
        //            if (dr.Read())
        //            {
        //                urunIsim = ((string)dr["urunIsim"]);
        //                stokKategori = (string)dr["stokKategori"];
        //                fiyat = (int)dr["fiyat"];
        //            }
        //            bg.Close();

        //            if (txtUrunAdet.Text != "")
        //            {
        //                int Adet = Convert.ToInt32(txtUrunAdet.Text);
        //                fiyat = Adet * fiyat;
        //                bg.Open();
        //                string sql = "update GunSonuFiyatlar set icecek=icecek+" + fiyat + "";
        //                cmd = new SqlCommand(sql, bg);
        //                cmd.ExecuteNonQuery();
        //                bg.Close();

        //            }
        //            else
        //            {
        //                bg.Open();
        //                string sql = "update GunSonuFiyatlar set icecek=icecek+" + fiyat + "";
        //                cmd = new SqlCommand(sql, bg);
        //                cmd.ExecuteNonQuery();
        //                bg.Close();
        //            }

        //            if (txtUrunAdet.Text != "")
        //            {
        //                int Adet = Convert.ToInt32(txtUrunAdet.Text);
        //                bg.Open();
        //                string sql = "update GunSonu set icecek=icecek+" + Adet + "";
        //                cmd = new SqlCommand(sql, bg);
        //                cmd.ExecuteNonQuery();
        //                bg.Close();

        //            }
        //            else
        //            {
        //                bg.Open();
        //                string sql = "update GunSonu set icecek=icecek+1";
        //                cmd = new SqlCommand(sql, bg);
        //                cmd.ExecuteNonQuery();
        //                bg.Close();
        //            }

        //            string miktar = txtUrunAdet.Text;
        //            int miktarInt = 0;

        //            if (txtUrunAdet.Text != "")
        //            {
        //                miktarInt = Convert.ToInt32(miktar);
        //                toplamTutar = toplamTutar + fiyat;
        //                ListViewItem listele = new ListViewItem();
        //                listele.Text = ("0");
        //                listele.SubItems.Add((miktarInt + " ").ToString());
        //                listele.SubItems.Add(urunIsim.ToString());
        //                listele.SubItems.Add(fiyat.ToString());
        //                listele.SubItems.Add(stokKategori);
        //                listele.SubItems.Add("İçecek");
        //                lstViewSiparis.Items.Add(listele);
        //                txtUrunAdet.Text = "";

        //                for (int j = 0; j < adet; j++)
        //                {
        //                    if (stokAdi[j] == stokKategori)
        //                    {
        //                        bg.Open();
        //                        string sql = "update IcecekStok set " + stokAdi[j] + "=" + stokAdi[j] + "-" + miktarInt + "";
        //                        cmd = new SqlCommand(sql, bg);
        //                        cmd.ExecuteNonQuery();
        //                        bg.Close();
        //                    }
        //                }

        //            }
        //            else
        //            {
        //                toplamTutar = toplamTutar + fiyat;
        //                ListViewItem listele = new ListViewItem();
        //                listele.Text = ("0");
        //                listele.SubItems.Add("1 ");
        //                listele.SubItems.Add(urunIsim.ToString());
        //                listele.SubItems.Add(fiyat.ToString());
        //                listele.SubItems.Add(stokKategori);
        //                listele.SubItems.Add("İçecek");
        //                lstViewSiparis.Items.Add(listele);
        //                txtUrunAdet.Text = "";

        //                for (int j = 0; j < adet; j++)
        //                {
        //                    if (stokAdi[j] == stokKategori)
        //                    {
        //                        bg.Open();
        //                        string sql = "update IcecekStok set " + stokAdi[j] + "=" + stokAdi[j] + "-1";
        //                        cmd = new SqlCommand(sql, bg);
        //                        cmd.ExecuteNonQuery();
        //                        bg.Close();
        //                    }
        //                }
        //            }


        //        }
        //    }
        //}


        private void Form1_Load(object sender, EventArgs e)
        {
            //İçecekButton
            int urunAdet2 = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select count(urunId) from FiyatListesi where kategori='İçecek'", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            { urunAdet2 = (int)dr[0]; }
            bg.Close();

            List<string> urunIsim2 = new List<string>();
            List<int> urunFiyat2 = new List<int>();
            List<int> stokAdet = new List<int>();
            int urunId2 = 0;

            for (int i = 1; i <= urunAdet2; i++)
            {
                bg.Open();
                cmd = new SqlCommand("Select tablo.* From (SELECT ROW_NUMBER() OVER (ORDER BY urunId) indexer, * from FiyatListesi where kategori='İçecek') tablo where tablo.indexer=" + i + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { urunId2 = ((int)dr["urunId"]); }
                bg.Close();
                bg.Open();
                cmd = new SqlCommand("Select * From FiyatListesi where kategori='İçecek' and urunId=" + urunId2 + "", bg);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    urunIsim2.Add((string)dr["urunIsim"]);
                    urunFiyat2.Add((int)dr["fiyat"]);
                }
                bg.Close();
            }

            bg.Open();
            cmd = new SqlCommand("select * from IcecekStok", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    stokAdet.Add((int)dr[i]);
                }
            }
            bg.Close();

            for (int i = 1; i <= urunAdet2; i++)
            {
                System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
                btn2.Name = "btn" + i.ToString();
                btn2.Size = new Size(150, 122);
                btn2.Text = (urunIsim2[(i - 1)] + " " + urunFiyat2[(i - 1)] + ".00");
                btn2.Margin = new Padding(0);
                btn2.Font = new Font("Microsoft JhengHei", 12, FontStyle.Bold);
                btn2.BackColor = Color.Blue;
                btn2.ForeColor = Color.White;
                btn2.FlatStyle = FlatStyle.Flat;
                flowLayoutPanel1.Controls.Add(btn2);
                //btn2.Click += new EventHandler(dinamikMetodIcecek);
                btn2.TabIndex = i;

                if (stokAdet[i-1]==0)
                {
                    btn2.Enabled = false;
                }
            }



            string[] stokAd = new string[urunAdet2];





            bg.Open();
            cmd = new SqlCommand("select * from IcecekStok", bg);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    stokAdet.Add((int)dr[i]);
                }
            }
            bg.Close();

            bg.Open();
            cmd = new SqlCommand("select * from IcecekStok", bg);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable schemaTable = dr.GetSchemaTable();
                for (int j = 0; j < urunAdet2; j++)
                {
                    stokAd[j] = (string)schemaTable.Rows[j]["ColumnName"];
                }
            }
            bg.Close();
        }
    }
}
