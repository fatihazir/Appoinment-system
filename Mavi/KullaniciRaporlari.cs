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
    class KullaniciRaporlari : Raporlar
    {
        public void KullaniciListele(DataGridView dgv)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT kullanici_adi as 'Ad'," +
                                            "kullanici_soyadi as 'Soyad'," +
                                            "yoneticimi as 'Yönetici mi'," +
                                            "kullanici_eposta as 'E-posta'," +
                                            "kullanici_telno as 'Telefon Numarası'," +
                                            "kullanici_adres as 'Adres'" +
                                            " FROM tbl_kullanici", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
            con.Close();
        }

        public void BasvuranlariListele(DataGridView dgv)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT k.kullanici_id as 'Kullanıcı Id'," +
                                            " k.kullanici_adi as 'Kullanıcı Adı'," +
                                            " k.kullanici_soyadi as 'Kullanıcı Soyadı'," +
                                            "k.isyerisahibi_TCNO as 'Tc Kimlik'," +
                                            "k.isyerisahibi_dogum_tarihi as 'DogumTarihi'," +
                                            " b.basvuruMetni as 'Açıklama' " +
                                            "from tbl_basvurular b inner join tbl_kullanici k " +
                                            "on b.basvuranID = k.kullanici_id " +
                                            "where basvuruDurumu = 1",con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            
            dgv.DataSource = ds.Tables[0];
            dgv.Columns[5].Width = 700;
            dgv.Refresh();

            con.Close();
        }

        public void RandevuSayisinaGoreListele(DataGridView dgv)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(r.kullanici_id) as 'Toplam Randevu sayısı'," +
                                            "k.kullanici_adi as 'Kullanıcı adı', " +
                                            "k.kullanici_soyadi as 'Kullanıcı Soyadı'," +
                                            "i.isyeri_isim as 'İşyeri Adı'," +
                                            "i.isyeri_telno as 'İşyeri Tel'," +
                                            "ik.kategori_adi as 'İşyeri Kategori' " +
                                            "FROM tbl_randevular r inner join tbl_kullanici k on k.kullanici_id = r.kullanici_id " +
                                            "inner join tbl_isyeri i on i.isyeri_id = r.isyeri_id " +
                                            "inner join tbl_isyeri_kategori ik on i.kategori_id = ik.kategori_id " +
                                            "group by k.kullanici_adi, k.kullanici_soyadi," +
                                            "ik.kategori_adi, i.isyeri_isim," +
                                            "i.isyeri_telno " +
                                            "order by COUNT(r.isyeri_id) desc", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
            con.Close();
        }
    }
}
