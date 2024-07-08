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
    public partial class URUN_SATIS : Form
    {
        STOK stok = new STOK();
        public URUN_SATIS()
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

        private void URUN_SATIS_Load(object sender, EventArgs e)
        {
            yenileliste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            menü ac = new menü();
            ac.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                textBox1.Text = satir.Cells["U_BARKODU"].Value.ToString();
                textBox2.Text = satir.Cells["U_ADI"].Value.ToString();
                textBox5.Text = satir.Cells["STOK"].Value.ToString();
                textBox6.Text = satir.Cells["FIYAT"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                gtrsatıs abc = new gtrsatıs();
                stok_tkp stktkp = new stok_tkp();
                abc.U_BARKODU = textBox1.Text;
                abc.U_ADI = textBox2.Text;
                abc.S_ADET = Convert.ToInt32(textBox3.Text);
                abc.FIYAT = Convert.ToInt32(textBox4.Text);
                stktkp.Stok_Deger = Convert.ToInt32(textBox5.Text);
                int k_Adet = stktkp.Stok_Deger - abc.S_ADET;
                abc.Kln_Stok = k_Adet;
                stktkp.ALIŞ_FIYAT = Convert.ToInt32(textBox6.Text);
                int kar = abc.FIYAT - stktkp.ALIŞ_FIYAT;
                abc.KAR = kar * abc.S_ADET;
                string cümle = "UPDATE URUN_EKLE SET STOK=@STOK ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@STOK", k_Adet.ToString());
                stok.ekle_sil_güncelle(komut2, cümle);

                stok.satısyap(abc);
                MessageBox.Show(kar.ToString());

                foreach (Control item in Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
