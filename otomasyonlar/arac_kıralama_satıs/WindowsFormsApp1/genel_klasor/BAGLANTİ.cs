using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.genel_klasor
{
    public class BAGLANTİ
    {
        public SqlConnection baglanti2()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PL0E0J5;Initial Catalog=arac_satıs;Integrated Security=True");

            baglan.Open();
            return baglan;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PL0E0J5;Initial Catalog=arac_satıs;Integrated Security=True");
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
    }
}
