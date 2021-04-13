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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniOyun_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void soruEkle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void yeniOyun_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yeniOyun.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            yeniOyun.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            soruEkle.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            soruEkle.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            enIyiler.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            enIyiler.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void enIyiler_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
