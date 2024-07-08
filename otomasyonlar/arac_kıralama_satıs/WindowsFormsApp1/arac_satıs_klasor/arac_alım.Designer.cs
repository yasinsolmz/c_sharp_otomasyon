namespace WindowsFormsApp1
{
    partial class arac_alım
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kmtext = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.yakıtcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fyattxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RENK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MARKA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.renktext = new System.Windows.Forms.TextBox();
            this.yıltext = new System.Windows.Forms.TextBox();
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.boyalıListBox = new System.Windows.Forms.CheckedListBox();
            this.degisenListBox = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.serıtxt = new System.Windows.Forms.TextBox();
            this.ALIS_TARIH = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // kmtext
            // 
            this.kmtext.Location = new System.Drawing.Point(563, 78);
            this.kmtext.Name = "kmtext";
            this.kmtext.Size = new System.Drawing.Size(147, 22);
            this.kmtext.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1255, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 46;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1255, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 45;
            this.button1.Text = "KAYIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yakıtcombo
            // 
            this.yakıtcombo.FormattingEnabled = true;
            this.yakıtcombo.Items.AddRange(new object[] {
            "BENZİN LPG",
            "BENZİN",
            "DİZEL",
            "ELEKTRİK",
            "HYBRİD",
            "LPG"});
            this.yakıtcombo.Location = new System.Drawing.Point(563, 130);
            this.yakıtcombo.Name = "yakıtcombo";
            this.yakıtcombo.Size = new System.Drawing.Size(147, 24);
            this.yakıtcombo.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "ALIŞ  FİYATI";
            // 
            // fyattxt
            // 
            this.fyattxt.Location = new System.Drawing.Point(563, 177);
            this.fyattxt.Name = "fyattxt";
            this.fyattxt.Size = new System.Drawing.Size(147, 22);
            this.fyattxt.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "YAKIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "KM";
            // 
            // RENK
            // 
            this.RENK.AutoSize = true;
            this.RENK.Location = new System.Drawing.Point(499, 30);
            this.RENK.Name = "RENK";
            this.RENK.Size = new System.Drawing.Size(44, 16);
            this.RENK.TabIndex = 39;
            this.RENK.Text = "RENK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "MODEL(YIL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "SERİ";
            // 
            // MARKA
            // 
            this.MARKA.AutoSize = true;
            this.MARKA.Location = new System.Drawing.Point(115, 78);
            this.MARKA.Name = "MARKA";
            this.MARKA.Size = new System.Drawing.Size(54, 16);
            this.MARKA.TabIndex = 36;
            this.MARKA.Text = "MARKA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "PLAKA";
            // 
            // renktext
            // 
            this.renktext.Location = new System.Drawing.Point(563, 30);
            this.renktext.Name = "renktext";
            this.renktext.Size = new System.Drawing.Size(147, 22);
            this.renktext.TabIndex = 32;
            // 
            // yıltext
            // 
            this.yıltext.Location = new System.Drawing.Point(189, 167);
            this.yıltext.Name = "yıltext";
            this.yıltext.Size = new System.Drawing.Size(147, 22);
            this.yıltext.TabIndex = 31;
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(189, 30);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(147, 22);
            this.plakatxt.TabIndex = 30;
            // 
            // boyalıListBox
            // 
            this.boyalıListBox.FormattingEnabled = true;
            this.boyalıListBox.Items.AddRange(new object[] {
            "",
            "KAPUT",
            "ÖN TAMPON",
            "SOL ÖN ÇAMURLUK",
            "SAG ÖN  ÇAMURLUK ",
            "SOL ÖN KAPI",
            "SOL ARKA KAPI",
            "SAĞ ÖN KAPI",
            "SAĞ ARKA KAPI",
            "BAGAJ"});
            this.boyalıListBox.Location = new System.Drawing.Point(190, 265);
            this.boyalıListBox.Name = "boyalıListBox";
            this.boyalıListBox.Size = new System.Drawing.Size(187, 72);
            this.boyalıListBox.TabIndex = 48;
            this.boyalıListBox.SelectedIndexChanged += new System.EventHandler(this.boyalıListBox_SelectedIndexChanged);
            // 
            // degisenListBox
            // 
            this.degisenListBox.FormattingEnabled = true;
            this.degisenListBox.Items.AddRange(new object[] {
            "",
            "KAPUT",
            "ÖN TAMPON",
            "SOL ÖN ÇAMURLUK",
            "SAG ÖN  ÇAMURLUK ",
            "SOL ÖN KAPI",
            "SOL ARKA KAPI",
            "SAĞ ÖN KAPI",
            "SAĞ ARKA KAPI",
            "BAGAJ"});
            this.degisenListBox.Location = new System.Drawing.Point(563, 265);
            this.degisenListBox.Name = "degisenListBox";
            this.degisenListBox.Size = new System.Drawing.Size(202, 72);
            this.degisenListBox.TabIndex = 49;
            this.degisenListBox.SelectedIndexChanged += new System.EventHandler(this.degisenListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "BOYALI PARÇALAR";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "DEĞİŞEN PARÇALAR";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(866, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 443);
            this.richTextBox1.TabIndex = 57;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "ARAÇ ÖYKÜSÜ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "TARİH";
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(189, 75);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(147, 22);
            this.markatxt.TabIndex = 61;
            // 
            // serıtxt
            // 
            this.serıtxt.Location = new System.Drawing.Point(188, 116);
            this.serıtxt.Name = "serıtxt";
            this.serıtxt.Size = new System.Drawing.Size(147, 22);
            this.serıtxt.TabIndex = 62;
            // 
            // ALIS_TARIH
            // 
            this.ALIS_TARIH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ALIS_TARIH.Location = new System.Drawing.Point(565, 225);
            this.ALIS_TARIH.Name = "ALIS_TARIH";
            this.ALIS_TARIH.Size = new System.Drawing.Size(145, 22);
            this.ALIS_TARIH.TabIndex = 63;
            // 
            // arac_alım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 525);
            this.Controls.Add(this.ALIS_TARIH);
            this.Controls.Add(this.serıtxt);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.degisenListBox);
            this.Controls.Add(this.boyalıListBox);
            this.Controls.Add(this.kmtext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yakıtcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fyattxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RENK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MARKA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.renktext);
            this.Controls.Add(this.yıltext);
            this.Controls.Add(this.plakatxt);
            this.Name = "arac_alım";
            this.Text = "arac_alım";
            this.Load += new System.EventHandler(this.arac_alım_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kmtext;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox yakıtcombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fyattxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RENK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MARKA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox renktext;
        private System.Windows.Forms.TextBox yıltext;
        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.CheckedListBox boyalıListBox;
        private System.Windows.Forms.CheckedListBox degisenListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.TextBox serıtxt;
        private System.Windows.Forms.DateTimePicker ALIS_TARIH;
    }
}