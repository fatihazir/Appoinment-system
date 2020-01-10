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
    public partial class frmIsyeriGuncelle : Form
    {
        public frmIsyeriGuncelle()
        {
            InitializeComponent();
        }
         IsyeriRaporlari isyeriRaporlari = new IsyeriRaporlari();
         IsyeriIslemleri isyeriIslemleri = new IsyeriIslemleri();

        private void frmIsyeriGuncelle_Load(object sender, EventArgs e)
        {
            isyeriRaporlari.IsyeriListeleYoneticili(dgvIsyeriListesi);
        }

        private void btnIsyeriGuncelle_Click(object sender, EventArgs e)
        {
            string isyeriAdi = txtIsyeriAdi.Text;
            decimal isyeriTelNo = Convert.ToDecimal(txtIsyeriTel.Text);
            string isyeriAdresi = txtIsyeriAdres.Text;
            int isyeriKategorisi = cmbBoxKategori.SelectedIndex;
            int isyeriId = Convert.ToInt32(txtIsyeriId.Text);

            isyeriIslemleri.IsyeriGuncelle(isyeriAdi,isyeriTelNo,isyeriAdresi,isyeriKategorisi,isyeriId);
            isyeriRaporlari.IsyeriListeleYoneticili(dgvIsyeriListesi);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Zamanlayici.Start();
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
    }
}
