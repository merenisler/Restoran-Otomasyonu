using PizzaciSon1.Class;
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

namespace PizzaciSon1.Raporlar
{
    public partial class PaketServis : Form
    {
        public PaketServis()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        string items = "";
        int toplamTutar = 0;
        string adres = "";
        string telefon = "";
        int adisyonNo = 0;


        private void PaketServis_Load(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from PaketServis order by paketServisNo", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = oku["paketServisNo"].ToString();
                listele.SubItems.Add(oku["adisyonAcilisSaat"].ToString());
                listele.SubItems.Add(oku["adisyonKapanisSaat"].ToString());
                listele.SubItems.Add(oku["adres"].ToString());
                listele.SubItems.Add(oku["telefon"].ToString());
                listele.SubItems.Add(oku["tutar"].ToString());
                listele.SubItems.Add(oku["adisyonIcerik"].ToString());
                lstViewPaketServis.Items.Add(listele);
            }
            bg.Close();
        }

        private void lstViewPaketServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewSiparis.Items.Clear();
            txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
            txtBxAdres.Text = "";
            txtBxTelefon.Text = "";

            lstViewPaketServis.FullRowSelect = true;

            if (lstViewPaketServis.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    items = lstViewPaketServis.SelectedItems[0].SubItems[6].Text.ToString();
                    toplamTutar = Convert.ToInt32(lstViewPaketServis.SelectedItems[0].SubItems[5].Text);
                    adres = lstViewPaketServis.SelectedItems[0].SubItems[3].Text;
                    telefon = lstViewPaketServis.SelectedItems[0].SubItems[4].Text;
                    adisyonNo = Convert.ToInt32(lstViewPaketServis.SelectedItems[0].SubItems[0].Text);
                }
            }
            VeriTabanı.lstViewGetirAdisyon(lstViewSiparis, items);
            txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;
            txtBxAdres.Text = adres;
            txtBxTelefon.Text = telefon;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int aralik = 30;
            int adisyonAralik = 0;
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                // Pen kalem = new Pen(Color.Black);
                e.Graphics.DrawString($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);

                font = new Font("Arial", 15, FontStyle.Bold);
                Font baslik = new Font("Arial", 27, FontStyle.Bold);
                Font cizgi = new Font("Arial", 12);
                Font font2 = new Font("Arial", 16);
                Font font3 = new Font("Arial", 14, FontStyle.Bold);
                e.Graphics.DrawString("Üniversite Pizza Paket Fişi", baslik, firca, 100, 100);
                e.Graphics.DrawString("Adisyon No: " + adisyonNo.ToString(), font, firca, 100, 175);
                e.Graphics.DrawString(("Telefon No: " + telefon), font, firca, 100, 207);
                e.Graphics.DrawString(("Adres: " + adres), font, firca, 100, 239);
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, 285);
                font = new Font("Arial", 16, FontStyle.Bold);
                e.Graphics.DrawString(("Fiş Notu: "), font, firca, 100, 310);
                for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                {
                    font = new Font("Arial", 16);

                    string[] dizi = new string[lstViewSiparis.Items.Count];
                    dizi[i] = lstViewSiparis.Items[i].SubItems[1].Text + " - " + lstViewSiparis.Items[i].SubItems[2].Text + " -" +
                        " " + lstViewSiparis.Items[i].SubItems[3].Text;

                    if (i == 0)
                        e.Graphics.DrawString(dizi[i], font2, firca, 100, 370);
                    else
                        e.Graphics.DrawString(dizi[i], font2, firca, 100, (370 + (aralik * i)));
                    
                    adisyonAralik = 370 + (aralik * i);
                }
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, (adisyonAralik + aralik));
                e.Graphics.DrawString(("Toplam Ücret: " + toplamTutar), font3, firca, 200, (adisyonAralik + aralik + 20));

            }
            catch (Exception)
            { }
        }

        private void txtBxAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtBxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            RaporlarAna raporlarAna = new RaporlarAna();
            raporlarAna.Show();
            this.Hide();
        }
    }
}
