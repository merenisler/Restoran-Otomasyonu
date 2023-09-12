using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon1.StokTakibi
{
    public partial class StokTakibiAna : Form
    {
        public StokTakibiAna()
        {
            InitializeComponent();
        }

        private void btnYiyecekStok_Click(object sender, EventArgs e)
        {
            Fire fire = new Fire();
            fire.Show();
        }

        private void btnIcecekStok_Click(object sender, EventArgs e)
        {
            StokIcecek stokIcecek = new StokIcecek();
            stokIcecek.Show();
            this.Hide();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
