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
    public partial class araclistele : Form
    {
        arac_kıralama arac_Kıralama = new arac_kıralama();

        public araclistele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                plakatxt.Text = satir.Cells["PLAKA"].Value.ToString();
                markacomb.Text = satir.Cells["MARKA"].Value.ToString();
                sericombo.Text = satir.Cells["SERİ"].Value.ToString();
                yıltext.Text = satir.Cells["YİL"].Value.ToString();
                renktext.Text = satir.Cells["RENK"].Value.ToString();
                kmtext.Text = satir.Cells["KM"].Value.ToString();
                yakıtcombo.Text = satir.Cells["YAKIT"].Value.ToString();
                kiratext.Text = satir.Cells["KİRAUCRETİ"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hücre verisi okunurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void araclistele_Load(object sender, EventArgs e)
        {
            try
            {
                yenilearacliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Araç listesi yenilenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yenilearacliste()
        {
            try
            {
                string cumle = "select * from ARAC_KAYIT";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = arac_Kıralama.listele(adtr2, cumle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Araç listesi verisi alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "UPDATE ARAC_KAYIT SET MARKA=@MARKA,SERİ=@SERİ,YİL=@YİL,RENK=@RENK,KM=@KM,YAKIT=@YAKIT,KİRAUCRETİ=@KİRAUCRETİ,TARİH=@TARİH WHERE PLAKA=@PLAKA";
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

                sericombo.Items.Clear();
                foreach (Control item in Controls)
                {
                    if (item is TextBox) item.Text = "";
                    if (item is ComboBox) item.Text = "";
                }
                yenilearacliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                string cümle = "delete from ARAC_KAYIT where PLAKA='" + row.Cells["PLAKA"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                arac_Kıralama.ekle_sil_güncelle(komut2, cümle);
                yenilearacliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form2 listele = new Form2();
                listele.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form açma işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
