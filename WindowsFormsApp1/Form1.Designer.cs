
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.yeniOyun = new System.Windows.Forms.Button();
            this.enIyiler = new System.Windows.Forms.Button();
            this.soruEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yeniOyun
            // 
            this.yeniOyun.BackColor = System.Drawing.Color.Transparent;
            this.yeniOyun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniOyun.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniOyun.ForeColor = System.Drawing.Color.MidnightBlue;
            this.yeniOyun.Location = new System.Drawing.Point(589, 115);
            this.yeniOyun.Name = "yeniOyun";
            this.yeniOyun.Size = new System.Drawing.Size(121, 36);
            this.yeniOyun.TabIndex = 0;
            this.yeniOyun.Text = "Yeni Oyun";
            this.yeniOyun.UseMnemonic = false;
            this.yeniOyun.UseVisualStyleBackColor = false;
            this.yeniOyun.Click += new System.EventHandler(this.yeniOyun_Click);
            this.yeniOyun.MouseHover += new System.EventHandler(this.yeniOyun_MouseHover);
            // 
            // enIyiler
            // 
            this.enIyiler.BackColor = System.Drawing.Color.Transparent;
            this.enIyiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enIyiler.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enIyiler.ForeColor = System.Drawing.Color.MidnightBlue;
            this.enIyiler.Location = new System.Drawing.Point(589, 257);
            this.enIyiler.Name = "enIyiler";
            this.enIyiler.Size = new System.Drawing.Size(121, 36);
            this.enIyiler.TabIndex = 1;
            this.enIyiler.Text = "En İyiler";
            this.enIyiler.UseVisualStyleBackColor = false;
            this.enIyiler.Click += new System.EventHandler(this.enIyiler_Click);
            // 
            // soruEkle
            // 
            this.soruEkle.BackColor = System.Drawing.Color.Transparent;
            this.soruEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soruEkle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruEkle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.soruEkle.Location = new System.Drawing.Point(589, 186);
            this.soruEkle.Name = "soruEkle";
            this.soruEkle.Size = new System.Drawing.Size(121, 36);
            this.soruEkle.TabIndex = 2;
            this.soruEkle.Text = "Soru Ekle";
            this.soruEkle.UseVisualStyleBackColor = false;
            this.soruEkle.Click += new System.EventHandler(this.soruEkle_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(59, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 263);
            this.label1.TabIndex = 3;
            this.label1.Text = "KELİME\r\n      OYUNU\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soruEkle);
            this.Controls.Add(this.enIyiler);
            this.Controls.Add(this.yeniOyun);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Oyunu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button yeniOyun;
        private System.Windows.Forms.Button enIyiler;
        public System.Windows.Forms.Button soruEkle;
        private System.Windows.Forms.Label label1;
    }
}

