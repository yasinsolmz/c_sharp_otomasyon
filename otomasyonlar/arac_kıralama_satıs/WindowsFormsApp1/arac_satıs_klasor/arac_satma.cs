using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.arac_satıs_klasor
{
    public partial class arac_satma : Form
    {
        ARAC_SATIS aracSatis = new ARAC_SATIS();
        public arac_satma()
        {
            InitializeComponent();
        }

        private void arac_satma_Load(object sender, EventArgs e)
        {
            try
            {
                yenilearacliste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                plakatxt.Text = satir.Cells["PLAKA"].Value.ToString();
                alısfyttxt.Text = satir.Cells["ALIS_FIYATI"].Value.ToString();
                ALIS_TARIH.Text = satir.Cells["A_TARIH"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stsfyttxt_TextChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void alısfyttxt_TextChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void msrftxt_TextChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void Hesapla()
        {
            try
            {
                double alisFiyat = double.Parse(alısfyttxt.Text);
                double satisFiyat = double.Parse(stsfyttxt.Text);
                double maliyet = double.Parse(msrftxt.Text);

                kartxt.Text = (satisFiyat - alisFiyat - maliyet).ToString();
            }
            catch (FormatException)
            {
                kartxt.Text = "Hatalı giriş";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                string cümle = "delete from ARAC_SATMA where PLAKA='" + row.Cells["PLAKA"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                aracSatis.ekle_sil_güncelle(komut2, cümle);
                yenilearacliste();

                string cümle2 = "insert into ARAC_SATMA(PLAKA,A_FIYAT,S_FIYAT,S_DEGER,MASRAF,KAR,A_TARIH,S_TARIH) values(@PLAKA,@A_FIYAT,@S_FIYAT,@S_DEGER,@MASRAF,@KAR,@A_TARIH,@S_TARIH)";
                SqlCommand komut3 = new SqlCommand();
                komut3.Parameters.AddWithValue("@PLAKA", plakatxt.Text);
                komut3.Parameters.AddWithValue("@A_FIYAT", alısfyttxt.Text);
                komut3.Parameters.AddWithValue("@S_FIYAT", stsfyttxt.Text);
                komut3.Parameters.AddWithValue("@S_DEGER", stsdgrtxt.Text);
                komut3.Parameters.AddWithValue("@MASRAF", msrftxt.Text);
                komut3.Parameters.AddWithValue("@KAR", kartxt.Text);
                komut3.Parameters.AddWithValue("@A_TARIH", ALIS_TARIH.Text);
                komut3.Parameters.AddWithValue("@S_TARIH", dateTimePicker1.Text);

                aracSatis.ekle_sil_güncelle(komut3, cümle2);

                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Hata Mesajı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            oto_alım_satım listele = new oto_alım_satım();
            listele.ShowDialog();
        }
    }
}
