# Excel Veri Tabanı Entegrasyonu

Bu proje C# Windows Forms ve SQL Server kullanılarak geliştirilmiştir. Uygulama personel verilerini yönetir ve Excel'e aktarır.

# Gereksinimler

* Visual Studio 
* SQL Server Management Studio

# Kurulum

1.Visual Studio ve C# ı kurun
2. SQL Server'ı kurun.
3. Veritabanını oluşturun ve gerekli tabloları ekleyin.
4. CREATE DATABASE DB_EXCEL
5. CREATE TABLE Personel(
6. PersonelID INT IDENTITY(1,1),
7. AD VARCHAR(50) NOT NULL,
8. Soyad VARCHAR(50) NOT NULL,
9. Maas INT NOT NULL)
10. Uygulamayı çalıştırın Görünüm Sunucu Gezgininden yeni bağlantı ekleyin
11. Eklediten sonra bağlantı dizisini kopyalayın
12. Form1.cs içinde 11. satırda string baglanti = @"" arasına yapıştırın
13. Proje kullanıma hazırdır 


