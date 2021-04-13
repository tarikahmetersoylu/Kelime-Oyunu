
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.oyunuBaslat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Transparent;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.ForeColor = System.Drawing.Color.MidnightBlue;
            this.geri.Location = new System.Drawing.Point(29, 24);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(79, 36);
            this.geri.TabIndex = 0;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(261, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı İsmini Girin";
            // 
            // isim
            // 
            this.isim.BackColor = System.Drawing.Color.White;
            this.isim.ForeColor = System.Drawing.Color.Black;
            this.isim.Location = new System.Drawing.Point(276, 163);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(136, 20);
            this.isim.TabIndex = 2;
            this.isim.TextChanged += new System.EventHandler(this.isim_TextChanged);
            // 
            // oyunuBaslat
            // 
            this.oyunuBaslat.BackColor = System.Drawing.Color.Transparent;
            this.oyunuBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oyunuBaslat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunuBaslat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.oyunuBaslat.Location = new System.Drawing.Point(276, 215);
            this.oyunuBaslat.Name = "oyunuBaslat";
            this.oyunuBaslat.Size = new System.Drawing.Size(136, 37);
            this.oyunuBaslat.TabIndex = 3;
            this.oyunuBaslat.Text = "Oyunu Başlat";
            this.oyunuBaslat.UseVisualStyleBackColor = false;
            this.oyunuBaslat.Click += new System.EventHandler(this.oyunuBaslat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 387);
            this.Controls.Add(this.oyunuBaslat);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Oyunu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button oyunuBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox isim;
    }
}