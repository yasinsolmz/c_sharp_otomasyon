using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
     class arac_kıralama
    {
        SqlConnection  baglanti= new SqlConnection("Data Source=DESKTOP-PL0E0J5;Initial Catalog=araç_kiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut ,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText=sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void Bos_Araclar(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["PLAKA"].ToString());
            }
            baglanti.Close();
        }
        public void TC_ARA(TextBox tc, TextBox adsoyad, TextBox telefon, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adsoyad.Text = read["adi_soyadi"].ToString();
                telefon.Text = read["telefon"].ToString();

            }
            baglanti.Close();
        }


        public void combodanGetir(TextBox marka, TextBox seri, TextBox yil,TextBox renk, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["MARKA"].ToString();
                seri.Text = read["SERİ"].ToString();
                yil.Text = read["YİL"].ToString();
                renk.Text = read["RENK"].ToString();

            }
            baglanti.Close();

        }
        public void Hesapla(ComboBox kiraSekli,TextBox ücret,  string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (kiraSekli.SelectedIndex == 0) ücret.Text = (int.Parse(read["KİRAUCRETİ"].ToString()) * 1).ToString();
                if (kiraSekli.SelectedIndex == 1) ücret.Text = (int.Parse(read["KİRAUCRETİ"].ToString())*0.80).ToString();
                if (kiraSekli.SelectedIndex == 2) ücret.Text = (int.Parse(read["KİRAUCRETİ"].ToString()) * 0.70).ToString();
                if (kiraSekli.SelectedIndex == 3) ücret.Text = (int.Parse(read["KİRAUCRETİ"].ToString()) * 0.60).ToString();


            }
            baglanti.Close();

        }

    }
}
