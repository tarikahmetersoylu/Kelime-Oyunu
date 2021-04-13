using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class AnaSayfa : Form
    {
        MySqlConnection con;
        string tarih;
        string cevap;
        static string eskiCevap = "";
        string soru;
        Hashtable harfler = new Hashtable();
        Hashtable harflerYerlestir = new Hashtable();
        Random random = new Random();
        static int harfSayisi = 4;
        static int döngü = 2;
        static int GenelPuan = 0;
        static int SoruPuani = 0;
        int m = 3;
        int s = 59;
        int m1 = 0;
        int s1 = 19;
        public AnaSayfa()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kelimeOyunu;Uid=root;Pwd='root'");
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            sonucLabel.Visible = false;
            tamam.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            tamam.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            harfAl.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            harfAl.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            anaSayfaDon.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            anaSayfaDon.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            cevapla.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            cevapla.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            siradaki.FlatAppearance.MouseOverBackColor = Color.MediumVioletRed;
            siradaki.FlatAppearance.MouseDownBackColor = Color.MediumVioletRed;
            anaSayfaDon.Visible = false;
            tarih = DateTime.Now.ToString("dd'-'MM'-'yyyy' 'HH':'mm':'ss");
            timer1.Start();
            isim.Visible = false;
            cevaplaSayaci.Visible = false;
            siradaki.Visible = false;
            cevapGir.Enabled = false;
            harf5.Visible = false;
            harf6.Visible = false;
            harf7.Visible = false;
            harf9.Visible = false;
            harf8.Visible = false;
            harf10.Visible = false;
            tamam.Visible = false;
            soruGetir();
            soruIlerlet();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void harf8_Click(object sender, EventArgs e)
        {

        }
        public void soruGetir()
        {
            
            if (con.State == ConnectionState.Closed) {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = con;
            cmd.CommandText = "select * from sorular where harfSayisi=" + harfSayisi + " and cevap!='" + eskiCevap + "' order by rand() limit 1";
            dr = cmd.ExecuteReader();
            while (dr.Read()){
                cevap = Convert.ToString(dr["cevap"]).ToUpper();
                soru = Convert.ToString(dr["soru"]).ToUpper();
                harfSayisi = Convert.ToInt32(dr["harfSayisi"]);
                eskiCevap = cevap;
            }
            dr.Close();
            con.Close();
            for (int i = 0; i < harfSayisi; i++)
            {
                harfler.Add(i, cevap[i]);
                harflerYerlestir.Add(i, cevap[i]);
            }
            soruGoster.Text = soru;
            soruPuani.Text = Convert.ToString(harfSayisi * 100);
            SoruPuani = harfSayisi * 100;
        }

        public void soruIlerlet()
        {
            if (döngü == 0)
            {
                döngü = 1;
                harfSayisi = harfSayisi + 1; ;
            }
            else
            {
                döngü = döngü - 1; ;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            genelSayac.Text = m + ":" + s;
            if (s == 0)
            {
                if (m == 0)
                {
                    timer1.Stop();
                    ekle();
                    txtYaz();
                    anaSayfaDon.Visible = true;
                    MessageBox.Show("Süreniz Doldu. Yarışmayı tamamladınız.");
                    siradaki.Visible = false;
                    cevapGir.Visible = false;
                    cevapGirLabel.Visible = false;
                    cevapla.Visible = false;
                    harfAl.Visible = false;
                    sonucLabel.Visible = true;
                    sonucLabel.Text = "İsim: " + isim.Text + " - Skor: " + genelPuan.Text + " - Tarih: " + tarih + " - Kalan Süre: " + genelSayac.Text;
                }
                else
                {
                    m = m - 1;
                    s = 60;
                }
            }
            s = s - 1;
        }

        private void cevapla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            cevapla.Visible = false;
            harfAl.Visible = false;
            tamam.Visible = true;
            timer2.Start();
            cevapGir.Enabled = true;
            cevaplaSayaci.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cevaplaSayaci.Text = m1 + ":" + s1;
            if (s1 == 0)
            {
                if (m1 == 0)
                {
                    if (döngü == 0 && harfSayisi == 10)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        harfAl.Visible = false;
                        cevapla.Visible = false;
                        siradaki.Visible = false;
                        tamam.Visible = false;
                        GenelPuan = GenelPuan - Convert.ToInt32(soruPuani.Text);
                        genelPuan.Text = Convert.ToString(GenelPuan);
                        ekle();
                        txtYaz();
                        MessageBox.Show("Süreniz doldu.");
                        MessageBox.Show("Tebrikler. Yarışmayı tamamladınız.");
                        anaSayfaDon.Visible = true;
                        cevapGir.Visible = false;
                        cevapGirLabel.Visible = false;
                        sonucLabel.Visible = true;
                        sonucLabel.Text = "İsim: " + isim.Text + " - Skor: " + genelPuan.Text + " - Tarih: " + tarih + " - Kalan Süre: " + genelSayac.Text;
                    }
                    else
                    {
                        timer2.Stop();
                        yerlestir();
                        cevapGir.Enabled = false;
                        tamam.Visible = false;
                        harfler.Clear();
                        harflerYerlestir.Clear();
                        cevaplaSayaci.Visible = false;
                        cevaplaSayaci.Text = "0:20";
                        m1 = 0;
                        s1 = 20;
                        GenelPuan = GenelPuan - Convert.ToInt32(soruPuani.Text);
                        genelPuan.Text = Convert.ToString(GenelPuan);
                        MessageBox.Show("Süreniz Doldu.");
                        siradaki.Visible = true;
                    }
                }
                else
                {
                    m1 = m1 - 1;
                    s1 = 20;
                }
            }

            s1 = s1 - 1;
        }

        private void harfAl_Click(object sender, EventArgs e)
        {
            
            HarfAl();
            if (harfler.Count == 0)
            {
                if (döngü == 0 && harfSayisi == 10)
                {
                    timer1.Stop();
                    harfAl.Visible = false;
                    cevapla.Visible = false;
                    siradaki.Visible = false;
                    ekle();
                    txtYaz();
                    MessageBox.Show("Tebrikler. Yarışmayı tamamladınız.");
                    anaSayfaDon.Visible = true;
                    cevapGir.Visible = false;
                    cevapGirLabel.Visible = false;
                    sonucLabel.Visible = true;
                    sonucLabel.Text = "İsim: " + isim.Text + " - Skor: " + genelPuan.Text + " - Tarih: " + tarih + " - Kalan Süre: " + genelSayac.Text;
                }
                else{
                    timer1.Stop();
                    MessageBox.Show("Sorudan hiç puan kazanamadınız. Sıradaki soruya geçin.");
                    cevapGir.Enabled = false;
                    cevapla.Visible = false;
                    harfAl.Visible = false;
                    siradaki.Visible = true;
                }
            }
            SoruPuani = SoruPuani - 100;
            soruPuani.Text = Convert.ToString(SoruPuani);


        }


        public void HarfAl()
        {
            int index = random.Next(0, harfSayisi + 1);
            harfYerlestir(index);
        }
        public void harfYerlestir(int index)
        {
            if (harfler.ContainsKey(index)==true)
            {
                if (index == 0)
                {
                    harf1.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 1)
                {
                    harf2.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 2)
                {
                    harf3.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 3)
                {
                    harf4.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 4)
                {
                    harf5.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 5)
                {
                    harf6.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 6)
                {
                    harf7.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 7)
                {
                    harf8.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 8)
                {
                    harf9.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
                else if (index == 9)
                {
                    harf10.Text = Convert.ToString(cevap[index]);
                    harfler.Remove(index);
                }
            }
            else
            {
                index = random.Next(0, harfSayisi + 1);
                harfYerlestir(index);
            }
        }
        private void isim_Click(object sender, EventArgs e)
        {

        }

        private void harf3_Click(object sender, EventArgs e)
        {

        }

        private void siradaki_Click(object sender, EventArgs e)
        {
            harflerYerlestir.Clear();
            siradaki.Visible = false;
            cevapGir.Enabled = false;
            timer1.Start();
            cevapla.Visible = true;
            harfAl.Visible = true;
            harf1.Text = "___";
            harf2.Text = "___";
            harf3.Text = "___";
            harf4.Text = "___";
            harf5.Text = "___";
            harf6.Text = "___";
            harf7.Text = "___";
            harf9.Text = "___";
            harf8.Text = "___";
            harf10.Text = "___";
            soruIlerlet();
            soruGetir();
            switch (harfSayisi)
            {
                case 4:
                    harf4.Visible = true;
                    break;
                case 5:
                    harf5.Visible = true;
                    break;
                case 6:
                    harf6.Visible = true;
                    break;
                case 7:
                    harf7.Visible = true;
                    break;
                case 8:
                    harf8.Visible = true;
                    break;
                case 9:
                    harf9.Visible = true;
                    break;
                default:
                    harf10.Visible = true;
                    break;

            }
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            cevapGir.Enabled = false;
            tamam.Visible = false;
            yerlestir();
            if (cevapGir.Text.ToUpper() == cevap)
            {
                GenelPuan = GenelPuan + Convert.ToInt32(soruPuani.Text);
                MessageBox.Show("Tebrikler. Doğru cevap.");
            }
            else
            {
                GenelPuan = GenelPuan - Convert.ToInt32(soruPuani.Text);
                MessageBox.Show("Malesef. Yanlış cevap.");
            }
            genelPuan.Text = Convert.ToString(GenelPuan);
            if (döngü == 0 && harfSayisi == 10)
            {
                timer2.Stop();
                MessageBox.Show("Tebrikler. Yarışmayı tamamladınız.");
                siradaki.Visible = false;
                ekle();
                txtYaz();
                anaSayfaDon.Visible = true;
                cevapGir.Visible = false;
                cevapGirLabel.Visible = false;
                sonucLabel.Visible = true;
                sonucLabel.Text = "İsim: " + isim.Text + " - Skor: " + genelPuan.Text + " - Tarih: " + tarih + " - Kalan Süre: " + genelSayac.Text ;
            }
            else
            {
                tamam.Visible = false;
                siradaki.Visible = true;
                timer2.Stop();
                m1 = 0;
                s1 = 19;
                cevaplaSayaci.Text = "0:20";
                harfler.Clear();
                harflerYerlestir.Clear();
                cevapGir.Text = "";
                cevaplaSayaci.Visible = false;
            }
        }

        public void kaydet()
        {

        }

        public void  ekle() {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed){
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandText = "insert into bilgiler(isim, skor, tarih, kalanSure) values('" + isim.Text + "','" + genelPuan.Text + "','" + tarih + "','" + genelSayac.Text.ToString() + "')";
            dr = cmd.ExecuteReader();
            con.Close();
        }

        public void txtYaz()
        {
            StreamWriter bilgiler = new StreamWriter(@"C:\Users\user\source\repos\WindowsFormsApp1\skorlar.txt", true);
            bilgiler.WriteLine("İsim: " + isim.Text + " - Puan: " + genelPuan.Text + " - Tarih: " + tarih + " - Kalan Süre: " + genelSayac.Text.ToString() + "\n");
            bilgiler.Close();
        }
        public void yerlestir()
        {
            harf1.Text = Convert.ToString(harflerYerlestir[0]);
            harf2.Text = Convert.ToString(harflerYerlestir[1]);
            harf3.Text = Convert.ToString(harflerYerlestir[2]);
            harf4.Text = Convert.ToString(harflerYerlestir[3]);
            if (harf5.Visible == true)
                harf5.Text = Convert.ToString(harflerYerlestir[4]);
            if (harf6.Visible == true)
                harf6.Text = Convert.ToString(harflerYerlestir[5]);
            if (harf7.Visible == true)
                harf7.Text = Convert.ToString(harflerYerlestir[6]);
            if (harf8.Visible == true)
                harf8.Text = Convert.ToString(harflerYerlestir[7]);
            if (harf9.Visible == true)
                harf9.Text = Convert.ToString(harflerYerlestir[8]);
            if (harf10.Visible == true)
                harf10.Text = Convert.ToString(harflerYerlestir[9]);
        }
        public void don()
        {
            Form1 don = new Form1();
            don.Show();
            this.Hide();
        }

        private void anaSayfaDon_Click(object sender, EventArgs e)
        {
            harfSayisi = 4;
            döngü = 2;
            GenelPuan = 0;
            SoruPuani = 0;
            harfler.Clear();
            harflerYerlestir.Clear();
            don();
        }

        private void soruGoster_Click(object sender, EventArgs e)
        {

        }

        private void cevaplaSayaci_Click(object sender, EventArgs e)
        {

        }
    }
}
