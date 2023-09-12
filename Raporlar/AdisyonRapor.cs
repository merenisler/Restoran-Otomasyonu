using PizzaciSon1.Class;
using PizzaciSon1.Masalar;
using PizzaciSon1.Raporlar;
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
using TheArtOfDev.HtmlRenderer.Adapters;

namespace PizzaciSon1.Siparis
{
    public partial class AdisyonRapor : Form
    {
        public AdisyonRapor()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";
        string items = "";
        int toplamTutar = 0;
        public static string islem = "";
        string odemeDurumu = "";
        public static bool siparisSecildiMi = false;
        public static int adisyonNo = 0;

        private void AdisyonRapor_Load(object sender, EventArgs e)
        {
            Anasayfa.pesinSatis = false;
            siparisSecildiMi = false;
            SqlConnection bg = new SqlConnection(ConnectionString);
            int adisyonNo = 1;
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from GunlukAdisyon order by adisyonNo", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();

                listele.Text = oku["adisyonNo"].ToString();
                listele.SubItems.Add(oku["adisyonAcilisSaat"].ToString());
                listele.SubItems.Add(oku["adisyonKapanisSaat"].ToString());
                listele.SubItems.Add(oku["odemeDurumu"].ToString());
                listele.SubItems.Add(oku["islem"].ToString());
                listele.SubItems.Add(oku["tutar"].ToString());
                listele.SubItems.Add(oku["adisyonIcerik"].ToString());
                lstViewAdisyonRapor.Items.Add(listele);
            }
            bg.Close();
        }

        private void lstViewAdisyonRapor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewSiparis.Items.Clear();
            txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
            lstViewAdisyonRapor.FullRowSelect = true;

            if (lstViewAdisyonRapor.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    adisyonNo = Convert.ToInt32(lstViewAdisyonRapor.SelectedItems[0].SubItems[0].Text);
                    items = lstViewAdisyonRapor.SelectedItems[0].SubItems[6].Text;
                    toplamTutar = Convert.ToInt32(lstViewAdisyonRapor.SelectedItems[0].SubItems[5].Text);
                    islem = lstViewAdisyonRapor.SelectedItems[0].SubItems[4].Text;
                    odemeDurumu = lstViewAdisyonRapor.SelectedItems[0].SubItems[3].Text;
                }
            }
            VeriTabanı.lstViewGetirAdisyon(lstViewSiparis, items);
            txtBxToplamTutar.Text = "Toplam Tutar: " + toplamTutar;
            if (odemeDurumu!= "Fiş İptal")
            {
                siparisSecildiMi = true;
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int adisyonAralik = 0;
            int aralik = 30;
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                // Pen kalem = new Pen(Color.Black);
                e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);

                font = new Font("Arial", 15, FontStyle.Bold);
                Font cizgi = new Font("Arial", 12);
                e.Graphics.DrawString("İşlem", font, firca, 80, 70);
                e.Graphics.DrawString("-------------", cizgi, firca, 76, 84);
                e.Graphics.DrawString("Ödeme Durumu", font, firca, 195, 70);
                e.Graphics.DrawString("----------------------------", cizgi, firca, 192, 84);
                e.Graphics.DrawString("Adisyon No", font, firca, 380, 70);
                e.Graphics.DrawString("---------------------", cizgi, firca, 377, 84);

                font = new Font("Arial", 15);
                e.Graphics.DrawString(islem, font, firca, 75, 102);
                e.Graphics.DrawString((odemeDurumu).ToString(), font, firca, 235, 102);
                e.Graphics.DrawString((adisyonNo).ToString(), font, firca, 430, 102);

                for (int i = 0; i < lstViewSiparis.Items.Count; i++)
                {
                    font = new Font("Arial", 16);

                    string[] dizi = new string[lstViewSiparis.Items.Count];
                    dizi[i] = lstViewSiparis.Items[i].SubItems[1].Text + " - " + lstViewSiparis.Items[i].SubItems[2].Text + " -" +
                        " " + lstViewSiparis.Items[i].SubItems[3].Text;
                    if (i == 0)
                        e.Graphics.DrawString(dizi[i], font, firca, 100, 148);
                    else
                        e.Graphics.DrawString(dizi[i], font, firca, 100, (148 + (aralik * i)));
                    adisyonAralik = 148 + (aralik * i);
                }
                font = new Font("Arial", 16, FontStyle.Bold);
                e.Graphics.DrawString("------------------------------------------------", cizgi, firca, 100, (adisyonAralik + aralik + 5));

            }
            catch (Exception) { }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            siparisSecildiMi = false;
            RaporlarAna raporlarAna = new RaporlarAna();
            raporlarAna.Show();
            this.Hide();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (siparisSecildiMi==true)
            {
                SiparisAna siparisAna = new SiparisAna();
                siparisAna.Show();
                this.Hide();
            }
        }
    }
}
