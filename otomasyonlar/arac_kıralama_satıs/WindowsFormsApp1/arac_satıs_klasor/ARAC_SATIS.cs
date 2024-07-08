using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class ARAC_SATIS
    {

        private static string con_str = "Data Source=DESKTOP-PL0E0J5;Initial Catalog=arac_satıs;Integrated Security=True";
        DataTable tablo;

        SqlConnection _conn;

        public ARAC_SATIS()
        {
            _conn = new SqlConnection(con_str);
        }

        public void BaglantiAc()
        {
            _conn.Open();
        }


        public void BaglantiKapat()
        {
            _conn.Close();
        }
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            _conn.Open();
            komut.Connection = _conn;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            _conn.Close();

        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, _conn);
            adtr.Fill(tablo);
            _conn.Close();
            return tablo;

        }
    }
}
