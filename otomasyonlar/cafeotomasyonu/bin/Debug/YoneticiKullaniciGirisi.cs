﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace cafeotomasyonu    
{
    public partial class YoneticiKullaniciGirisi : Form
    {
        public YoneticiKullaniciGirisi()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kafeotomasyonu.mdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = tboxKullaniciAdi.Text;
            string sifre = tboxSifre.Text;
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM yonetici where KullaniciAdi='" + tboxKullaniciAdi.Text + "' AND Sifre='" + tboxSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                YoneticiPanel f2 = new YoneticiPanel();
                this.Close();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            baglanti.Close();
        
        }

        private void YoneticiKullaniciGirisi_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
