using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavi
{
    class IsyeriRaporlari : Raporlar
    {
        public void IsyeriListeleYoneticisiz(DataGridView dgv)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from tbl_isyeri ", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
            con.Close();


        }

        public void IsyeriListeleYoneticili(DataGridView dgv)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT i.isyeri_id as 'İşyeri Id',isyeri_isim as 'İşyeri Adı'" +
                                            ",isyeri_telno as 'İşyeri Tel'," +
                                            "isyeri_adres as 'İşyeri Adresi',kategori_adi as 'İşyeri kategorisi', " +
                                            "k.kullanici_adi as 'Yönetici Adı', k.kullanici_soyadi as 'Yönetici Soyadı'" +
                                            "FROM tbl_isyeri i inner join tbl_isyeri_kategori ik " +
                                            "on i.kategori_id = ik.kategori_id " +
                                            "inner join tbl_kullanici k on k.kullanici_id = i.isyeri_sahibi_id", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
            con.Close();


        }

        
    }
}
