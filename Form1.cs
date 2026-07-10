using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace ExcelVeriTabanıEntegrasyonu
{
    public partial class Form1 : Form
    {
        string baglanti = @"Data Source=DESKTOP-APJ1FA6\SQLEXPRESS;Initial Catalog=DB_Excel;Integrated Security=True;TrustServerCertificate=True";
        string masaustu;
        string klasor;
        string dosya;
        string excelDosyaYolu;
        public Form1()
        {
            InitializeComponent();
            masaustu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            klasor = Path.Combine(masaustu, "Personel");
            dosya = Path.Combine(klasor, "log.txt");

            Directory.CreateDirectory(klasor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_KayitEkle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection dbBaglanti = new SqlConnection(baglanti);
                SqlCommand sqlKayitEkle = new SqlCommand("INSERT INTO Personel (Ad,Soyad,Maas) VALUES (@Ad,@Soyad,@Maas)", dbBaglanti);
                dbBaglanti.Open();

                sqlKayitEkle.Parameters.AddWithValue("@Ad", txt_Ad.Text);
                sqlKayitEkle.Parameters.AddWithValue("@Soyad", txt_Soyad.Text);
                sqlKayitEkle.Parameters.AddWithValue("@Maas", Convert.ToInt32(txt_Maas.Text));
                sqlKayitEkle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                dbBaglanti.Close();

                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} Kayıt Eklendi {Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();


            }
            catch (Exception baglantiHata)
            {
                MessageBox.Show(baglantiHata.Message + "Bağlantı hatası oluştu");
                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} {baglantiHata.Message} {Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection dbBaglanti = new SqlConnection(baglanti);
                dbBaglanti.Open();
                SqlCommand sqlKayitGuncelle = new SqlCommand("UPDATE Personel Set Ad=@Ad, " +
                    " Soyad=@Soyad, Maas=@Maas WHERE PersonelID=@PersonelID", dbBaglanti);

                sqlKayitGuncelle.Parameters.AddWithValue("@Ad", txt_Ad.Text);
                sqlKayitGuncelle.Parameters.AddWithValue("@Soyad", txt_Soyad.Text);
                sqlKayitGuncelle.Parameters.AddWithValue("@Maas", Convert.ToInt32(txt_Maas.Text));
                sqlKayitGuncelle.Parameters.AddWithValue("@PersonelID", Convert.ToInt32(txt_PersonelID.Text));
                sqlKayitGuncelle.ExecuteNonQuery();

                dbBaglanti.Close();


                MessageBox.Show("Kayıt güncellendi.");
                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} Kayıt Güncellendi {Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();

            }
            catch (Exception baglantiHata)
            {
                MessageBox.Show(baglantiHata.Message + "Bağlantı hatası olustu");
                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} {baglantiHata.Message} {Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();
            }

        }

        private void btn_KayitSil_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlBaglanti = new SqlConnection(baglanti);
                    sqlBaglanti.Open();

                    SqlCommand sqlKayitSil = new SqlCommand("DELETE FROM Personel WHERE PersonelID=@ID", sqlBaglanti);

                    sqlKayitSil.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_PersonelID.Text));
                    sqlKayitSil.ExecuteNonQuery();

                    sqlBaglanti.Close();

                    MessageBox.Show("Kayıt Silindi");

                    File.AppendAllText(dosya,
                        $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} Kayıt Silindi{Environment.NewLine}");

                    txt_Ad.Clear();
                    txt_Soyad.Clear();
                    txt_Maas.Clear();
                    txt_PersonelID.Clear();
                }
                catch (Exception baglantiHata)
                {
                    MessageBox.Show(baglantiHata.Message + " Bağlantı hatası oluştu");

                    File.AppendAllText(dosya,
                        $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} {baglantiHata.Message}{Environment.NewLine}");

                    txt_Ad.Clear();
                    txt_Soyad.Clear();
                    txt_Maas.Clear();
                    txt_PersonelID.Clear();
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
            }








        }

        private void btn_ButunKayitlar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlBaglanti = new SqlConnection(baglanti);
                sqlBaglanti.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Personel", sqlBaglanti);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                sqlBaglanti.Close();
                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} Bütün kayıtlar arandı {Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();
            }
            catch (Exception baglantiHata)
            {
                MessageBox.Show(baglantiHata.Message + "Bağlantı hatası oluştu");
                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} {baglantiHata.Message} {Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();
            }
        }

        private void btn_PersonelAra_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlBaglanti = new SqlConnection(baglanti);
                sqlBaglanti.Open();

                SqlCommand sqlPersonelAra = new SqlCommand("SELECT * FROM Personel Where Ad=@Ad OR Soyad=@Soyad OR Maas=@Maas", sqlBaglanti);

                sqlPersonelAra.Parameters.AddWithValue("@Ad", txt_Ad.Text);
                sqlPersonelAra.Parameters.AddWithValue("@Soyad", txt_Soyad.Text);

                if (string.IsNullOrWhiteSpace(txt_Maas.Text))
                {
                    sqlPersonelAra.Parameters.AddWithValue("@Maas", -1);
                }
                else
                {
                    sqlPersonelAra.Parameters.AddWithValue("@Maas", Convert.ToInt32(txt_Maas.Text));
                }

                sqlPersonelAra.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlPersonelAra);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                sqlBaglanti.Close();

                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} Personel kaydı arandı {Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();

            }

            catch (Exception baglantiHata)
            {
                MessageBox.Show(baglantiHata.Message + "Bağlantı hatası oluştu");
                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} {baglantiHata.Message} {Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void btn_MaxMinMaas_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlBaglanti = new SqlConnection(baglanti);
                sqlBaglanti.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Personel WHERE Maas = (SELECT MIN(Maas) FROM Personel) OR Maas = (SELECT MAX(Maas) FROM Personel)",
                    sqlBaglanti);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                sqlBaglanti.Close();

                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} Min ve Max maaşlı personeller listelendi{Environment.NewLine}");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();
            }
            catch (Exception baglantiHata)
            {
                MessageBox.Show(baglantiHata.Message + "Bağlantı hatası oluştu");

                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();
            }

        }

        private void btnHarfleAra_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlBaglanti = new SqlConnection(baglanti);
                sqlBaglanti.Open();

                SqlCommand sqlHarfleAra = new SqlCommand("SELECT * FROM Personel WHERE Ad LIKE @Ad OR Soyad LIKE @Soyad", sqlBaglanti);

                sqlHarfleAra.Parameters.AddWithValue("@Ad", "%" + txt_Ad.Text + "%");
                sqlHarfleAra.Parameters.AddWithValue("@Soyad", "%" + txt_Soyad.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlHarfleAra);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                sqlBaglanti.Close();

                File.AppendAllText(dosya,
                    $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} Personel harfle arandı{Environment.NewLine}");
            }
            catch (Exception baglantiHata)
            {
                MessageBox.Show(baglantiHata.Message + "Bağlantı hatası oluştu");
                File.AppendAllText(dosya, $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} {baglantiHata.Message} {Environment.NewLine}");


                txt_Ad.Clear();
                txt_Soyad.Clear();
                txt_Maas.Clear();
                txt_PersonelID.Clear();
            }
        }

        private void btn_ExceleAktar_Click(object sender, EventArgs e)
        {
            //DataTable → Daha kısa ve kolay.
            //SqlDataReader → Daha performanslı ama daha fazla kod yazılır.

            // Junior seviyesinde DataTable kullanmak en yaygın ve en uygun yöntemdir. Profesyonel projelerde de Excel'e 
            //   aktarırken DataTable sıkça kullanılır.
            try
            {

                SqlConnection sqlBaglanti = new SqlConnection(baglanti);
                sqlBaglanti.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Personel", sqlBaglanti);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                XLWorkbook excel = new XLWorkbook();
                excel.Worksheets.Add(dt, "Personeller");

                string excelDosyaYolu = Path.Combine(klasor, "Personeller.xlsx");
                excel.SaveAs(excelDosyaYolu);

                sqlBaglanti.Close();

                MessageBox.Show("Excel'e aktarıldı.");

                File.AppendAllText(dosya,
                    $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} Veriler Excel'e aktarıldı{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                File.AppendAllText(dosya,
                    $"{DateTime.Now:HH:mm:ss dd.MM.yyyy} {ex.Message}{Environment.NewLine}");
            }
        }
    }
}
