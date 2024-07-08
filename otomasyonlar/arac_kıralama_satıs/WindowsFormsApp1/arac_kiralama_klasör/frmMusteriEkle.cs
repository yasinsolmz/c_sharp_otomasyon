using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMusteriEkle : Form
    {
        arac_kıralama arac_kıra = new arac_kıralama();

        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "insert into müsteri(tc,adi_soyadi,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", textBox1.Text);
                komut2.Parameters.AddWithValue("@adsoyad", textBox2.Text);
                komut2.Parameters.AddWithValue("@telefon", textBox3.Text);
                komut2.Parameters.AddWithValue("@adres", textBox4.Text);
                komut2.Parameters.AddWithValue("@email", textBox5.Text);

                arac_kıra.ekle_sil_güncelle(komut2, cümle);

                MessageBox.Show("Müşteri ekleme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TextBox'ları temizleme
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası oluştu. Hata Kodu: DB01\nHata Mesajı: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Geçersiz bir veri girişi yapıldı. Hata Kodu: ARG01\nHata Mesajı: " + ex.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu. Hata Kodu: GEN01\nHata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ac = new Form2();
            ac.ShowDialog();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
