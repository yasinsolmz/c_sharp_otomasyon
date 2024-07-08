namespace cafeotomasyonu
{
    partial class Menu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdcorba = new System.Windows.Forms.RadioButton();
            this.rdpide = new System.Windows.Forms.RadioButton();
            this.rdkebap = new System.Windows.Forms.RadioButton();
            this.rdtatlı = new System.Windows.Forms.RadioButton();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-15, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdcorba
            // 
            this.rdcorba.AutoSize = true;
            this.rdcorba.Location = new System.Drawing.Point(220, 129);
            this.rdcorba.Name = "rdcorba";
            this.rdcorba.Size = new System.Drawing.Size(53, 17);
            this.rdcorba.TabIndex = 3;
            this.rdcorba.TabStop = true;
            this.rdcorba.Text = "Çorba";
            this.rdcorba.UseVisualStyleBackColor = true;
            // 
            // rdpide
            // 
            this.rdpide.AutoSize = true;
            this.rdpide.Location = new System.Drawing.Point(220, 164);
            this.rdpide.Name = "rdpide";
            this.rdpide.Size = new System.Drawing.Size(46, 17);
            this.rdpide.TabIndex = 3;
            this.rdpide.TabStop = true;
            this.rdpide.Text = "Pide";
            this.rdpide.UseVisualStyleBackColor = true;
            // 
            // rdkebap
            // 
            this.rdkebap.AutoSize = true;
            this.rdkebap.Location = new System.Drawing.Point(220, 94);
            this.rdkebap.Name = "rdkebap";
            this.rdkebap.Size = new System.Drawing.Size(56, 17);
            this.rdkebap.TabIndex = 3;
            this.rdkebap.TabStop = true;
            this.rdkebap.Text = "Kebap";
            this.rdkebap.UseVisualStyleBackColor = true;
            // 
            // rdtatlı
            // 
            this.rdtatlı.AutoSize = true;
            this.rdtatlı.Location = new System.Drawing.Point(221, 62);
            this.rdtatlı.Name = "rdtatlı";
            this.rdtatlı.Size = new System.Drawing.Size(45, 17);
            this.rdtatlı.TabIndex = 3;
            this.rdtatlı.TabStop = true;
            this.rdtatlı.Text = "Tatlı";
            this.rdtatlı.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = global::cafeotomasyonu.Properties.Resources.Başlıksız_5;
            this.btnCikis.Location = new System.Drawing.Point(645, 307);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(66, 59);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yemek Adı";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafeotomasyonu.Properties.Resources._111111;
            this.ClientSize = new System.Drawing.Size(736, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.rdtatlı);
            this.Controls.Add(this.rdkebap);
            this.Controls.Add(this.rdpide);
            this.Controls.Add(this.rdcorba);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdcorba;
        private System.Windows.Forms.RadioButton rdpide;
        private System.Windows.Forms.RadioButton rdkebap;
        private System.Windows.Forms.RadioButton rdtatlı;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
    }
}