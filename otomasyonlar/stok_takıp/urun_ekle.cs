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
    public partial class urun_ekle : Form
    {
        public urun_ekle()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string barcodeData = textBox1.Text;

            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox1.Clear();
            }
        }

        private void urun_ekle_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                STOK stok = new STOK();

                string cümle = "insert into URUN_EKLE(U_BARKODU,U_ADI,U_ADET,FIYAT,STOK,CINS) values(@U_BARKODU,@U_ADI,@U_ADET,@FIYAT,@STOK,@CINS) ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@U_BARKODU", textBox1.Text);
                komut2.Parameters.AddWithValue("@U_ADI", textBox2.Text);
                komut2.Parameters.AddWithValue("@U_ADET", textBox3.Text);
                komut2.Parameters.AddWithValue("@FIYAT", textBox4.Text);
                komut2.Parameters.AddWithValue("@STOK", textBox5.Text);
                komut2.Parameters.AddWithValue("@CINS", textBox6.Text);
                stok.ekle_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";

                MessageBox.Show("Ürün ekleme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menü ac = new menü();
            ac.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
