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
    public partial class frmIsyeriListeleme : Form
    {
        public frmIsyeriListeleme()
        {
            InitializeComponent();
        }

        IsyeriRaporlari isyeriRaporlari = new IsyeriRaporlari();
        private void frmIsyeriListeleme_Load(object sender, EventArgs e)
        {
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
