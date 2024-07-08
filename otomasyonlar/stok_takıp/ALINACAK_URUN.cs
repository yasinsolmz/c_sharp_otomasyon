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

namespace giris_sayfası
{
    public partial class ALINACAK_URUN : Form
    {STOK stok =new STOK();
        public ALINACAK_URUN()
        {
            InitializeComponent();
        }
        private void yenileliste()

        {

            string cumle = "select * from ALIS_TARİHİ ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();

            dataGridView1.DataSource = stok.listele(adtr2, cumle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STOK stok = new STOK();

            string cümle = "insert into ALIS_TARİHİ(URUN_ADI,STOK,ALIS_TARIHI) values(@URUN_ADI,@STOK,@ALIS_TARIHI) ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@URUN_ADI", textBox1.Text);
            komut2.Parameters.AddWithValue("@STOK", textBox2.Text);
            komut2.Parameters.AddWithValue("@ALIS_TARIHI", dateTimePicker1.Value);

            stok.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
            yenileliste();
        }

        private void ALINACAK_URUN_Load(object sender, EventArgs e)
        {
            yenileliste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            string cümle = "delete from ALIS_TARİHİ where URUN_ADI='" + row.Cells["URUN_ADI"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            stok.ekle_sil_güncelle(komut2, cümle);
            yenileliste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                this.Hide();

                menü ac = new menü();
                ac.ShowDialog();
            }
        }
    }
}
