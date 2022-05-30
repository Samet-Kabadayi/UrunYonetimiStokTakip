using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimiStokTakip
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnkatagori_Click(object sender, EventArgs e)
        {
            KatagoriYonetimi katagoriyonetimi = new KatagoriYonetimi();
            katagoriyonetimi.ShowDialog();
        }

        private void btnkullanici_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciyonetimi = new KullaniciYonetimi();
            kullaniciyonetimi.ShowDialog();
        }

        private void btnmarkayonetimi_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markayonetimi = new MarkaYonetimi();
            markayonetimi.ShowDialog();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            musteriYonetimi.ShowDialog();
        }

        private void btnSiparisYonetimi_Click(object sender, EventArgs e)
        {
            SiparisYonetimi siparisYonetimi = new SiparisYonetimi();
            siparisYonetimi.ShowDialog();
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            urunYonetimi.ShowDialog();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
