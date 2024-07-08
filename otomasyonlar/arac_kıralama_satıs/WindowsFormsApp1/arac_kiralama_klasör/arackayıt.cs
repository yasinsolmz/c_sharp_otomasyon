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
    public partial class arackayıt : Form
    {
        arac_kıralama arac_Kıralama = new arac_kıralama();
        public arackayıt()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 listele = new Form2();
            listele.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sericombo.Items.Clear();
                if (markacomb.SelectedIndex == 0)
                {
                    sericombo.Items.Add("ASTRA");
                    sericombo.Items.Add("VECTRA");
                    sericombo.Items.Add("CORSA");
                }
                else if (markacomb.SelectedIndex == 1)
                {
                    sericombo.Items.Add("CLİO");
                    sericombo.Items.Add("MEGANE");
                    sericombo.Items.Add("TALİANT");
                }
                else if (markacomb.SelectedIndex == 2)
                {
                    sericombo.Items.Add("PASSAT");
                    sericombo.Items.Add("TİGUAN");
                    sericombo.Items.Add("GOLF");
                }
                else if (markacomb.SelectedIndex == 3)
                {
                    sericombo.Items.Add("EGEA");
                    sericombo.Items.Add("LİNEA");
                    sericombo.Items.Add("PUNTO");
                }
                else if (markacomb.SelectedIndex == 4)
                {
                    sericombo.Items.Add("FOCUS");
                    sericombo.Items.Add("CONNECT");
                    sericombo.Items.Add("MONDEO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arackayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "insert into ARAC_KAYIT(PLAKA,MARKA,SERİ,YİL,RENK,KM,YAKIT,KİRAUCRETİ,DURUM,TARİH) values(@PLAKA,@MARKA,@SERİ,@YİL,@RENK,@KM,@YAKIT,@KİRAUCRETİ,@DURUM,@TARİH)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@PLAKA", plakatxt.Text);
                komut2.Parameters.AddWithValue("@MARKA", markacomb.Text);
                komut2.Parameters.AddWithValue("@SERİ", sericombo.Text);
                komut2.Parameters.AddWithValue("@YİL", yıltext.Text);
                komut2.Parameters.AddWithValue("@RENK", renktext.Text);
                komut2.Parameters.AddWithValue("@KM", kmtext.Text);
                komut2.Parameters.AddWithValue("@YAKIT", yakıtcombo.Text);
                komut2.Parameters.AddWithValue("@KİRAUCRETİ", kiratext.Text);
                komut2.Parameters.AddWithValue("@DURUM", "boş");
                komut2.Parameters.AddWithValue("@TARİH", DateTime.Now.ToString());

                arac_Kıralama.ekle_sil_güncelle(komut2, cümle);
                MessageBox.Show("Araç kaydı başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sericombo.Items.Clear();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                    if (item is ComboBox)
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
    }
}
