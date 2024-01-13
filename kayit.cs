using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Regex için ekledik
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace projeYonetimiVtys
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05O65PK\\SQLEXPRESS;Initial Catalog=proje_yonetimi_veritabani;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> hataMesajlari = new List<string>();

            if (textBox3.Text.Length < 3 || textBox3.Text.Length > 20)
            {
                hataMesajlari.Add("Kullanıcı adı 3-20 karakter arasında olmalıdır.");
            }

            if (textBox2.Text.Length < 5 || textBox2.Text.Length > 9 || !Regex.IsMatch(textBox2.Text, "[a-zA-Z]"))
            {
                hataMesajlari.Add("Şifre en az 5, en fazla 9 karakter ve en az bir harf içermelidir.");
            }

            if (!Regex.IsMatch(textBox1.Text, @"^\d{10}$"))
            {
                hataMesajlari.Add("Geçerli bir telefon numarası giriniz (örn: 1234567890).");

            }

            if (hataMesajlari.Any())
            {
                MessageBox.Show("Aşağıdaki hatalar oluştu:\n\n" + string.Join("\n", hataMesajlari));
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                return;

            }

            string sorgu = "INSERT INTO Kullanici (kullanici_id, sifre, kullanici_adi) VALUES (@telefon, @sifre, @kul)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@telefon", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            komut.Parameters.AddWithValue("@kul", textBox3.Text);

            try
            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu:\n" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

           
            this.Close();
           
        }


        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
