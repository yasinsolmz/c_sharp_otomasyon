using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace cafeotomasyonu
{
    public partial class KayitEkle : Form
    {
        public KayitEkle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kafeotomasyonu.mdb");
        DataTable tablo = new DataTable();  // tablo isiminde bir Datatable tanımladık.
        OleDbCommand komut = new OleDbCommand();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tikla;
            if (cmBoxKullaniciTipi.Text == "Garson")
            {

                if (tBoxAd.Text != "" & tBoxSoyad.Text != "" & mBoxDogum.Text != "" & mBoxTelefon.Text != "" & tBoxKullaniciadi.Text != "" & tBoxSifre.Text != "")
                {
                    tikla = "Insert into garson(Ad,Soyad,DogumTarihi,Telefon,KullaniciAdi,Sifre)values(@ad,@soy,@dog,@tel,@kul,@sif)";

                    OleDbCommand komut = new OleDbCommand(tikla, baglanti);
                    komut.Parameters.AddWithValue("@ad", tBoxAd.Text);
                    komut.Parameters.AddWithValue("@soy", tBoxSoyad.Text);
                    komut.Parameters.AddWithValue("@dog", mBoxDogum.Text);
                    komut.Parameters.AddWithValue("@tel", mBoxTelefon.Text);
                    komut.Parameters.AddWithValue("@kul", tBoxKullaniciadi.Text);
                    komut.Parameters.AddWithValue("@sif", tBoxSifre.Text);
                    komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.
                    MessageBox.Show("TMMDIR REİS");
                    tBoxAd.Clear();
                    tBoxSoyad.Clear();
                    mBoxDogum.Clear();
                    mBoxTelefon.Clear();
                    tBoxKullaniciadi.Clear();
                    tBoxSifre.Clear();
                }
                else
                {
                    MessageBox.Show("düzgün girin");
                }
            }

            else 
            {              

                if (tBoxAd.Text != "" & tBoxSoyad.Text != "" & mBoxDogum.Text != "" & mBoxTelefon.Text != "" & tBoxKullaniciadi.Text != "" & tBoxSifre.Text != "")
                {
                    
                    tikla = "Insert into yonetici(Ad,Soyad,DogumTarihi,Telefon,KullaniciAdi,Sifre)values(@ad,@soy,@dog,@tel,@kul,@sif)";

                    OleDbCommand komut = new OleDbCommand(tikla, baglanti);
                    komut.Parameters.AddWithValue("@ad", tBoxAd.Text);
                    komut.Parameters.AddWithValue("@soy", tBoxSoyad.Text);
                    komut.Parameters.AddWithValue("@dog", mBoxDogum.Text);
                    komut.Parameters.AddWithValue("@tel", mBoxTelefon.Text);
                    komut.Parameters.AddWithValue("@kul", tBoxKullaniciadi.Text);
                    komut.Parameters.AddWithValue("@sif", tBoxSifre.Text);
                    komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.
                    MessageBox.Show("TMMDIR REİS");
                    tBoxAd.Clear();
                    tBoxSoyad.Clear();
                    mBoxDogum.Clear();
                    mBoxTelefon.Clear();
                    tBoxKullaniciadi.Clear();
                    tBoxSifre.Clear();                    
                }
                else
                {
                    MessageBox.Show("düzgün girin");                    
                }                

            }
            baglanti.Close();
        }//kullanıcı kaydetme

       

        private void KayitEkle_Load(object sender, EventArgs e)
        {
            listeleYonetici();

        }
        private void listeleYonetici() //listele adında bir class belirledik. 
        {
            tablo.Clear(); //tabloyu temizledik 
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From yonetici", baglanti);
            // verileri SQL sorgusu ile adaptöre aktardık. 
            adtr.Fill(tablo); //adaptördeki verileri tablonun içine doldurduk. 
            dgwYonetici.DataSource = tablo; //tablodaki verileri datagridview'e aktardık.
        }

        private void listeleGarson() //listele adında bir class belirledik. 
        {
            tablo.Clear(); //tabloyu temizledik 
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From garson", baglanti);
            // verileri SQL sorgusu ile adaptöre aktardık. 
            adtr.Fill(tablo); //adaptördeki verileri tablonun içine doldurduk. 
            dgwYonetici.DataSource = tablo; //tablodaki verileri datagridview'e aktardık.
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (rdbtnGarson.Checked == true)
            {
                
               

            }
            if (rdbtnYonetici.Checked == true)
            {
                

            }
            if (rdbtnGarson.Checked == false & rdbtnYonetici.Checked == false)
            {
                MessageBox.Show("kirvem bi tane seç");
                baglanti.Close();
            }
        }  //kayıtlı kullanıcıları gösteriyor..

        private void btnSilyonetici_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM yonetici WHERE KullaniciAdi=@kuladi";
            komut.Parameters.AddWithValue("@kuladi", dgwYonetici.CurrentRow.Cells[4].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleYonetici();
        }

        private void btnSilgarson_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM garson WHERE KullaniciAdi=@kuladi";
            komut.Parameters.AddWithValue("@kuladi", dgwYonetici.CurrentRow.Cells[4].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleGarson();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void rdbtnYonetici_CheckedChanged(object sender, EventArgs e)
        {
            tablo.Clear(); //tabloyu temizledik
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From garson", baglanti);
            // verileri SQL sorgusu ile adaptöre aktardık.
            adtr.Fill(tablo); //adaptördeki verileri tablonun içine doldurduk.
            dgwYonetici.DataSource = tablo; //tablodaki verileri datagridview de gösterdik.
            btnSilgarson.Visible = true;
            baglanti.Close();
        }

        private void rdbtnGarson_CheckedChanged(object sender, EventArgs e)
        {
            tablo.Clear(); //tabloyu temizledik
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From yonetici", baglanti);
            // verileri SQL sorgusu ile adaptöre aktardık.
            adtr.Fill(tablo); //adaptördeki verileri tablonun içine doldurduk.
            dgwYonetici.DataSource = tablo; //tablodaki verileri datagridview de gösterdik.
            btnSilyonetici.Visible = true;

            baglanti.Close();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmBoxKullaniciTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
