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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
        
        
        public void LoginFocus()
        {
            this.ActiveControl = txtKullaniciAdi;
        }

       
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

                if (kullaniciIslemleri.GirisDogrulama(kullaniciAdi,sifre))
                {
                    frmAdminPaneli adminPanel = new frmAdminPaneli();
                    adminPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya sifre hatalı.");
                }
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Zamanlayici.Start();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoginFocus();
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
                Application.Exit();
                
            }
        }
    }
}
