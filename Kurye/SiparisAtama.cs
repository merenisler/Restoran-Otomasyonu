using PizzaciSon1.Class;
using PizzaciSon1.Kurye;
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

namespace PizzaciSon1
{
    public partial class SiparisAtama : Form
    {
        public SiparisAtama()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";
        public static int siparisId = 0;
        public static int kuryeId = 0;

        public void Listele()
        {
            lstView.Items.Clear();
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select P.SiparisId as SiparisId, P.KuryeId as KuryeId, S.adisyonKapanisSaat as adisyonKapanisSaat, P.YolaCikisSaat as YolaCikisSaat, P.GelisSaat as GelisSaat, P.Durum as Durum from PaketAtama P inner join PaketServis S on S.paketServisNo=P.SiparisId order by S.paketServisNo", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem listView = new ListViewItem();
                listView.Text = ((int)dr["SiparisId"]).ToString();
                listView.SubItems.Add(((int)dr["KuryeId"]).ToString());
                listView.SubItems.Add(((TimeSpan)dr["adisyonKapanisSaat"]).ToString());
                listView.SubItems.Add(((TimeSpan)dr["YolaCikisSaat"]).ToString());
                listView.SubItems.Add(((TimeSpan)dr["GelisSaat"]).ToString());
                listView.SubItems.Add((string)dr["Durum"]);
                lstView.Items.Add(listView);
            }
            bg.Close();
        }

