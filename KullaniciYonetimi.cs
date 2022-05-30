using System;
using System.Windows.Forms;
using UrunYonetimiStokTakip.Entities;
using UrunYonetimStokTakip.BL;

namespace UrunYonetimiStokTakip
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManagaer manager = new KullaniciManagaer();
        

        void Yukle()
        {
            dgwKullanicilar.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtAd.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtKullaniciAdi.Text = String.Empty;
            txtSifre.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            cbMarkaDurum.Checked = false;
            lblid.Text = "0";
        }
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
                {
                    MessageBox.Show("Lütfen işaretli alanları doldurunuz!");
                }
                else
                {
                    var sonuc = manager.Add(
                    new Kullanici
                    {
                        Adi = txtAd.Text,
                        Mail = txtEmail.Text,
                        Sifre = txtSifre.Text,
                        Aktif = cbMarkaDurum.Checked,
                        Soyad = txtSoyad.Text,
                    }
                    );
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Eklendi");
                    }
                }
                        
            }
            catch (Exception HataEkle)
            {

                MessageBox.Show("Hata oluştu! Kayıt eklenemedi");
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

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Update(
                    new Kullanici
                    {
                        Id = int.Parse(lblid.Text),
                        Adi = txtAd.Text,
                        Mail = txtEmail.Text,
                        Sifre = txtSifre.Text,
                        Aktif = cbMarkaDurum.Checked,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        Soyad = txtSoyad.Text
                    }
                    );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Güncellendi");
                }
            }
            catch (Exception HataEkle)
            {

                MessageBox.Show("Hata oluştu! Kayıt Güncellenemedi");
            }
        }

        private void katagoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KatagoriYonetimi katagoriYonetimi = new KatagoriYonetimi();
            this.Close();
            katagoriYonetimi.ShowDialog();
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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgwKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblid.Text = dgwKullanicilar.CurrentRow.Cells[0].Value.ToString();
                txtKullaniciAdi.Text = dgwKullanicilar.CurrentRow.Cells[1].Value.ToString();
                txtSifre.Text = dgwKullanicilar.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgwKullanicilar.CurrentRow.Cells[3].Value.ToString();
                txtAd.Text = dgwKullanicilar.CurrentRow.Cells[4].Value.ToString();
                txtSoyad.Text = dgwKullanicilar.CurrentRow.Cells[5].Value.ToString();
                cbMarkaDurum.Checked = Convert.ToBoolean(dgwKullanicilar.CurrentRow.Cells[6].Value);
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata atanırken hata oluştu!");
            }
        }
    }
}
