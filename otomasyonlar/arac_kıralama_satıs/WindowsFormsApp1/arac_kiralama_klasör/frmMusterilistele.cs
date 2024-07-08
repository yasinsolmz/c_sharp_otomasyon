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
    public partial class frmMusterilistele : Form
    {
        arac_kıralama arackiralama = new arac_kıralama();

        public frmMusterilistele()
        {
            InitializeComponent();
        }

        private void frmMusterilistele_Load(object sender, EventArgs e)
        {
            yenileListele();
        }

        private void yenileListele()
        {
            string cümle = "select* from müsteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select* from müsteri where tc like '%" + textBox6.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void frmMusterilistele_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle2 = "update müsteri set adi_soyadi=@adsoyadi,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
                SqlCommand komut2 = new SqlCommand(cümle2);
                komut2.Parameters.AddWithValue("@tc", textBox1.Text);
                komut2.Parameters.AddWithValue("@adsoyadi", textBox2.Text);
                komut2.Parameters.AddWithValue("@telefon", textBox3.Text);
                komut2.Parameters.AddWithValue("@adres", textBox4.Text);
                komut2.Parameters.AddWithValue("@email", textBox5.Text);

                arackiralama.ekle_sil_güncelle(komut2, cümle2);

                MessageBox.Show("Müşteri güncelleme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }

                yenileListele();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası oluştu. Hata Kodu: DB02\nHata Mesajı: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Geçersiz bir veri girişi yapıldı. Hata Kodu: ARG02\nHata Mesajı: " + ex.Message, "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu. Hata Kodu: GEN02\nHata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                string cümle = "delete from müsteri where tc='" + row.Cells["tc"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand(cümle);
                arackiralama.ekle_sil_güncelle(komut2, cümle);
                yenileListele();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası oluştu. Hata Kodu: DB03\nHata Mesajı: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu. Hata Kodu: GEN03\nHata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form2 ac = new Form2();
                ac.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form açılırken bir hata oluştu: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
