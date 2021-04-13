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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        MySqlConnection con;
        public Form4()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kelimeOyunu;Uid=root;Pwd='root'");
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void geri3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            geri3.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            geri3.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sorgu = "select isim as 'İsim',skor as 'Skor',tarih as 'Tarih',kalanSure as 'Kalan Süre' from bilgiler order by skor desc limit 10;";
            MySqlCommand cmd = new MySqlCommand(sorgu, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            verileriGoster.DataSource = dt;
            con.Close();

        }

        private void verileriGoster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