        private void SiparisAtama_Load(object sender, EventArgs e)
        {
            Listele();

            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from KuryePaket where YoldaMi=0", bg);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBxKuryeAd.Items.Add((string)dr["AdSoyad"]);
            }
            bg.Close();
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if (lstView.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    items = lstView.SelectedItems[0].SubItems[i].Text;
                    if (i == 0)
                        siparisId = Convert.ToInt32(items);
                    if (i == 1)
                        kuryeId = Convert.ToInt32(items);
                }
            }

            string adisyonIcerik = "";
            int toplamUcret = 0;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from PaketServis where paketServisNo=" + siparisId + "", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                adisyonIcerik = (string)oku["adisyonIcerik"];
                toplamUcret = (int)oku["tutar"];
            }
            bg.Close();

            //bg.Open();
            //cmd = new SqlCommand("select * from KuryeListesi where KuryeId=" + kuryeId + "", bg);
            //oku = cmd.ExecuteReader();
            //while (oku.Read())
            //{
            //    cmbBxKuryeAd.Text=(string)oku["AdSoyad"];
            //}
            //bg.Close();

            lstViewSiparis.Items.Clear();
            VeriTabanı.lstViewGetirAdisyon(lstViewSiparis, adisyonIcerik);
            txtBxToplamTutar.Text = "Toplam Tutar: " + toplamUcret.ToString();
        }

        private void btnKuryeAta_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (cmbBxKuryeAd.Text != "" && siparisId != 0)
            {
                int kuryeId = 0;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from KuryeListesi where AdSoyad='" + cmbBxKuryeAd.Text + "'", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    kuryeId = (int)oku["KuryeId"];
                }
                bg.Close();

                if (kuryeId != 0)
                {
                    int kurye = 0;
                    bg.Open();
                    cmd = new SqlCommand("select * from PaketAtama where SiparisId=" + siparisId + "", bg);
                    oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        kurye = (int)oku["KuryeId"];
                    }
                    bg.Close();
                    if (kurye == 0)
                    {
                        string YolaCikisSaat = DateTime.Now.ToLongTimeString();
                        bg.Open();
                        cmd = new SqlCommand("update PaketAtama set KuryeId=@KuryeId, YolaCikisSaat=@YolaCikisSaat, Durum=@Durum where SiparisId=@SiparisId", bg);
                        cmd.Parameters.AddWithValue("@KuryeId", kuryeId);
                        cmd.Parameters.AddWithValue("@YolaCikisSaat", YolaCikisSaat);
                        cmd.Parameters.AddWithValue("@Durum", "Yola Çıktı");
                        cmd.Parameters.AddWithValue("@SiparisId", siparisId);
                        cmd.ExecuteNonQuery();
                        bg.Close();

                        bg.Open();
                        cmd = new SqlCommand("update KuryePaket set YoldaMi=1 where KuryeId=@KuryeId", bg);
                        cmd.Parameters.AddWithValue("@KuryeId", kuryeId);
                        cmd.ExecuteNonQuery();
                        bg.Close();
                        MessageBox.Show("Kurye ataması başarıyla yapıldı.");

                        Listele();

                        cmbBxKuryeAd.Items.Clear();

                        bg.Open();
                        cmd = new SqlCommand("select * from KuryePaket where YoldaMi=0", bg);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cmbBxKuryeAd.Items.Add((string)dr["AdSoyad"]);
                        }
                        bg.Close();

                        cmbBxKuryeAd.Text = "";
                        lstViewSiparis.Items.Clear();
                        txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Kurye Değişikliğimi Yapmak İstiyorsunuz?", "Uyarı!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            int Kurye = 0;
                            bg.Open();
                            cmd = new SqlCommand("select * from PaketAtama where SiparisId=" + siparisId + "", bg);
                            oku = cmd.ExecuteReader();
                            while (oku.Read())
                            {
                                Kurye = (int)oku["KuryeId"];
                            }
                            bg.Close();
                            bg.Open();
                            cmd = new SqlCommand("update KuryePaket set YoldaMi=0 where KuryeId=@KuryeId", bg);
                            cmd.Parameters.AddWithValue("@KuryeId", Kurye);
                            cmd.ExecuteNonQuery();
                            bg.Close();

                            string YolaCikisSaat = DateTime.Now.ToLongTimeString();
                            bg.Open();
                            cmd = new SqlCommand("update PaketAtama set KuryeId=@KuryeId, YolaCikisSaat=@YolaCikisSaat, Durum=@Durum where SiparisId=@SiparisId", bg);
                            cmd.Parameters.AddWithValue("@KuryeId", kuryeId);
                            cmd.Parameters.AddWithValue("@YolaCikisSaat", YolaCikisSaat);
                            cmd.Parameters.AddWithValue("@Durum", "Yola Çıktı");
                            cmd.Parameters.AddWithValue("@SiparisId", siparisId);
                            cmd.ExecuteNonQuery();
                            bg.Close();

                            bg.Open();
                            cmd = new SqlCommand("update KuryePaket set YoldaMi=1 where KuryeId=@KuryeId", bg);
                            cmd.Parameters.AddWithValue("@KuryeId", kuryeId);
                            cmd.ExecuteNonQuery();
                            bg.Close();
                            MessageBox.Show("Kurye ataması başarıyla yapıldı.");

                            Listele();

                            cmbBxKuryeAd.Items.Clear();

                            bg.Open();
                            cmd = new SqlCommand("select * from KuryePaket where YoldaMi=0", bg);
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                cmbBxKuryeAd.Items.Add((string)dr["AdSoyad"]);
                            }
                            bg.Close();

                            cmbBxKuryeAd.Text = "";
                            lstViewSiparis.Items.Clear();
                            txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kurye ataması yapılamadı!");
                    cmbBxKuryeAd.Text = "";
                }
            }
            else
                MessageBox.Show("Kurye ataması yapılamadı!");
        }

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            if (siparisId != 0 && kuryeId != 0)
            {
                string Gelis = DateTime.Now.ToLongTimeString();
                bg.Open();
                SqlCommand cmd = new SqlCommand("update PaketAtama set GelisSaat=@GelisSaat, Durum=@Durum where SiparisId=@SiparisId and KuryeId=@KuryeId", bg);
                cmd.Parameters.AddWithValue("@GelisSaat", Gelis);
                cmd.Parameters.AddWithValue("@Durum", "Teslim Edildi");
                cmd.Parameters.AddWithValue("@SiparisId", siparisId);
                cmd.Parameters.AddWithValue("@KuryeId", kuryeId);
                cmd.ExecuteNonQuery();
                bg.Close();

                bg.Open();
                cmd = new SqlCommand("update KuryePaket set YoldaMi=0 where KuryeId=@KuryeId", bg);
                cmd.Parameters.AddWithValue("@KuryeId", kuryeId);
                cmd.ExecuteNonQuery();
                bg.Close();
                MessageBox.Show("Sipariş başarıyla teslim edildi.");

                Listele();

                cmbBxKuryeAd.Items.Clear();
                bg.Open();
                cmd = new SqlCommand("select * from KuryePaket where YoldaMi=0", bg);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBxKuryeAd.Items.Add((string)dr["AdSoyad"]);
                }
                bg.Close();

                cmbBxKuryeAd.Text = "";
                lstViewSiparis.Items.Clear();
                txtBxToplamTutar.Text = "Toplam Tutar: 0.00";
            }
            else
                MessageBox.Show("Sipariş teslimi onaylanmadı!");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        private void btnKuryeIstatistik_Click(object sender, EventArgs e)
        {
            KuryeIstatistik kuryeIstatistik = new KuryeIstatistik();
            kuryeIstatistik.Show();
            this.Hide();
        }
        private void btnKuryeEkleCikar_Click(object sender, EventArgs e)
        {
            KuryeEkleCikar kuryeEkleCikar = new KuryeEkleCikar();
            kuryeEkleCikar.Show();
            this.Hide();
        }

    }
}
