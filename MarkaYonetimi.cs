using System;
using System.Windows.Forms;
using UrunYonetimiStokTakip.Entities;
using UrunYonetimStokTakip.BL;

namespace UrunYonetimiStokTakip
{
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }
        MarkaManager manager = new MarkaManager();
        void Yukle()
        {
            dgwMarkalar.DataSource = manager.GetAll();
        }
        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        void Temizle()
        {
            txtMarkaAciklama.Text = String.Empty;
            txtMarkaAd.Text = String.Empty;
            cbMarkaDurum.Checked = false;
            lbleklenmetarihi.Text = String.Empty;
            lblid.Text = "0";
        }

        private void dgwMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgwMarkalar.CurrentRow.Cells[0].Value.ToString();
            txtMarkaAd.Text = dgwMarkalar.CurrentRow.Cells[1].Value.ToString();
            txtMarkaAciklama.Text = dgwMarkalar.CurrentRow.Cells[2].Value.ToString();
            lbleklenmetarihi.Text = dgwMarkalar.CurrentRow.Cells[3].Value.ToString();
            cbMarkaDurum.Checked = Convert.ToBoolean(dgwMarkalar.CurrentRow.Cells[4].Value);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);
            if (id>0)
            {
                int islemsonucu = manager.Update(
                    new Marka
                    {
                        Id = id,
                        MarkaAdi = txtMarkaAd.Text,
                        Aciklama = txtMarkaAciklama.Text,
                        Aktif = cbMarkaDurum.Checked,
                        EklenmeTarihi = Convert.ToDateTime(lbleklenmetarihi.Text),
                        
                    }
                    );
                if (islemsonucu > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Güncellendi");
                }
                else MessageBox.Show("Kayıt Güncellenemedi");
            }
            else MessageBox.Show("Listeden güncellenecek kaydı seçiniz!");
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            int islemsonucu = manager.Add(
                new Marka
                {
                    MarkaAdi = txtMarkaAd.Text,
                    Aciklama = txtMarkaAciklama.Text,
                    Aktif = cbMarkaDurum.Checked,
                    EklenmeTarihi = DateTime.Now,

                }
                );
            if (islemsonucu>0)
            {
                Temizle();
                Yukle();
                MessageBox.Show("Kayıt Eklendi");
            }
            else MessageBox.Show("Kayıt Eklenemedi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);
            if (id > 0)
            {
                if (MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                { 
                    int islemsonucu = manager.Delete(id);
                    if (islemsonucu > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi");
                    }
                    else MessageBox.Show("Kayıt Silinemedi");
                }
            }
            else MessageBox.Show("Listeden silinecek kaydı seçiniz!");
        }

        private void katagoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KatagoriYonetimi katagoriYonetimi = new KatagoriYonetimi();
            this.Close();
            katagoriYonetimi.ShowDialog();
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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

            
                
            
