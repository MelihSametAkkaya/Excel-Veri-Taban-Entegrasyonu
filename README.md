# Excel Veri Tabanı Entegrasyonu

Bu proje C# Windows Forms ve SQL Server kullanılarak geliştirilmiştir. Uygulama personel verilerini yönetir ve Excel'e aktarır.

# Gereksinimler

* Visual Studio 
* SQL Server Management Studio

# Kurulum

Visual Studio ve C# ı kurun
SQL Server'ı kurun.
Veritabanını oluşturun ve gerekli tabloları ekleyin.
CREATE DATABASE DB_EXCEL
CREATE TABLE Personel(
PersonelID INT IDENTITY(1,1),
AD VARCHAR(50) NOT NULL,
Soyad VARCHAR(50) NOT NULL,
Maas INT NOT NULL)
Uygulamayı çalıştırın Görünüm Sunucu Gezgininden yeni bağlantı ekleyin
Eklediten sonra bağlantı dizisini kopyalayın
Form1.cs içinde 11. satırda string baglanti = @"" arasına yapıştırın
Proje kullanıma hazırdır 


