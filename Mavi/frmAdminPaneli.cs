using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Mavi
{
    public partial class frmAdminPaneli : Form
    {
        public frmAdminPaneli()
        {
            InitializeComponent();
        }
        public void FormAc(Form AcilacakForm)
        {
 
            AcilacakForm.ShowDialog(this);
            AcilacakForm.Dispose();
            AcilacakForm = null;
        }

        private void işYeriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriEkle frmIsyeriEkle = new frmIsyeriEkle();
            FormAc(frmIsyeriEkle);
        }

        private void işYeriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriSil frmIsyeriSil = new frmIsyeriSil();
            FormAc(frmIsyeriSil);
        }

        private void işYeriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriGuncelle frmIsyeriGuncelle = new frmIsyeriGuncelle();
            FormAc(frmIsyeriGuncelle);
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void işyeriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriListeleme frmIsyeriListeleme = new frmIsyeriListeleme();
            FormAc(frmIsyeriListeleme);
        }

        private void kullanıcıListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciListeleme frmKullaniciListeleme = new frmKullaniciListeleme();
            FormAc(frmKullaniciListeleme);
        }

        private void işYeriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriAra frmIsyeriAra = new frmIsyeriAra();
            FormAc(frmIsyeriAra);
        }

        private void işYeriYöneticiAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            frmIsyeriYoneticiAta frmIsyeriYoneticiAta = new frmIsyeriYoneticiAta();
            FormAc(frmIsyeriYoneticiAta);
            */
        }

        private void kullanıcıRandevuListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciRandevuListeleme frmKullaniciRandevuListeleme = new frmKullaniciRandevuListeleme();
            FormAc(frmKullaniciRandevuListeleme);
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:8081/hakkinda");

        }
    }
}
