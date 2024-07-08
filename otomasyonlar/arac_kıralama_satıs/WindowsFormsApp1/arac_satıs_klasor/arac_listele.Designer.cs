namespace WindowsFormsApp1.arac_satıs_klasor
{
    partial class arac_listele
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
            this.yakıtcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fyattxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RENK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MARKA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.renktext = new System.Windows.Forms.TextBox();
            this.yıltext = new System.Windows.Forms.TextBox();
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.seritxt = new System.Windows.Forms.TextBox();
            this.boyalıListBox = new System.Windows.Forms.CheckedListBox();
            this.degisenListBox = new System.Windows.Forms.CheckedListBox();
            this.ALIS_TARIH = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kmtext
            // 
            this.kmtext.Location = new System.Drawing.Point(166, 247);
            this.kmtext.Name = "kmtext";
            this.kmtext.Size = new System.Drawing.Size(147, 22);
            this.kmtext.TabIndex = 78;
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
            this.yakıtcombo.Location = new System.Drawing.Point(166, 299);
            this.yakıtcombo.Name = "yakıtcombo";
            this.yakıtcombo.Size = new System.Drawing.Size(147, 24);
            this.yakıtcombo.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "ALIŞ FİYATI";
            // 
            // fyattxt
            // 
            this.fyattxt.Location = new System.Drawing.Point(166, 341);
            this.fyattxt.Name = "fyattxt";
            this.fyattxt.Size = new System.Drawing.Size(147, 22);
            this.fyattxt.TabIndex = 75;
            this.fyattxt.TextChanged += new System.EventHandler(this.fyattxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "YAKIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "KM";
            // 
            // RENK
            // 
            this.RENK.AutoSize = true;
            this.RENK.Location = new System.Drawing.Point(100, 201);
            this.RENK.Name = "RENK";
            this.RENK.Size = new System.Drawing.Size(44, 16);
            this.RENK.TabIndex = 72;
            this.RENK.Text = "RENK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "MODEL(YIL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "SERİ";
            // 
            // MARKA
            // 
            this.MARKA.AutoSize = true;
            this.MARKA.Location = new System.Drawing.Point(90, 64);
            this.MARKA.Name = "MARKA";
            this.MARKA.Size = new System.Drawing.Size(54, 16);
            this.MARKA.TabIndex = 69;
            this.MARKA.Text = "MARKA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "PLAKA";
            // 
            // renktext
            // 
            this.renktext.Location = new System.Drawing.Point(166, 199);
            this.renktext.Name = "renktext";
            this.renktext.Size = new System.Drawing.Size(147, 22);
            this.renktext.TabIndex = 65;
            // 
            // yıltext
            // 
            this.yıltext.Location = new System.Drawing.Point(166, 156);
            this.yıltext.Name = "yıltext";
            this.yıltext.Size = new System.Drawing.Size(147, 22);
            this.yıltext.TabIndex = 64;
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(166, 19);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(147, 22);
            this.plakatxt.TabIndex = 63;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 36);
            this.button3.TabIndex = 62;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 36);
            this.button2.TabIndex = 61;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(36, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 60;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 429);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "DEĞİŞEN PARÇALAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 80;
            this.label8.Text = "BOYALI  PARÇALAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(760, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 81;
            this.label9.Text = "ÖYKÜ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 82;
            this.label10.Text = "ALIŞ TARİHİ";
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(166, 61);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(147, 22);
            this.markatxt.TabIndex = 83;
            // 
            // seritxt
            // 
            this.seritxt.Location = new System.Drawing.Point(166, 105);
            this.seritxt.Name = "seritxt";
            this.seritxt.Size = new System.Drawing.Size(147, 22);
            this.seritxt.TabIndex = 84;
            // 
            // boyalıListBox
            // 
            this.boyalıListBox.FormattingEnabled = true;
            this.boyalıListBox.Items.AddRange(new object[] {
            "KAPUT",
            "ÖN TAMPON",
            "SOL ÖN ÇAMURLUK",
            "SAG ÖN  ÇAMURLUK ",
            "SOL ÖN KAPI",
            "SOL ARKA KAPI",
            "SAĞ ÖN KAPI",
            "SAĞ ARKA KAPI",
            "BAGAJ"});
            this.boyalıListBox.Location = new System.Drawing.Point(316, 504);
            this.boyalıListBox.Name = "boyalıListBox";
            this.boyalıListBox.Size = new System.Drawing.Size(187, 72);
            this.boyalıListBox.TabIndex = 85;
            this.boyalıListBox.SelectedIndexChanged += new System.EventHandler(this.boyalıListBox_SelectedIndexChanged);
            // 
            // degisenListBox
            // 
            this.degisenListBox.FormattingEnabled = true;
            this.degisenListBox.Items.AddRange(new object[] {
            "KAPUT",
            "ÖN TAMPON",
            "SOL ÖN ÇAMURLUK",
            "SAG ÖN  ÇAMURLUK ",
            "SOL ÖN KAPI",
            "SOL ARKA KAPI",
            "SAĞ ÖN KAPI",
            "SAĞ ARKA KAPI",
            "BAGAJ"});
            this.degisenListBox.Location = new System.Drawing.Point(527, 504);
            this.degisenListBox.Name = "degisenListBox";
            this.degisenListBox.Size = new System.Drawing.Size(187, 72);
            this.degisenListBox.TabIndex = 86;
            this.degisenListBox.SelectedIndexChanged += new System.EventHandler(this.degisenListBox_SelectedIndexChanged);
            // 
            // ALIS_TARIH
            // 
            this.ALIS_TARIH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ALIS_TARIH.Location = new System.Drawing.Point(166, 393);
            this.ALIS_TARIH.Name = "ALIS_TARIH";
            this.ALIS_TARIH.Size = new System.Drawing.Size(145, 22);
            this.ALIS_TARIH.TabIndex = 87;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(763, 502);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(167, 74);
            this.richTextBox1.TabIndex = 88;
            this.richTextBox1.Text = "";
            // 
            // arac_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 773);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ALIS_TARIH);
            this.Controls.Add(this.degisenListBox);
            this.Controls.Add(this.boyalıListBox);
            this.Controls.Add(this.seritxt);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kmtext);
            this.Controls.Add(this.yakıtcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fyattxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RENK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MARKA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.renktext);
            this.Controls.Add(this.yıltext);
            this.Controls.Add(this.plakatxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "arac_listele";
            this.Text = "arac_listele";
            this.Load += new System.EventHandler(this.arac_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kmtext;
        private System.Windows.Forms.ComboBox yakıtcombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fyattxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RENK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MARKA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox renktext;
        private System.Windows.Forms.TextBox yıltext;
        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.TextBox seritxt;
        private System.Windows.Forms.CheckedListBox boyalıListBox;
        private System.Windows.Forms.CheckedListBox degisenListBox;
        private System.Windows.Forms.DateTimePicker ALIS_TARIH;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}