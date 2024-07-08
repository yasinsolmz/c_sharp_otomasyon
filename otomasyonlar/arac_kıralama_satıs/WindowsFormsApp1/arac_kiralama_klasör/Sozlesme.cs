using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sozlesme : Form
    {
        arac_kıralama arac = new arac_kıralama();

        public Sozlesme()
        {
            InitializeComponent();
        }

        public void Sozlesme_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select * from ARAC_KAYIT where DURUM='BOŞ'";
            arac.Bos_Araclar(comboBox1, sorgu2);
            yenile();
        }

        private void yenile()
        {
            string sorgu3 = "select * from SOZLESME";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT * FROM müsteri WHERE tc LIKE '" + txttc.Text + "'";
            arac.TC_ARA(txttc, txtadsyd, txttlfn, sorgu2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT * FROM ARAC_KAYIT WHERE PLAKA LIKE '" + comboBox1.SelectedItem + "'";
            arac.combodanGetir(textBox10, textBox9, textBox8, textBox7, sorgu2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT * FROM ARAC_KAYIT WHERE PLAKA LIKE '" + comboBox1.SelectedItem + "'";
            arac.Hesapla(comboBox2, textBox14, sorgu2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TimeSpan gunFarkı = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(dateTimePicker1.Text);
            int gun = gunFarkı.Days;
            textBox13.Text = gun.ToString();
            textBox11.Text = (gun * int.Parse(textBox14.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Text = DateTime.Now.ToShortDateString();
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            comboBox2.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox11.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu2 = "INSERT INTO SOZLESME (TC, AD_SOYAD, TELEFON, EHLIYET_NO, E_TARİH, E_VERİLDİGİ_YER, PLAKA, MARKA, SERİ, YİL, RENK, KIRA_SEKLI, KİRAUCRETİ, GUN, TUTAR, C_TARIH, D_TARIH) " +
                                "VALUES (@TC, @AD_SOYAD, @TELEFON, @EHLIYET_NO, @E_TARİH, @E_VERİLDİGİ_YER, @PLAKA, @MARKA, @SERİ, @YİL, @RENK, @KIRA_SEKLI, @KİRAUCRETİ, @GUN, @TUTAR, @C_TARIH, @D_TARIH)";
                SqlCommand komut2 = new SqlCommand(sorgu2);
                komut2.Parameters.AddWithValue("@TC", txttc.Text);
                komut2.Parameters.AddWithValue("@AD_SOYAD", txtadsyd.Text);
                komut2.Parameters.AddWithValue("@TELEFON", txttlfn.Text);
                komut2.Parameters.AddWithValue("@EHLIYET_NO", txteno.Text);
                komut2.Parameters.AddWithValue("@E_TARİH", txtetrh.Text);
                komut2.Parameters.AddWithValue("@E_VERİLDİGİ_YER", txtevrldyet.Text);
                komut2.Parameters.AddWithValue("@PLAKA", comboBox1.Text);
                komut2.Parameters.AddWithValue("@MARKA", textBox10.Text);
                komut2.Parameters.AddWithValue("@SERİ", textBox9.Text);
                komut2.Parameters.AddWithValue("@YİL", textBox8.Text);
                komut2.Parameters.AddWithValue("@RENK", textBox7.Text);
                komut2.Parameters.AddWithValue("@KIRA_SEKLI", comboBox2.Text);
                komut2.Parameters.AddWithValue("@KİRAUCRETİ", textBox14.Text);
                komut2.Parameters.AddWithValue("@GUN", textBox13.Text);
                komut2.Parameters.AddWithValue("@TUTAR", textBox11.Text);
                komut2.Parameters.AddWithValue("@C_TARIH", dateTimePicker1.Text);
                komut2.Parameters.AddWithValue("@D_TARIH", dateTimePicker2.Text);
                arac.ekle_sil_güncelle(komut2, sorgu2);

                MessageBox.Show("Sözleşme başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenile();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası oluştu. Hata Kodu: DB04\nHata Mesajı: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu. Hata Kodu: GEN04\nHata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ac = new Form2();
            ac.ShowDialog();
        }
    }
}
