using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace projeYonetimiVtys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05O65PK\\SQLEXPRESS;Initial Catalog=proje_yonetimi_veritabani;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //KAYIT OL
        {
            kayit frm = new kayit();  //kayit ol butonuna basıldığında kayıt olma sayfasına götürür
            frm.Show();
          
           
        }

        private void button1_Click(object sender, EventArgs e) //GİRİŞ
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // Kullanıcı adı için minimum 3, maksimum 8 karakter kontrolü
            if (kullaniciAdi.Length < 3 || kullaniciAdi.Length > 8)
            {
                MessageBox.Show("Kullanıcı adı 3 ile 8 karakter arasında olmalıdır.");
                textBox1.Clear();
                return;
            }

            // Şifre için maksimum 9 karakter kontrolü
            if (sifre.Length > 9)
            {
                MessageBox.Show("Şifre en fazla 9 karakter olmalıdır.");
                textBox2.Clear();
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Kullanici WHERE kullanici_adi = '" + kullaniciAdi + "' AND sifre = '" + sifre + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                // Veri girişi başarılıysa ana sayfaya yönlendir
               
                anasayfa frm = new anasayfa();
                frm.Show();
                
               
               
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                // Hatalı giriş durumunda uyarı mesajı gösterme
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                textBox1.Clear();
                textBox2.Clear();
            }

            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
