
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.cevapEkle = new System.Windows.Forms.TextBox();
            this.harfSayisiEkle = new System.Windows.Forms.TextBox();
            this.veritabaniDegerEkle = new System.Windows.Forms.Button();
            this.soruEkle = new System.Windows.Forms.RichTextBox();
            this.geri2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cevapEkle
            // 
            this.cevapEkle.Location = new System.Drawing.Point(353, 138);
            this.cevapEkle.Name = "cevapEkle";
            this.cevapEkle.Size = new System.Drawing.Size(100, 20);
            this.cevapEkle.TabIndex = 1;
            // 
            // harfSayisiEkle
            // 
            this.harfSayisiEkle.Location = new System.Drawing.Point(353, 262);
            this.harfSayisiEkle.Name = "harfSayisiEkle";
            this.harfSayisiEkle.Size = new System.Drawing.Size(100, 20);
            this.harfSayisiEkle.TabIndex = 2;
            // 
            // veritabaniDegerEkle
            // 
            this.veritabaniDegerEkle.BackColor = System.Drawing.Color.Transparent;
            this.veritabaniDegerEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.veritabaniDegerEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veritabaniDegerEkle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veritabaniDegerEkle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.veritabaniDegerEkle.Location = new System.Drawing.Point(554, 187);
            this.veritabaniDegerEkle.Name = "veritabaniDegerEkle";
            this.veritabaniDegerEkle.Size = new System.Drawing.Size(131, 42);
            this.veritabaniDegerEkle.TabIndex = 3;
            this.veritabaniDegerEkle.Text = "Ekle";
            this.veritabaniDegerEkle.UseVisualStyleBackColor = false;
            this.veritabaniDegerEkle.Click += new System.EventHandler(this.veritabaniDegerEkle_Click);
            // 
            // soruEkle
            // 
            this.soruEkle.BackColor = System.Drawing.Color.White;
            this.soruEkle.Location = new System.Drawing.Point(65, 123);
            this.soruEkle.Name = "soruEkle";
            this.soruEkle.Size = new System.Drawing.Size(196, 171);
            this.soruEkle.TabIndex = 4;
            this.soruEkle.Text = "";
            // 
            // geri2
            // 
            this.geri2.BackColor = System.Drawing.Color.Transparent;
            this.geri2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.geri2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.geri2.Location = new System.Drawing.Point(22, 24);
            this.geri2.Name = "geri2";
            this.geri2.Size = new System.Drawing.Size(79, 36);
            this.geri2.TabIndex = 5;
            this.geri2.Text = "Geri";
            this.geri2.UseVisualStyleBackColor = false;
            this.geri2.Click += new System.EventHandler(this.geri2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soru";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(353, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cevap";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(357, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harf Sayısı";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri2);
            this.Controls.Add(this.soruEkle);
            this.Controls.Add(this.veritabaniDegerEkle);
            this.Controls.Add(this.harfSayisiEkle);
            this.Controls.Add(this.cevapEkle);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cevapEkle;
        private System.Windows.Forms.TextBox harfSayisiEkle;
        private System.Windows.Forms.Button veritabaniDegerEkle;
        private System.Windows.Forms.RichTextBox soruEkle;
        private System.Windows.Forms.Button geri2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}