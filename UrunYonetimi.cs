using System;
using System.Windows.Forms;
using UrunYonetimiStokTakip.Entities;
using UrunYonetimStokTakip.BL;

namespace UrunYonetimiStokTakip
{
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        UrunManager manager = new UrunManager();
        KategoriManager katagori = new KategoriManager();
        MarkaManager marka = new MarkaManager();
        void Yukle()
        {
            
            dgwUrunler.DataSource = manager.GetAll();
            cbUrunKatagori.DataSource = katagori.GetAll();
            cbUrunMarkasi.DataSource = marka.GetAll();
            dgwUrunler.Columns[2].Visible = false;
            dgwUrunler.Columns[1].Visible = false;
            dgwUrunler.Columns[0].HeaderText = "No";
            dgwUrunler.Columns[3].HeaderText = "Ürün Adı";
            dgwUrunler.Columns[4].HeaderText = "Açıklama";
            dgwUrunler.Columns[5].HeaderText = "Eklenme Tarihi";
            dgwUrunler.Columns[6].HeaderText = "Durum";
            dgwUrunler.Columns[7].HeaderText = "Ürün Fiyatı";
            dgwUrunler.Columns[8].HeaderText = "Kdv";
            dgwUrunler.Columns[9].HeaderText = "Stok Miktarı";
            dgwUrunler.Columns[10].HeaderText = "İskonto";
            dgwUrunler.Columns[11].HeaderText = "Toptan Fiyat";

        }

        void Temizle()
        {
            txtUrunAd.Text = String.Empty;
            txtUrunFiyati.Text = String.Empty;
            txtKdv.Text = String.Empty;
            txtStokMiktari.Text = String.Empty;
            rtbUrunAciklama.Text = String.Empty;
            cbUrunDurum.Checked = false;
            lblid.Text = "0";
            cbUrunKatagori.Text = String.Empty;
            cbUrunMarkasi.Text = String.Empty;
            txtIskonto.Text = String.Empty;
            txtToptanFiyat.Text = String.Empty;
            lblEklenmeTarihi.Text = String.Empty;
        }
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrunFiyati.Text))
            {
                try
                {
                    var sonuc = manager.Add(
                        new Urun
                        {
                            UrunAdi = txtUrunAd.Text,
                            EklenmeTarihi = DateTime.Now,
                            Aktif = cbUrunDurum.Checked,
                            UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                            Kdv = int.Parse(txtKdv.Text),
                            StokMiktari = int.Parse(txtStokMiktari.Text),
                            Aciklama = rtbUrunAciklama.Text,
                            Iskonto = int.Parse(txtIskonto.Text),
                            ToptanFiyat = decimal.Parse(txtToptanFiyat.Text),
                            KatagoriId = int.Parse(cbUrunKatagori.SelectedValue.ToString()),
                            MarkaId = int.Parse(cbUrunMarkasi.SelectedValue.ToString()),
                        }
                        );
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Urun Eklendi!");

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu.Kayıt Eklenemedi! Lüfen tüm alanları doldurup tekrar deneyiniz!");
                }
            }
            else MessageBox.Show("Ürün Fiyatı boş geçilimez");


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
            if (!string.IsNullOrWhiteSpace(txtUrunFiyati.Text))
            {
                try
                {
                    int urunid = Convert.ToInt32(lblid.Text);
                    if (urunid > 0)
                    {
                        var sonuc = manager.Update(
                     new Urun
                     {
                         Id = urunid,
                         UrunAdi = txtUrunAd.Text,
                         UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                         Aciklama = rtbUrunAciklama.Text,
                         Aktif = cbUrunDurum.Checked,
                         EklenmeTarihi =Convert.ToDateTime(lblEklenmeTarihi.Text),
                         Iskonto = int.Parse(txtIskonto.Text),
                         Kdv = int.Parse(txtKdv.Text),
                         StokMiktari = int.Parse(txtStokMiktari.Text),
                         ToptanFiyat = decimal.Parse(txtToptanFiyat.Text),
                         KatagoriId = int.Parse(cbUrunKatagori.SelectedValue.ToString()),
                         MarkaId = int.Parse(cbUrunMarkasi.SelectedValue.ToString()),
                     }
                     );
                        if (sonuc > 0)
                        {
                            Temizle();
                            Yukle();
                            MessageBox.Show("Urun Güncellendi!");

                        }
                    }
                    else MessageBox.Show("Lissteden seçilecek veriyi seçiniz.");

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu.Kayıt Güncellenemedi! Lüfen tüm alanları doldurup tekrar deneyiniz!");
                }
            }
            else MessageBox.Show("Ürün Fiyatı boş geçilimez");
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblid.Text = dgwUrunler.CurrentRow.Cells[0].Value.ToString();
                int urunid = Convert.ToInt32(lblid.Text);
                if (urunid > 0)
                {
                    var urun = manager.Get(urunid);
                    if (urun != null)
                    {
                        txtIskonto.Text = urun.Iskonto.ToString();
                        txtKdv.Text = urun.Kdv.ToString();
                        txtStokMiktari.Text = urun.StokMiktari.ToString();
                        txtUrunAd.Text = urun.UrunAdi;
                        txtUrunFiyati.Text = urun.UrunFiyati.ToString();
                        rtbUrunAciklama.Text = urun.Aciklama;
                        cbUrunDurum.Checked = urun.Aktif;
                        lblEklenmeTarihi.Text = urun.EklenmeTarihi.ToString();
                        cbUrunKatagori.SelectedValue = urun.KatagoriId;
                        cbUrunMarkasi.SelectedValue = urun.MarkaId;
                        txtToptanFiyat.Text = urun.ToptanFiyat.ToString();
                    }
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata kayıt seçilirken hata oluştu!");
            }
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            this.Close();
            markaYonetimi.ShowDialog();
        }

        private void katagoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KatagoriYonetimi katagoriYonetimi = new KatagoriYonetimi();
            this.Close();
            katagoriYonetimi.ShowDialog();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Close();
            kullaniciYonetimi.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
                            
}
                            




