using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon1.Kurye
{
    public partial class KuryeIstatistik : Form
    {
        public KuryeIstatistik()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=DESKTOP-D2537BI\\SQLEXPRESS;Initial Catalog = Pizzacı; Integrated Security = True";

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

        private void btnKuryeEkleCikar_Click(object sender, EventArgs e)
        {
            KuryeEkleCikar kuryeEkleCikar = new KuryeEkleCikar();
            kuryeEkleCikar.Show();
            this.Hide();
        }
    }
}
