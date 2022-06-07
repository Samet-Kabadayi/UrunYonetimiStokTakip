using System;
using System.Windows.Forms;
using UrunYonetimStokTakip.BL;

namespace UrunYonetimiStokTakip
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        KullaniciManagaer manger = new KullaniciManagaer();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez!");
            }
            else
            {
                var kullanici = manger.Find(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.Aktif == true);
                if (kullanici != null)
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
                else MessageBox.Show("Giriş Başarısız!");
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
            

