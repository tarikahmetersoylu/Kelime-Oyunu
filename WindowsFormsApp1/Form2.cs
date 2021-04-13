using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string user;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void oyunuBaslat_Click(object sender, EventArgs e)
        {
            if (isim.Text == "")
            {
                MessageBox.Show("Lütfen bir isim girin.");
            }
            else {
                user = isim.Text;
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.isim.Text = isim.Text;
                anaSayfa.Show();
                this.Hide();
            }   
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            geri.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            geri.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            oyunuBaslat.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            oyunuBaslat.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
        }

        private void isim_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
