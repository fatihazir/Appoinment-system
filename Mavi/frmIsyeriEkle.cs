using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavi
{
    public partial class frmIsyeriEkle : Form
    {
        public frmIsyeriEkle()
        {
            InitializeComponent();
        }
        IsyeriIslemleri isyeriIslemleri = new IsyeriIslemleri();
        KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
        IsyeriRaporlari isyeriRaporlari = new IsyeriRaporlari();
        KullaniciRaporlari kullaniciRaporlari = new KullaniciRaporlari();
        
        
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
           Zamanlayici.Start();
            
        }

        private void btnIsyeriEkle_Click(object sender, EventArgs e)
        {
            int isyeriSahibiId = Convert.ToInt32(txtKullanıcıId.Text);
            string isyeriAdi = txtIsyeriAdi.Text;
            string isyeriAdresi = txtIsyeriAdres.Text;
            int isyeriKategori = cmbBoxKategori.SelectedIndex;
            decimal isyeriTelNo = Convert.ToDecimal(txtIsyeriTel.Text);

            isyeriIslemleri.IsyeriEkle(isyeriAdi, isyeriTelNo, isyeriAdresi, isyeriKategori, isyeriSahibiId);

            MessageBox.Show(isyeriAdi + " " + "Adlı işyeri sahibinin bazı kritik özelliklerini güncellemelisiniz.");

            isyeriRaporlari.IsyeriListeleYoneticisiz(dgvYoneticisizIsyerleri);
            
        }

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.55;
            }
            else
            {
                Zamanlayici.Stop();
                this.Close();
            }
        }

        private void frmIsyeriEkle_Load(object sender, EventArgs e)
        {
            kullaniciRaporlari.BasvuranlariListele(dgvBasvurular);
            
        }

        private void btnYetkiAta_Click(object sender, EventArgs e)
        {
            int isyeriSahibiId = Convert.ToInt32(txtKullanıcıId.Text);
            kullaniciIslemleri.YoneticiAktiflestir(isyeriSahibiId);
        }
    }
}
