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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            urun_ekle urunsf = new urun_ekle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                STOK baglan = new STOK();
                SqlCommand komut = new SqlCommand("SELECT * FROM KULLANICI_SAYFA WHERE K_ADI=@p1 AND K_SIFRE=@p2", baglan.baglanti2());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    menü ac2 = new menü();
                    ac2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
