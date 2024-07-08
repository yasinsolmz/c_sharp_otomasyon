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

namespace giris_sayfası
{
    public partial class URUN_GUNCELLE : Form
    {
        STOK stok = new STOK();
        public URUN_GUNCELLE()
        {
            InitializeComponent();
        }
        private void yenileliste()

        {
            try
            {
                string cumle = "select * from URUN_EKLE ";
                SqlDataAdapter adtr2 = new SqlDataAdapter();

                dataGridView1.DataSource = stok.listele(adtr2, cumle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "UPDATE URUN_EKLE SET U_ADI=@U_ADI,U_ADET=@U_ADET,FIYAT=@FIYAT,STOK=@STOK,CINS=@CINS WHERE U_BARKODU=@U_BARKODU ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@U_BARKODU", textBox1.Text);
                komut2.Parameters.AddWithValue("@U_ADI", textBox2.Text);
                komut2.Parameters.AddWithValue("@U_ADET", textBox3.Text);
                komut2.Parameters.AddWithValue("@FIYAT", textBox4.Text);
                komut2.Parameters.AddWithValue("@STOK", textBox5.Text);
                komut2.Parameters.AddWithValue("@CINS", textBox6.Text);

                stok.ekle_sil_güncelle(komut2, cümle);

                foreach (Control item in Controls) if (item is TextBox) item.Text = "";

                yenileliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menü ac = new menü();
            ac.ShowDialog();
        }

        private void URUN_GUNCELLE_Load(object sender, EventArgs e)
        {
            yenileliste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                string cümle = "delete from URUN_EKLE where U_BARKODU='" + row.Cells["U_BARKODU"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                stok.ekle_sil_güncelle(komut2, cümle);
                yenileliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                textBox1.Text = satir.Cells["U_BARKODU"].Value.ToString();
                textBox2.Text = satir.Cells["U_ADI"].Value.ToString();
                textBox3.Text = satir.Cells["U_ADET"].Value.ToString();
                textBox4.Text = satir.Cells["FIYAT"].Value.ToString();
                textBox5.Text = satir.Cells["STOK"].Value.ToString();
                textBox6.Text = satir.Cells["CINS"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
