using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        MySqlConnection con;
        public Form3()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kelimeOyunu;Uid=root;Pwd='root'");
        }

        private void geri2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void veritabaniDegerEkle_Click(object sender, EventArgs e)
        {
            if (soruEkle.Text != "" && cevapEkle.Text != "" && harfSayisiEkle.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dr;
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Connection = con;
                cmd.CommandText = "insert into sorular(soru, cevap, harfSayisi) values('" + soruEkle.Text + "','" + cevapEkle.Text + "','" + harfSayisiEkle.Text + "')";
                dr = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Bilgiler başarıyla eklendi.");
                soruEkle.Text = "";
                cevapEkle.Text = "";
                harfSayisiEkle.Text = "";
            }
            else
                MessageBox.Show("Lütfen tüm alanları doldurun.");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            geri2.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            geri2.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            veritabaniDegerEkle.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            veritabaniDegerEkle.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
