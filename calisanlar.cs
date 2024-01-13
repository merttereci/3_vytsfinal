using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeYonetimiVtys
{ 
    public partial class calisanlar : Form
    {
        public calisanlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05O65PK\\SQLEXPRESS;Initial Catalog=proje_yonetimi_veritabani;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DetayButton"].Index && e.RowIndex >= 0)
            {
                // DataGridView'dan seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // "calisan_id" değerini al
                string calisan_id = selectedRow.Cells["calisan_id"].Value.ToString();

                // Detay formunu aç
                detay detayForm = new detay(calisan_id);
                this.Close();
                detayForm.Show();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                // DataGridView'dan seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // "calisan_id" değerini al
                string calisan_id = selectedRow.Cells["calisan_id"].Value.ToString();

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();

                        // Silme sorgusunu oluştur
                        string silmeSorgusu = "DELETE FROM Calisan WHERE calisan_id = @id";
                        SqlCommand silKomut = new SqlCommand(silmeSorgusu, baglanti);

                        // Parametreyi ekleyerek SQL injection saldırılarından korun
                        silKomut.Parameters.AddWithValue("@id", calisan_id);

                        // Komutu çalıştır
                        silKomut.ExecuteNonQuery();

                        // Bağlantıyı kapat
                        baglanti.Close();

                        // Yeniden listeleme işlemini gerçekleştir
                        listele();

                        MessageBox.Show("Silme işlemi başarılı");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata var: " + hata.Message);
                }
            }
            else
            {

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    string kayit = "INSERT INTO Calisan (adi_soyadi) VALUES(@adSoyad)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    
                    komut.Parameters.AddWithValue("@adSoyad", textBox2.Text);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    listele();
                    MessageBox.Show("Kayit ekleme islemi basarili");
                 
                    textBox2.Clear();

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
        }

       
        

        private void calisanlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet4.Calisan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanTableAdapter2.Fill(this.proje_yonetimi_veritabaniDataSet4.Calisan);
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet1.Calisan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanTableAdapter1.Fill(this.proje_yonetimi_veritabaniDataSet1.Calisan);
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet1.Calisan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanTableAdapter1.Fill(this.proje_yonetimi_veritabaniDataSet1.Calisan);
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet.Proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.projeTableAdapter.Fill(this.proje_yonetimi_veritabaniDataSet.Proje);
            // TODO: Bu kod satırı 'proje_yonetimiDataSet.Calisan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


            listele();
        
           
        }

       

        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Calisan", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }
    } 
}
