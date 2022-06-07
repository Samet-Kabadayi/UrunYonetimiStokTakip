using System;
using System.Windows.Forms;
using UrunYonetimiStokTakip.Entities;
using UrunYonetimStokTakip.BL;

namespace UrunYonetimiStokTakip
{
    public partial class KatagoriYonetimi : Form
    {
        public KatagoriYonetimi()
        {
            InitializeComponent();
        }
        KategoriManager manager = new KategoriManager();
        void Yukle()
        {
            dgwKatagoriler.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtKatagoriAd.Text = String.Empty;
            txtKatagoriAciklama.Text = String.Empty;
            cbKatagoriDurum.Checked = false;
            lblTarih.Text = String.Empty;
            lblid.Text = "0";
        }
        private void TxtEklenmeTarihi_Click(object sender, EventArgs e)
        {

        }

        private void KatagoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
               var sonuc = manager.Add(
               new Katagori
               {
                   KatagoriAd = txtKatagoriAd.Text,
                   Aciklama = txtKatagoriAciklama.Text,
                   Aktif = cbKatagoriDurum.Checked,
                   EklenmeTarihi = DateTime.Now,
               }
               );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt eklendi");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata oluştu kayıt eklenemedi!n\\Boş alan bırakmadan tekrar deneyin.");
            }
           
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
               var sonuc = manager.Update(
               new Katagori
               {
                   Id = int.Parse(lblid.Text),
                   KatagoriAd = txtKatagoriAd.Text,
                   Aciklama = txtKatagoriAciklama.Text,
                   Aktif = cbKatagoriDurum.Checked,
                   EklenmeTarihi =Convert.ToDateTime(lblTarih.Text),
               }
               );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Güncellendi");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata oluştu kayıt güncellenemedi!n\\Boş alan bırakmadan tekrar deneyin.");
            }
        }

        private void dgwKatagoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblid.Text = dgwKatagoriler.CurrentRow.Cells[0].Value.ToString();
                txtKatagoriAd.Text = dgwKatagoriler.CurrentRow.Cells[1].Value.ToString();
                txtKatagoriAciklama.Text = dgwKatagoriler.CurrentRow.Cells[2].Value.ToString();
                lblTarih.Text = dgwKatagoriler.CurrentRow.Cells[3].Value.ToString();
                cbKatagoriDurum.Checked = Convert.ToBoolean(dgwKatagoriler.CurrentRow.Cells[4].Value);
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata atanırken hata oluştu!");
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek kaydı seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(int.Parse(lblid.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt silindi");
                    }
                }
                
            }
            catch (Exception Hata)
            {

                MessageBox.Show("Kayıt silinemedi!"); 
            }
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            this.Close();
            markaYonetimi.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            this.Close();
            urunYonetimi.ShowDialog();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Close();
            kullaniciYonetimi.ShowDialog();
        }

        private void müşteriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            this.Close();
            musteriYonetimi.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgwKatagoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
           
