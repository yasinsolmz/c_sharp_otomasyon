﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeotomasyonu
{
    public partial class Form9 : Form
    {
        public SiparisVer frm1;
        public Form9()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "INSERT INTO siparis(masano,corba,pide,kebap,tatli) VALUES ('" + label1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "')";
            frm1.kmt.ExecuteNonQuery();
            frm1.kmt.Dispose();
            frm1.bag.Close();
            frm1.dtst.Clear();
            frm1.frm2.button8.BackColor = System.Drawing.Color.Red;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "DELETE FROM siparis WHERE masano='" + label1.Text + "'";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.frm2.button8.BackColor = System.Drawing.Color.Green;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "UPDATE siparis SET corba='" + comboBox1.Text + "',pide='" + comboBox2.Text + "',kebap='" + comboBox3.Text + "',tatli='" + comboBox4.Text + "' WHERE masano='" + label1.Text + "'";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frm1.frm13.label3.Text = frm1.frm9.comboBox1.Text;
            frm1.frm13.label4.Text = frm1.frm9.comboBox2.Text;
            frm1.frm13.label5.Text = frm1.frm9.comboBox3.Text;
            frm1.frm13.label6.Text = frm1.frm9.comboBox4.Text;
            frm1.frm13.Show();
            this.Hide();
            frm1.frm13.label1.Text = "7";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
