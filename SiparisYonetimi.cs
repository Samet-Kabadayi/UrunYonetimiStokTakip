using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetimiStokTakip.Entities;
using UrunYonetimStokTakip.BL;

namespace UrunYonetimiStokTakip
{
    public partial class SiparisYonetimi : Form
    {
        public SiparisYonetimi()
        {
            InitializeComponent();
        }
        SiparisManager manager = new SiparisManager();
        MusteriManager musteri = new MusteriManager();
        UrunManager urun = new UrunManager();
        void Yukle()
        {
            dgwSiparisler.DataSource = manager.GetAll();
            cbMusteriler.DataSource = musteri.GetAll();
            cbMusteriler.DisplayMember = "Adi";
            cbMusteriler.ValueMember = "Id";
            cbUrunler.DataSource = urun.GetAll();
            cbUrunler.DisplayMember = "UrunAdi";
            cbUrunler.ValueMember = "Id";
             
            
        }
        void Temizle()
        {
            txtSiparis.Text = String.Empty;
            lblid.Text = "0";
        }
        private void SiparisYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        
        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Siparis
                    {
                        MusteriId = Convert.ToInt32(cbMusteriler.SelectedValue),
                        SiparisNo = txtSiparis.Text,
                        SiparisTarihi = dtpSiparisTarihi.Value,
                        UrunId = Convert.ToInt32(cbUrunler.SelectedValue),
                    }
                    );
                if (sonuc>0)
                {
                    Yukle();
                    Temizle();
                    MessageBox.Show("Kayıt Eklendi!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt eklenemedi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text !="0")
                {
                   var sonuc = manager.Update(
                   new Siparis
                   {
                       Id = Convert.ToInt32(lblid.Text),
                       MusteriId = Convert.ToInt32(cbMusteriler.SelectedValue),
                       SiparisNo = txtSiparis.Text,
                       SiparisTarihi = dtpSiparisTarihi.Value,
                       UrunId = Convert.ToInt32(cbUrunler.SelectedValue),
                   }
                   );
                    if (sonuc > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kayıt güncellendi!");
                    }
                }
                else MessageBox.Show("Listeden güncellenecek kaydı seçiniz!");
                    
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt güncellenemedi");
            }
        }

        private void dgwSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var siparis = manager.Get(Convert.ToInt32(dgwSiparisler.CurrentRow.Cells[0].Value));
                txtSiparis.Text = siparis.SiparisNo;
                cbMusteriler.SelectedValue = siparis.MusteriId;
                cbUrunler.SelectedValue = siparis.UrunId;
                dtpSiparisTarihi.Value = siparis.SiparisTarihi;
                lblid.Text = dgwSiparisler.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt getirilemedi");;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek kaydı seçiniz");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblid.Text));
                    if (sonuc >0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kayıt Silindi");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Silinemedi!");;
            }
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            this.Close();
            markaYonetimi.ShowDialog();
        }
    }
}
