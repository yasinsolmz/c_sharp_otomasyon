﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMusteriEkle ac = new frmMusteriEkle();
            ac.ShowDialog();
            Form2 kapat = new Form2();
            kapat.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {  this.Hide();
            frmMusterilistele listele = new frmMusterilistele();
            listele.ShowDialog();
          
           
            Form2 kapat = new Form2();
            kapat.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 ekle = new Form1();

            ekle.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arackayıt kayıt = new arackayıt();
            kayıt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            araclistele kayıt = new araclistele();
            kayıt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sozlesme kayıt = new Sozlesme();
            kayıt.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
