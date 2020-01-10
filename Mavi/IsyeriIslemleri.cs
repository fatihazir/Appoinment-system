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
    public class IsyeriIslemleri : SqlIslemleri
    
    {
        public void IsyeriEkle(string isyeriAdi, decimal telefonNumarasi, string isyeriAdresi, int isyeriKategori, int isyeriSahibiId)
        {
            
            try
            {
                con.Open();
                SqlCommand cmdIsyeri = new SqlCommand("INSERT INTO tbl_isyeri " +
                                                "(isyeri_isim, isyeri_telno, isyeri_adres, kategori_id, isyeri_sahibi_id) " +
                                                "values (@isyeri_isim, @isyeri_telno, @isyeri_adres, @kategori_id,@isyeri_sahibi_id) " ,con);
                

                cmdIsyeri.Parameters.AddWithValue("isyeri_isim", isyeriAdi);
                cmdIsyeri.Parameters.AddWithValue("isyeri_telno", telefonNumarasi);
                cmdIsyeri.Parameters.AddWithValue("isyeri_adres", isyeriAdresi);
                cmdIsyeri.Parameters.AddWithValue("kategori_id", isyeriKategori);
                cmdIsyeri.Parameters.AddWithValue("isyeri_sahibi_id", isyeriSahibiId);

                cmdIsyeri.ExecuteNonQuery();


                MessageBox.Show(isyeriAdi + " " + "Adlı işyeri eklendi.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(isyeriAdi + " " + "Adlı işyeri eklenirken bir hata oluştu.");
                throw ex;
                con.Close();
            }
            
        }

        public void IsyeriSil(int input, DataGridView dgv)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_isyeri where isyeri_id = @isyeri_id", con);
                cmd.Parameters.AddWithValue("@isyeri_id", input);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string isyeriAdi = dr["isyeri_isim"].ToString();
                    dr.Close();

                    DialogResult durum = MessageBox.Show(isyeriAdi + " " + "Firmasını silmek istediğinize emin misiniz?"
                        , "Silme Onayı", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == durum)
                    {

                        SqlCommand sil = new SqlCommand("DELETE from tbl_isyeri where isyeri_id = @isyeri_id", con);
                        sil.Parameters.AddWithValue("@isyeri_id", input);
                        sil.ExecuteNonQuery();
                        MessageBox.Show("Kayit Silindi");
                        dr.Close();
                        con.Close();


                    }
                }
                else
                {
                    MessageBox.Show("İşyeri bulunamadı.");
                    con.Close();
                    dr.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void IsyeriGuncelle(string isyeriAdi, decimal telefonNumarasi, string isyeriAdresi, int isyeriKategori, int isyeri_id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_isyeri " +
                                                "SET isyeri_isim = @isyeri_isim ," +
                                                "isyeri_telno = @isyeri_telno ," +
                                                "isyeri_adres = @isyeri_adres ," +
                                                "kategori_id = @kategori_id " +
                                                "WHERE isyeri_id = @isyeri_id", con);

                cmd.Parameters.AddWithValue("isyeri_isim", isyeriAdi);
                cmd.Parameters.AddWithValue("isyeri_telno", telefonNumarasi);
                cmd.Parameters.AddWithValue("isyeri_adres", isyeriAdresi);
                cmd.Parameters.AddWithValue("kategori_id", isyeriKategori);
                cmd.Parameters.AddWithValue("isyeri_id", isyeri_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı");
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu.");
                throw ex;
                con.Close();
            }
            
        }

        public void IsyeriSorulariSil(int input)
        {
            con.Open();
            SqlCommand soruSil = new SqlCommand("delete sc " +
                                                "from tbl_sorucevap as sc inner join tbl_isyeri as i " +
                                                "on i.isyeri_isim = sc.cevaplayan_firma " +
                                                "where isyeri_id =@isyeri_id", con);
            soruSil.Parameters.AddWithValue("@isyeri_id", input);
            soruSil.ExecuteNonQuery();
            MessageBox.Show("Sorular Silindi.");
            con.Close();
        }
        
            
        
    }
}
