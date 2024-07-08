namespace cafeotomasyonu
{
    partial class Form1
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
            this.btnGarson = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGarson
            // 
            this.btnGarson.FlatAppearance.BorderSize = 0;
            this.btnGarson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGarson.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGarson.Image = global::cafeotomasyonu.Properties.Resources.Başlık2sız_2;
            this.btnGarson.Location = new System.Drawing.Point(346, 65);
            this.btnGarson.Name = "btnGarson";
            this.btnGarson.Size = new System.Drawing.Size(224, 128);
            this.btnGarson.TabIndex = 0;
            this.btnGarson.UseVisualStyleBackColor = true;
            this.btnGarson.Click += new System.EventHandler(this.btnGarson_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.FlatAppearance.BorderSize = 0;
            this.btnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYonetici.Image = global::cafeotomasyonu.Properties.Resources.Başlıksız_23;
            this.btnYonetici.Location = new System.Drawing.Point(346, 219);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(224, 128);
            this.btnYonetici.TabIndex = 0;
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = global::cafeotomasyonu.Properties.Resources.Başlıksız_25;
            this.btnCikis.Location = new System.Drawing.Point(387, 365);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(134, 63);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 20);
            this.BackgroundImage = global::cafeotomasyonu.Properties.Resources.Başlıksız_1;
            this.ClientSize = new System.Drawing.Size(640, 458);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.btnGarson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGarson;
    }
}

