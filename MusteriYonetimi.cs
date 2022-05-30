using System;
using System.Windows.Forms;
using UrunYonetimiStokTakip.Entities;
using UrunYonetimStokTakip.BL;

namespace UrunYonetimiStokTakip
{
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        MusteriManager manager = new MusteriManager();
        void Yukle()
        {
            dgwMusteriler.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtAd.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            txtmail.Text = String.Empty;
            txtadres.Text = String.Empty;
            txttelefon.Text = String.Empty;
            lblid.Text = "0";
        }
        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
                {
                    MessageBox.Show("İşaretli alan(lar) boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (lblid.Text == "0")
                    {
                        MessageBox.Show("Listeden güncellenecek kaydı seçiniz!");
                    }
                    else
                    {
                        var sonuc = manager.Update(
                        new Musteri
                    {
                        Adi = txtAd.Text,
                        Soyadi = txtSoyad.Text,
                        Mail = txtmail.Text,
                        Adress = txtadres.Text,
                        Telefon = txttelefon.Text,
                        Id= Convert.ToInt32(lblid.Text),

                    }
                    );
                        if (sonuc > 0)
                        {
                            Temizle();
                            Yukle();
                            MessageBox.Show("Müşteri Güncellendi");
                        }
                    }

                }

            }
            catch (Exception HataEkle)
            {

                MessageBox.Show("Hata oluştu! Müşteri Güncellenemedi eklenemedi");
            }
        }
        private void btnekle_Click(object sender, EventArgs e)

        {
            try
            {
                if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
                {
                    MessageBox.Show("İşaretli alan(lar) boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var sonuc = manager.Add(
                   new Musteri
                   {
                       Adi = txtAd.Text,
                       Soyadi = txtSoyad.Text,
                       Mail = txtmail.Text,
                       Adress = txtadres.Text,
                       Telefon = txttelefon.Text,


                   }
                   );
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Müşteri Eklendi");
                    }
                }

            }
            catch (Exception HataEkle)
            {

                MessageBox.Show("Hata oluştu! Müşteri Eklenemedi eklenemedi");
            }
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek veriyi seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblid.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinemedi");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");;
            }
        }

        private void dgwMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblid.Text = dgwMusteriler.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dgwMusteriler.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dgwMusteriler.CurrentRow.Cells[2].Value.ToString();
                txtmail.Text = dgwMusteriler.CurrentRow.Cells[3].Value.ToString();
                txttelefon.Text = dgwMusteriler.CurrentRow.Cells[4].Value.ToString();
                
                
            }
            catch (Exception)
            {

                MessageBox.Show("Veri seçilemedi!");;
            }
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            this.Close();
            markaYonetimi.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Close();
            kullaniciYonetimi.ShowDialog();
        }

        private void katagoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KatagoriYonetimi katagoriYonetimi =new KatagoriYonetimi();
            this.Close();
            katagoriYonetimi.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi =new UrunYonetimi();
            this.Close();
            urunYonetimi.ShowDialog();
        }
    }
}




