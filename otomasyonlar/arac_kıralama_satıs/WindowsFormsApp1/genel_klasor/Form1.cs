using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.genel_klasor;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2  ekle= new Form2();
            
            ekle.ShowDialog();
            
            
            





        }

        private void GALERİ_BUTTON_Click(object sender, EventArgs e)
        {
            this.Hide();
            oto_alım_satım ac = new oto_alım_satım();
            ac.ShowDialog();
            Form2 kapat = new Form2();
            kapat.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            KULLANICI ac = new KULLANICI
                ();
            ac.ShowDialog();

        }
    }
}
