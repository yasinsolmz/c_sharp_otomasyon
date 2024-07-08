using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giris_sayfası
{
    public partial class menü : Form
    {
        public menü()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullanıcı ac = new kullanıcı();
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            urun_ekle ac = new urun_ekle();
            ac.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            URUN_GUNCELLE ac = new URUN_GUNCELLE();
            ac.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            URUN_SATIS AC = new URUN_SATIS();
            AC.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            kazanc AC = new kazanc();
            AC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ALINACAK_URUN AC = new ALINACAK_URUN();
            AC.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ac = new Form1();
            ac.ShowDialog();
        }
    }
}
