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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.genel_klasor
{
    public partial class KULLANICI : Form
    {
        BAGLANTİ bg = new BAGLANTİ();
        public KULLANICI()
        {
            InitializeComponent();
        }

        private void KULLANICI_Load(object sender, EventArgs e)
        {
            yenileliste();
        }
        private void yenileliste()
        {
            try
            {
                string cumle = "select * from KULLANICI_SAYFA ";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = bg.listele(adtr2, cumle);
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
                bg.ekle_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
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

        private void SİL_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                string cümle = "delete from KULLANICI_SAYFA where K_ADI='" + row.Cells["K_ADI"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                bg.ekle_sil_güncelle(komut2, cümle);
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
            Form1 listele = new Form1();
            listele.ShowDialog();
        }
    }
    
}
