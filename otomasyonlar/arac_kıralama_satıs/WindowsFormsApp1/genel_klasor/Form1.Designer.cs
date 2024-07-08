namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BAŞLIK = new System.Windows.Forms.Label();
            this.GALERİ = new System.Windows.Forms.Label();
            this.KİRALAMA = new System.Windows.Forms.Label();
            this.GALERİ_BUTTON = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAŞLIK
            // 
            this.BAŞLIK.AutoSize = true;
            this.BAŞLIK.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BAŞLIK.Location = new System.Drawing.Point(100, 53);
            this.BAŞLIK.MaximumSize = new System.Drawing.Size(0, 50);
            this.BAŞLIK.Name = "BAŞLIK";
            this.BAŞLIK.Size = new System.Drawing.Size(589, 31);
            this.BAŞLIK.TabIndex = 0;
            this.BAŞLIK.Text = "ARAÇ ALIM SATIM VE KİRALAMA OTOMASYONU";
            this.BAŞLIK.Click += new System.EventHandler(this.label1_Click);
            // 
            // GALERİ
            // 
            this.GALERİ.AutoSize = true;
            this.GALERİ.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GALERİ.Location = new System.Drawing.Point(14, 213);
            this.GALERİ.Name = "GALERİ";
            this.GALERİ.Size = new System.Drawing.Size(320, 25);
            this.GALERİ.TabIndex = 1;
            this.GALERİ.Text = "ARAÇ ALIM SATIM İÇİN TIKLAYIN";
            // 
            // KİRALAMA
            // 
            this.KİRALAMA.AutoSize = true;
            this.KİRALAMA.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KİRALAMA.Location = new System.Drawing.Point(464, 213);
            this.KİRALAMA.Name = "KİRALAMA";
            this.KİRALAMA.Size = new System.Drawing.Size(307, 25);
            this.KİRALAMA.TabIndex = 2;
            this.KİRALAMA.Text = "ARAÇ KİRALAMA İÇİN TIKLAYIN";
            // 
            // GALERİ_BUTTON
            // 
            this.GALERİ_BUTTON.BackColor = System.Drawing.Color.Lavender;
            this.GALERİ_BUTTON.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GALERİ_BUTTON.Location = new System.Drawing.Point(109, 252);
            this.GALERİ_BUTTON.Name = "GALERİ_BUTTON";
            this.GALERİ_BUTTON.Size = new System.Drawing.Size(118, 41);
            this.GALERİ_BUTTON.TabIndex = 4;
            this.GALERİ_BUTTON.Text = "TIKLAYINIZ";
            this.GALERİ_BUTTON.UseVisualStyleBackColor = false;
            this.GALERİ_BUTTON.Click += new System.EventHandler(this.GALERİ_BUTTON_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(558, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "TIKLAYINIZ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(334, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "KULLANICI KAYDI İÇİN TIKLAYIN";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(334, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "TIKLAYINIZ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(822, 556);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAŞLIK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GALERİ_BUTTON);
            this.Controls.Add(this.KİRALAMA);
            this.Controls.Add(this.GALERİ);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BAŞLIK;
        private System.Windows.Forms.Label GALERİ;
        private System.Windows.Forms.Label KİRALAMA;
        private System.Windows.Forms.Button GALERİ_BUTTON;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

