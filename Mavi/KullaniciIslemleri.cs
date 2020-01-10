using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavi
{
    public class KullaniciIslemleri : SqlIslemleri
    {
        public Boolean GirisDogrulama(string kullaniciAdi, string sifre)
        {
            
            
                DataTable dtbl = new DataTable();
                con.Open();

                SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_login where kullanici_adi = '" + kullaniciAdi.Trim() + "' and " +
                                                        " sifre = '" + sifre.Trim() + "'", con);
                adp.Fill(dtbl);
                    
                if (dtbl.Rows.Count == 1)
                {
                    return true;
                    con.Close();
                    
                }
                else
                {
                    return false;
                    con.Close();
                }

                
           
        }

        public void YoneticiAktiflestir(int isyeriSahibiId)
        {
            DialogResult durum = MessageBox.Show(isyeriSahibiId + " " +
                                                 "Id'li kullanıcıya tam yetki vermek istediğinize " +
                                                 "emin misiniz?" , "Yetki Ver", 
                                                  MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {
                try
                {
                    con.Open();
                    SqlCommand cmdKullanici = new SqlCommand("UPDATE tbl_kullanici " +
                                                             "set basvuruDurumu = 0, " +
                                                             "yoneticimi = 1 " +
                                                             "where kullanici_id = @isyeri_sahibi_id", con);

                    cmdKullanici.Parameters.AddWithValue("isyeri_sahibi_id", isyeriSahibiId);

                    cmdKullanici.ExecuteNonQuery();

                    MessageBox.Show(isyeriSahibiId + " " + "Id'li kullanıcıya erişim verildi. ");
                    con.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                    MessageBox.Show("Bir hata oluştu");
                    con.Close();
                } 
            }
        }

       
    }
}
