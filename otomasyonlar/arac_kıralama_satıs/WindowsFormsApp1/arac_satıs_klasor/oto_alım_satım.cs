using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.arac_satıs_klasor;

namespace WindowsFormsApp1
{
    public partial class oto_alım_satım : Form
    {
        public oto_alım_satım()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            arac_listele ac = new arac_listele();
            ac.ShowDialog();
            oto_alım_satım kapat = new oto_alım_satım();
            kapat.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            arac_alım ac = new arac_alım();
            ac.ShowDialog();
            oto_alım_satım kapat = new oto_alım_satım();
            kapat.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                arac_satma ac = new arac_satma();
                ac.ShowDialog();
                oto_alım_satım kapat = new oto_alım_satım();
                kapat.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 listele = new Form1();
            listele.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void oto_alım_satım_Load(object sender, EventArgs e)
        {

        }
    }
}
