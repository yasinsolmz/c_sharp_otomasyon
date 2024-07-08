namespace WindowsFormsApp1
{
    partial class araclistele
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kmtext = new System.Windows.Forms.TextBox();
            this.yakıtcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kiratext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RENK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MARKA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.markacomb = new System.Windows.Forms.ComboBox();
            this.renktext = new System.Windows.Forms.TextBox();
            this.yıltext = new System.Windows.Forms.TextBox();
            this.plakatxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 36);
            this.button3.TabIndex = 40;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 36);
            this.button2.TabIndex = 39;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(58, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 38;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 429);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kmtext
            // 
            this.kmtext.Location = new System.Drawing.Point(165, 299);
            this.kmtext.Name = "kmtext";
            this.kmtext.Size = new System.Drawing.Size(147, 22);
            this.kmtext.TabIndex = 58;
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
            this.yakıtcombo.Location = new System.Drawing.Point(165, 351);
            this.yakıtcombo.Name = "yakıtcombo";
            this.yakıtcombo.Size = new System.Drawing.Size(147, 24);
            this.yakıtcombo.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "KİRA ÜCRETİ";
            // 
            // kiratext
            // 
            this.kiratext.Location = new System.Drawing.Point(165, 398);
            this.kiratext.Name = "kiratext";
            this.kiratext.Size = new System.Drawing.Size(147, 22);
            this.kiratext.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "YAKIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "KM";
            // 
            // RENK
            // 
            this.RENK.AutoSize = true;
            this.RENK.Location = new System.Drawing.Point(101, 251);
            this.RENK.Name = "RENK";
            this.RENK.Size = new System.Drawing.Size(44, 16);
            this.RENK.TabIndex = 52;
            this.RENK.Text = "RENK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "MODEL(YIL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "SERİ";
            // 
            // MARKA
            // 
            this.MARKA.AutoSize = true;
            this.MARKA.Location = new System.Drawing.Point(91, 119);
            this.MARKA.Name = "MARKA";
            this.MARKA.Size = new System.Drawing.Size(54, 16);
            this.MARKA.TabIndex = 49;
            this.MARKA.Text = "MARKA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "PLAKA";
            // 
            // sericombo
            // 
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(165, 160);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(147, 24);
            this.sericombo.TabIndex = 47;
            // 
            // markacomb
            // 
            this.markacomb.FormattingEnabled = true;
            this.markacomb.Items.AddRange(new object[] {
            "OPEL ",
            "RENAULT",
            "VOLKSVAGEN",
            "FİAT",
            "FORD"});
            this.markacomb.Location = new System.Drawing.Point(165, 111);
            this.markacomb.Name = "markacomb";
            this.markacomb.Size = new System.Drawing.Size(147, 24);
            this.markacomb.TabIndex = 46;
            // 
            // renktext
            // 
            this.renktext.Location = new System.Drawing.Point(165, 251);
            this.renktext.Name = "renktext";
            this.renktext.Size = new System.Drawing.Size(147, 22);
            this.renktext.TabIndex = 45;
            // 
            // yıltext
            // 
            this.yıltext.Location = new System.Drawing.Point(165, 208);
            this.yıltext.Name = "yıltext";
            this.yıltext.Size = new System.Drawing.Size(147, 22);
            this.yıltext.TabIndex = 44;
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(165, 71);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(147, 22);
            this.plakatxt.TabIndex = 43;
            // 
            // araclistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 550);
            this.Controls.Add(this.kmtext);
            this.Controls.Add(this.yakıtcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kiratext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RENK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MARKA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sericombo);
            this.Controls.Add(this.markacomb);
            this.Controls.Add(this.renktext);
            this.Controls.Add(this.yıltext);
            this.Controls.Add(this.plakatxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "araclistele";
            this.Text = "araclistele";
            this.Load += new System.EventHandler(this.araclistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kmtext;
        private System.Windows.Forms.ComboBox yakıtcombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kiratext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RENK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MARKA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.ComboBox markacomb;
        private System.Windows.Forms.TextBox renktext;
        private System.Windows.Forms.TextBox yıltext;
        private System.Windows.Forms.TextBox plakatxt;
    }
}