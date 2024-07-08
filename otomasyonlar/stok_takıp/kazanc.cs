using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace giris_sayfası
{
    public partial class kazanc : Form
    {
        STOK stok = new STOK();
        public kazanc()
        {
            InitializeComponent();
        }

        private void yenileliste()
        {
            try
            {
                string cumle = "select * from KAZANC ";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = stok.listele(adtr2, cumle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kazanc_Load(object sender, EventArgs e)
        {
            yenileliste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-PL0E0J5;Initial Catalog=STOK_TAKIBI;Integrated Security=True";

                string query = "SELECT SUM(CONVERT(int, S_ADET)) AS Toplam FROM SATIS;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        textBox1.Text = result.ToString();
                    }
                }

                string query2 = "SELECT SUM(CONVERT(int, KAR)) AS Toplam FROM SATIS;";
                using (SqlConnection connection2 = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query2, connection2);
                    connection2.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        textBox2.Text = result.ToString();
                    }
                }

                string query3 = "SELECT SUM(CONVERT(int, FIYAT)) AS Toplam FROM SATIS;";
                using (SqlConnection connection3 = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query3, connection3);
                    connection3.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        textBox6.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HESAPLA_Click(object sender, EventArgs e)
        {
            try
            {
                KZNCDGR kznc = new KZNCDGR();

                kznc.V_ORAN = Convert.ToInt32(textBox3.Text);
                kznc.T_KZNC = Convert.ToInt32(textBox2.Text);
                int kznc_vrg = Convert.ToInt32(kznc.T_KZNC) / 100 * Convert.ToInt32(kznc.V_ORAN);
                textBox5.Text = kznc_vrg.ToString();
                kznc.KZNC_VERGI = Convert.ToInt32(kznc_vrg);

                kznc.N_KAR = Convert.ToInt32(kznc.T_KZNC) - Convert.ToInt32(kznc.KZNC_VERGI);
                textBox4.Text = kznc.N_KAR.ToString();

                string cümle = "insert into KAZANC(T_SATIS,T_KAR,V_ORAN,N_KAR,T_VERGI,U_BARKOD) values(@T_SATIS,@T_KAR,@V_ORAN,@N_KAR,@T_VERGI,@U_BARKOD) ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@T_SATIS", textBox1.Text);
                komut2.Parameters.AddWithValue("@T_KAR", textBox2.Text);
                komut2.Parameters.AddWithValue("@V_ORAN", textBox3.Text);
                komut2.Parameters.AddWithValue("@N_KAR", textBox4.Text);
                komut2.Parameters.AddWithValue("@T_VERGI", textBox5.Text);
                komut2.Parameters.AddWithValue("@U_BARKOD", textBox7.Text);
                stok.ekle_sil_güncelle(komut2, cümle);
                yenileliste();
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

                string cümle = "delete from KAZANC where T_SATIS='" + row.Cells["T_SATIS"].Value.ToString() + "'";
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
