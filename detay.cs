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
using System.Xml.Linq;

namespace projeYonetimiVtys
{
    public partial class detay : Form
    {
        private string calisan_id;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05O65PK\\SQLEXPRESS;Initial Catalog=proje_yonetimi_veritabani;Integrated Security=True");

        public detay(string id)
        {


            InitializeComponent();
            this.calisan_id = id;
        }

        private void detay_Load(object sender, EventArgs e)
        {
            try
            {
                string calisanGorevSayisiSorgu = @"
        SELECT 
            COUNT(G.calisan_id) AS toplam_gorev
        FROM 
            Calisan C
        LEFT JOIN 
            Gorev G ON C.calisan_id = G.calisan_id
        WHERE 
            C.calisan_id = @calisanId
        GROUP BY 
            C.adi_soyadi";

                // SQL komutunu ve bağlantıyı oluştur
                using (SqlCommand calisanGorevSayisiKomut = new SqlCommand(calisanGorevSayisiSorgu, baglanti))
                {
                    // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                    calisanGorevSayisiKomut.Parameters.AddWithValue("@calisanId", calisan_id);

                    // Bağlantıyı aç
                    baglanti.Open();

                    // Veriyi al
                    object result = calisanGorevSayisiKomut.ExecuteScalar();

                    // Eğer veri varsa, TextBox'e ata
                    if (result != null && result != DBNull.Value)
                    {
                        label1.Text = "toplam görev sayısı: " + result.ToString() ;
                    }
                    else
                    {
                        label1.Text = "0"; // Veri yoksa sıfır olarak kabul et
                    }

                    // Bağlantıyı kapat
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }


            string adSoyadSorgu = "SELECT adi_soyadi FROM Calisan WHERE calisan_id = @calisanId";

            // SQL komutunu ve bağlantıyı oluştur
            using (SqlCommand adSoyadKomut = new SqlCommand(adSoyadSorgu, baglanti))
            {
                // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                adSoyadKomut.Parameters.AddWithValue("@calisanId", calisan_id);

                // Bağlantıyı aç
                baglanti.Open();

                // Veriyi çek
                object adSoyad = adSoyadKomut.ExecuteScalar();

                // Eğer veri bulunursa, label'a ata
                if (adSoyad != null)
                {
                    string adSoyadStr = adSoyad.ToString().Trim();
                    label2.Text = adSoyadStr + " isimli calışanın detayları:";
                }

                // Bağlantıyı kapat
                baglanti.Close();
            }
            string gorevSorgu = "SELECT * FROM Gorev WHERE calisan_id = @calisanId";

            // SQL komutunu ve bağlantıyı oluştur
            using (SqlCommand gorevKomut = new SqlCommand(gorevSorgu, baglanti))
            {
                // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                gorevKomut.Parameters.AddWithValue("@calisanId", calisan_id);

                // Bağlantıyı aç
                baglanti.Open();

                // Verileri çek
                SqlDataReader reader = gorevKomut.ExecuteReader();

                // Verileri DataGridView'e yükle
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;

                // Bağlantıyı kapat
                baglanti.Close();
            }

            string gorevDurumSorgu = @"
        SELECT 
            GD.durum_adi AS DurumAdı
        FROM 
            Gorev G
        INNER JOIN 
            GorevDurum GD ON G.durum_id = GD.durum_id
        WHERE 
            G.calisan_id = @calisanId";

            // SQL komutunu ve bağlantıyı oluştur
            using (SqlCommand gorevDurumKomut = new SqlCommand(gorevDurumSorgu, baglanti))
            {
                // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                gorevDurumKomut.Parameters.AddWithValue("@calisanId", calisan_id);

                // Bağlantıyı aç
                baglanti.Open();

                // Verileri çek
                SqlDataReader reader = gorevDurumKomut.ExecuteReader();

                // Verileri DataTable'e yükle
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // İkinci DataGridView'e veriyi yükle
                dataGridView2.DataSource = dataTable;

                // Bağlantıyı kapat
                baglanti.Close();
            }
            string gorevDurumSayılarıSorgu = @"
        SELECT 
            
            COUNT(G.calisan_id) AS gorev_sayısı,
           
            D.durum_adi,
            COUNT(G.durum_id) AS durum_adet
        FROM 
            Gorev G
        INNER JOIN 
            calisan C ON G.calisan_id = C.calisan_id
        INNER JOIN 
            GorevDurum D ON G.durum_id = D.durum_id
        WHERE 
            G.calisan_id = @calisanId
        GROUP BY 
            C.adi_soyadi, D.durum_id, D.durum_adi";

            // SQL komutunu ve bağlantıyı oluştur
            using (SqlCommand gorevDurumSayılarıKomut = new SqlCommand(gorevDurumSayılarıSorgu, baglanti))
            {
                // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                gorevDurumSayılarıKomut.Parameters.AddWithValue("@calisanId", calisan_id);

                // Bağlantıyı aç
                baglanti.Open();

                // Verileri çek
                SqlDataReader reader = gorevDurumSayılarıKomut.ExecuteReader();

                // Verileri DataTable'e yükle
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // İkinci DataGridView'e veriyi yükle
                dataGridView3.DataSource = dataTable;

                // Bağlantıyı kapat
                baglanti.Close();
            }

            //zamanında tamamlanmış görevler sayısı
            string zamanındaTamamlanmısSayıSorgu = @"
        SELECT 
            
            COUNT(G.calisan_id) AS zamanında_tamamlanmıs_gorev_sayısı
           
        FROM 
            Gorev G
        INNER JOIN 
            calisan C ON G.calisan_id = C.calisan_id
       
        WHERE 
            G.calisan_id = @calisanId AND G.durum_id = 2 AND gecikme_miktari <= 0 ";

            // SQL komutunu ve bağlantıyı oluştur
            using (SqlCommand zamanındaTamSorguKomut = new SqlCommand(zamanındaTamamlanmısSayıSorgu, baglanti))
            {
                // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                zamanındaTamSorguKomut.Parameters.AddWithValue("@calisanId", calisan_id);
                // Bağlantıyı aç
                baglanti.Open();
                // Verileri çek
                object result = zamanındaTamSorguKomut.ExecuteScalar();

                label3.Text = "zamanında tamamlanmış görev sayısı: " + result.ToString();


                // Bağlantıyı kapat
                baglanti.Close();
            }

            //geç tamamlanmış görevler sayısı
            string gecTamamlanmısSayıSorgu = @"
        SELECT 
            
            COUNT(G.calisan_id) AS zamanında_tamamlanmıs_gorev_sayısı
           
        FROM 
            Gorev G
        INNER JOIN 
            calisan C ON G.calisan_id = C.calisan_id
       
        WHERE 
            G.calisan_id = @calisanId AND G.durum_id = 2 AND gecikme_miktari > 0 ";

            // SQL komutunu ve bağlantıyı oluştur
            using (SqlCommand gecSorguKomut = new SqlCommand(gecTamamlanmısSayıSorgu, baglanti))
            {
                // Parametre ekleyerek SQL sorgusunu güvenli hale getir
                gecSorguKomut.Parameters.AddWithValue("@calisanId", calisan_id);
                // Bağlantıyı aç
                baglanti.Open();
                // Verileri çek
                object result2 = gecSorguKomut.ExecuteScalar();

                label4.Text = "geç görev sayısı: " + result2.ToString();


                // Bağlantıyı kapat
                baglanti.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // İhtiyaç duyulursa, gereksiz bir kod alanı olarak kalabilir
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calisanlar calisanlar = new calisanlar();
            calisanlar.Show();
            this.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
