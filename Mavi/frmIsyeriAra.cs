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
    public partial class frmIsyeriAra : Form
    {
        
        DataTable dt = new DataTable();
        protected SqlConnection con = new SqlConnection("Data Source=FATIH-HP\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");

        public frmIsyeriAra()
        {
            InitializeComponent();
        }
        
        
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Zamanlayici.Start();
        }

        private void frmIsyeriAra_Load(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT i.isyeri_id as 'İşyeri Id',isyeri_isim as 'İşyeriAdı'" +
                                                ",isyeri_telno as 'İşyeri Tel'," +
                                                "isyeri_adres as 'İşyeri Adresi',kategori_adi as 'İşyeri kategorisi', " +
                                                "k.kullanici_adi as 'YöneticiAdı', k.kullanici_soyadi as 'Yönetici Soyadı'" +
                                                "FROM tbl_isyeri i inner join tbl_isyeri_kategori ik " +
                                                "on i.kategori_id = ik.kategori_id " +
                                                "inner join tbl_kullanici k on k.kullanici_id = i.isyeri_sahibi_id", con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    this.dt = new DataTable();
                    dt.Load(dr);
                    dgvIsyeriListesi.DataSource = dt;
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
                con.Close();
            }

        }

        private void txtAramaMetni_TextChanged(object sender, EventArgs e)
        {
            
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("İşyeriAdı like '%{0}%'", txtIsyeriAdindanAramaMetni.Text);
            dgvIsyeriListesi.DataSource = dv;
        }

        private void txtIsyeriYoneticiAdindanAramaMetni_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("YöneticiAdı like '%{0}%'", txtIsyeriYoneticiAdindanAramaMetni.Text);
            dgvIsyeriListesi.DataSource = dv;
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
