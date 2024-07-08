using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace giris_sayfası
{
    public class STOK
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PL0E0J5;Initial Catalog=STOK_TAKIBI;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void satısyap(gtrsatıs gelen)
        {
            STOK stok = new STOK();


            string cümle = "insert into SATIS(U_BARKODU,U_ADI,S_ADET,FIYAT,K_ADET,KAR) values(@U_BARKODU,@U_ADI,@S_ADET,@FIYAT,@K_ADET,@KAR) ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@U_BARKODU", gelen.U_BARKODU);
            komut2.Parameters.AddWithValue("@U_ADI", gelen.U_ADI);
            komut2.Parameters.AddWithValue("@S_ADET", gelen.S_ADET);
            komut2.Parameters.AddWithValue("@FIYAT", gelen.FIYAT);
            komut2.Parameters.AddWithValue("@K_ADET", gelen.Kln_Stok);
            komut2.Parameters.AddWithValue("@KAR", gelen.KAR);




            stok.ekle_sil_güncelle(komut2, cümle);



        }
        public SqlConnection baglanti2()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PL0E0J5;Initial Catalog=STOK_TAKIBI;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
