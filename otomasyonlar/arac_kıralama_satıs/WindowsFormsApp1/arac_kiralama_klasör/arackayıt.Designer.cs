namespace WindowsFormsApp1
{
    partial class arackayıt
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
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.yıltext = new System.Windows.Forms.TextBox();
            this.renktext = new System.Windows.Forms.TextBox();
            this.markacomb = new System.Windows.Forms.ComboBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MARKA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RENK = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kiratext = new System.Windows.Forms.TextBox();
            this.yakıtcombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kmtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plakatxt
            // 
            this.plakatxt.Location = new System.Drawing.Point(141, 59);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(147, 22);
            this.plakatxt.TabIndex = 0;
            // 
            // yıltext
            // 
            this.yıltext.Location = new System.Drawing.Point(141, 196);
            this.yıltext.Name = "yıltext";
            this.yıltext.Size = new System.Drawing.Size(147, 22);
            this.yıltext.TabIndex = 1;
            // 
            // renktext
            // 
            this.renktext.Location = new System.Drawing.Point(515, 59);
            this.renktext.Name = "renktext";
            this.renktext.Size = new System.Drawing.Size(147, 22);
            this.renktext.TabIndex = 2;
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
            this.markacomb.Location = new System.Drawing.Point(141, 99);
            this.markacomb.Name = "markacomb";
            this.markacomb.Size = new System.Drawing.Size(147, 24);
            this.markacomb.TabIndex = 14;
            this.markacomb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sericombo
            // 
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(141, 148);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(147, 24);
            this.sericombo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "PLAKA";
            // 
            // MARKA
            // 
            this.MARKA.AutoSize = true;
            this.MARKA.Location = new System.Drawing.Point(67, 107);
            this.MARKA.Name = "MARKA";
            this.MARKA.Size = new System.Drawing.Size(54, 16);
            this.MARKA.TabIndex = 18;
            this.MARKA.Text = "MARKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "SERİ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "MODEL(YIL)";
            // 
            // RENK
            // 
            this.RENK.AutoSize = true;
            this.RENK.Location = new System.Drawing.Point(451, 59);
            this.RENK.Name = "RENK";
            this.RENK.Size = new System.Drawing.Size(44, 16);
            this.RENK.TabIndex = 21;
            this.RENK.Text = "RENK";
            this.RENK.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "KM";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "YAKIT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "KİRA ÜCRETİ";
            // 
            // kiratext
            // 
            this.kiratext.Location = new System.Drawing.Point(515, 206);
            this.kiratext.Name = "kiratext";
            this.kiratext.Size = new System.Drawing.Size(147, 22);
            this.kiratext.TabIndex = 24;
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
            this.yakıtcombo.Location = new System.Drawing.Point(515, 159);
            this.yakıtcombo.Name = "yakıtcombo";
            this.yakıtcombo.Size = new System.Drawing.Size(147, 24);
            this.yakıtcombo.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "KAYIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kmtext
            // 
            this.kmtext.Location = new System.Drawing.Point(515, 107);
            this.kmtext.Name = "kmtext";
            this.kmtext.Size = new System.Drawing.Size(147, 22);
            this.kmtext.TabIndex = 29;
            // 
            // arackayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kmtext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yakıtcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kiratext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RENK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MARKA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sericombo);
            this.Controls.Add(this.markacomb);
            this.Controls.Add(this.renktext);
            this.Controls.Add(this.yıltext);
            this.Controls.Add(this.plakatxt);
            this.Name = "arackayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arackayıt";
            this.Load += new System.EventHandler(this.arackayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.TextBox yıltext;
        private System.Windows.Forms.TextBox renktext;
        private System.Windows.Forms.ComboBox markacomb;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MARKA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RENK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kiratext;
        private System.Windows.Forms.ComboBox yakıtcombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox kmtext;
    }
}