using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace giris_sayfası
{
    public partial class kullanıcı : Form
    {
        STOK stok = new STOK();
        public kullanıcı()
        {
            InitializeComponent();
        }

        private void yenileliste()
        {
            try
            {
                string cumle = "select * from KULLANICI_SAYFA ";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = stok.listele(adtr2, cumle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KAYDET_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "insert into KULLANICI_SAYFA(K_SIFRE,K_ADI,K_UNVAN) values(@K_SIFRE,@K_ADI,@K_UNVAN) ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@K_SIFRE", textBox2.Text);
                komut2.Parameters.AddWithValue("@K_ADI", textBox1.Text);
                komut2.Parameters.AddWithValue("@K_UNVAN", textBox3.Text);
                stok.ekle_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                yenileliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                textBox1.Text = satir.Cells["K_ADI"].Value.ToString();
                textBox2.Text = satir.Cells["K_SIFRE"].Value.ToString();
                textBox3.Text = satir.Cells["K_UNVAN"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kullanıcı_Load(object sender, EventArgs e)
        {
            yenileliste();
        }

        private void SİL_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                string cümle = "delete from KULLANICI_SAYFA where K_ADI='" + row.Cells["K_ADI"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                stok.ekle_sil_güncelle(komut2, cümle);
                yenileliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ÇIKIŞ_Click(object sender, EventArgs e)
        {
            this.Hide();
            menü ac = new menü();
            ac.ShowDialog();
        }
    }
}
