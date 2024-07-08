using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.arac_satıs_klasor
{
    public partial class arac_listele : Form
    {
        ARAC_SATIS aracSatis = new ARAC_SATIS();
        public arac_listele()
        {
            InitializeComponent();
        }

        private void boyalıListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boyalıListBox.Height == 170)
            {
                boyalıListBox.Height = 50;
            }
            else
            {
                boyalıListBox.Height = 170;
            }
        }

        private void degisenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (degisenListBox.Height == 170)
            {
                degisenListBox.Height = 50;
            }
            else
            {
                degisenListBox.Height = 170;
            }
        }

        private void arac_listele_Load(object sender, EventArgs e)
        {
            yenilearacliste();
        }

        private void yenilearacliste()
        {
            try
            {
                string cumle = "select * from ARAC_ALIM";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = aracSatis.listele(adtr2, cumle);
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
                string cümle = "UPDATE ARAC_ALIM SET MARKA=@MARKA,SERİ=@SERİ,YİL=@YİL,RENK=@RENK,KM=@KM,YAKIT=@YAKIT,ALIS_FIYATI=@ALIS_FIYATI,D_PARCA=@D_PARCA,B_PARCA=@B_PARCA,OYKU=@OYKU,A_TARIH=@A_TARIH WHERE PLAKA=@PLAKA";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@PLAKA", plakatxt.Text);
                komut2.Parameters.AddWithValue("@MARKA", markatxt.Text);
                komut2.Parameters.AddWithValue("@SERİ", seritxt.Text);
                komut2.Parameters.AddWithValue("@YİL", yıltext.Text);
                komut2.Parameters.AddWithValue("@RENK", renktext.Text);
                komut2.Parameters.AddWithValue("@KM", kmtext.Text);
                komut2.Parameters.AddWithValue("@YAKIT", yakıtcombo.Text);
                komut2.Parameters.AddWithValue("@ALIS_FIYATI", fyattxt.Text);
                komut2.Parameters.AddWithValue("@B_PARCA", boyalıListBox.Text);
                komut2.Parameters.AddWithValue("@OYKU", richTextBox1.Text);
                komut2.Parameters.AddWithValue("@D_PARCA", degisenListBox.Text);
                komut2.Parameters.AddWithValue("@A_TARIH", DateTime.Now.ToString());
                aracSatis.ekle_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                yenilearacliste();
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
                plakatxt.Text = satir.Cells["PLAKA"].Value.ToString();
                markatxt.Text = satir.Cells["MARKA"].Value.ToString();
                seritxt.Text = satir.Cells["SERİ"].Value.ToString();
                yıltext.Text = satir.Cells["YİL"].Value.ToString();
                renktext.Text = satir.Cells["RENK"].Value.ToString();
                kmtext.Text = satir.Cells["KM"].Value.ToString();
                yakıtcombo.Text = satir.Cells["YAKIT"].Value.ToString();
                fyattxt.Text= satir.Cells["ALIS_FIYATI"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                string cümle = "delete from ARAC_ALIM where PLAKA='" + row.Cells["PLAKA"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                aracSatis.ekle_sil_güncelle(komut2, cümle);
                yenilearacliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            oto_alım_satım listele = new oto_alım_satım();
            listele.ShowDialog();

        }

        private void fyattxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
