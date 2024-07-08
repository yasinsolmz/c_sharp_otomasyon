using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class arac_alım : Form
    {
        public arac_alım()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ARAC_SATIS aracSatis = new ARAC_SATIS();

                string cümle = "insert into ARAC_ALIM(PLAKA,MARKA,SERİ,YİL,RENK,KM,YAKIT,ALIS_FIYATI,D_PARCA,B_PARCA,OYKU,A_TARIH) values(@PLAKA,@MARKA,@SERİ,@YİL,@RENK,@KM,@YAKIT,@ALIS_FIYATI,@D_PARCA,@B_PARCA,@OYKU,@A_TARIH)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@PLAKA", plakatxt.Text);
                komut2.Parameters.AddWithValue("@MARKA", markatxt.Text);
                komut2.Parameters.AddWithValue("@SERİ", serıtxt.Text);
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

                foreach (Control item in Controls)
                {
                    if (item is TextBox) item.Text = "";
                    if (item is ComboBox) item.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            oto_alım_satım listele = new oto_alım_satım();
            listele.ShowDialog();
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

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void arac_alım_Load(object sender, EventArgs e)
        {
        }
    }
}
