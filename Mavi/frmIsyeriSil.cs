using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavi
{
    public partial class frmIsyeriSil : Form
    {
        public frmIsyeriSil()
        {
            InitializeComponent();
        }
        IsyeriIslemleri isyeriIslemleri = new IsyeriIslemleri();
        IsyeriRaporlari isyeriRaporlari = new IsyeriRaporlari();
        KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();

        
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Zamanlayici.Start();
        }

        private void frmIsyeriSil_Load(object sender, EventArgs e)
        {
            
            isyeriRaporlari.IsyeriListeleYoneticili(dgvIsyeriListesi);
        }

        private void btnIsyeriSil_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Sistem stabilitesi için önce soruları silmelisiniz. Sorulari sildiniz mi?"
                , "Soruları sildim, devam etmek istiyorum.", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {
                int silinecekIsyeriId = Convert.ToInt32(txtSilinecekIsyeriId.Text);
                isyeriIslemleri.IsyeriSil(silinecekIsyeriId, dgvIsyeriListesi);
                isyeriRaporlari.IsyeriListeleYoneticili(dgvIsyeriListesi);

            }
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

        private void btnSorulariSil_Click(object sender, EventArgs e)
        {
            int silinecekIsyeriId = Convert.ToInt32(txtSilinecekIsyeriId.Text);
            isyeriIslemleri.IsyeriSorulariSil(silinecekIsyeriId);
        }
    }
}
