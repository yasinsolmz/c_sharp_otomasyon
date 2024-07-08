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
    public partial class GIRIS : Form
    {
        public GIRIS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                BAGLANTİ baglan = new BAGLANTİ();
                SqlCommand komut = new SqlCommand("SELECT * FROM KULLANICI_SAYFA WHERE K_ADI=@p1 AND K_SIFRE=@p2", baglan.baglanti2());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    Form1 ac2 = new Form1();
                    ac2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
