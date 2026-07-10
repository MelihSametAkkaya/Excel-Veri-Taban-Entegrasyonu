namespace ExcelVeriTabanıEntegrasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_KayitEkle = new Button();
            lbl_Ad = new Label();
            lbl_Soyad = new Label();
            lbl_Maas = new Label();
            txt_Ad = new TextBox();
            txt_Soyad = new TextBox();
            txt_Maas = new TextBox();
            dataGridView1 = new DataGridView();
            btn_Guncelle = new Button();
            txt_PersonelID = new TextBox();
            lbl_PersonelID = new Label();
            btn_KayitSil = new Button();
            label1 = new Label();
            btn_ButunKayitlar = new Button();
            btn_PersonelAra = new Button();
            btn_Temizle = new Button();
            btn_ExceleAktar = new Button();
            btn_MaxMinMaas = new Button();
            btnHarfleAra = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_KayitEkle
            // 
            btn_KayitEkle.Location = new Point(244, 12);
            btn_KayitEkle.Name = "btn_KayitEkle";
            btn_KayitEkle.Size = new Size(113, 39);
            btn_KayitEkle.TabIndex = 0;
            btn_KayitEkle.Text = "Kayıt Ekle";
            btn_KayitEkle.UseVisualStyleBackColor = true;
            btn_KayitEkle.Click += btn_KayitEkle_Click;
            // 
            // lbl_Ad
            // 
            lbl_Ad.AutoSize = true;
            lbl_Ad.Location = new Point(39, 21);
            lbl_Ad.Name = "lbl_Ad";
            lbl_Ad.Size = new Size(31, 20);
            lbl_Ad.TabIndex = 1;
            lbl_Ad.Text = "Ad:";
            // 
            // lbl_Soyad
            // 
            lbl_Soyad.AutoSize = true;
            lbl_Soyad.Location = new Point(23, 66);
            lbl_Soyad.Name = "lbl_Soyad";
            lbl_Soyad.Size = new Size(53, 20);
            lbl_Soyad.TabIndex = 2;
            lbl_Soyad.Text = "Soyad:";
            // 
            // lbl_Maas
            // 
            lbl_Maas.AutoSize = true;
            lbl_Maas.Location = new Point(29, 110);
            lbl_Maas.Name = "lbl_Maas";
            lbl_Maas.Size = new Size(47, 20);
            lbl_Maas.TabIndex = 3;
            lbl_Maas.Text = "Maaş:";
            // 
            // txt_Ad
            // 
            txt_Ad.Location = new Point(98, 14);
            txt_Ad.Name = "txt_Ad";
            txt_Ad.Size = new Size(125, 27);
            txt_Ad.TabIndex = 4;
            // 
            // txt_Soyad
            // 
            txt_Soyad.Location = new Point(98, 57);
            txt_Soyad.Name = "txt_Soyad";
            txt_Soyad.Size = new Size(125, 27);
            txt_Soyad.TabIndex = 5;
            // 
            // txt_Maas
            // 
            txt_Maas.Location = new Point(98, 103);
            txt_Maas.Name = "txt_Maas";
            txt_Maas.Size = new Size(125, 27);
            txt_Maas.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1372, 237);
            dataGridView1.TabIndex = 7;
            // 
            // btn_Guncelle
            // 
            btn_Guncelle.Location = new Point(244, 57);
            btn_Guncelle.Name = "btn_Guncelle";
            btn_Guncelle.Size = new Size(113, 39);
            btn_Guncelle.TabIndex = 8;
            btn_Guncelle.Text = "Güncelle";
            btn_Guncelle.UseVisualStyleBackColor = true;
            btn_Guncelle.Click += btn_Guncelle_Click;
            // 
            // txt_PersonelID
            // 
            txt_PersonelID.Location = new Point(98, 149);
            txt_PersonelID.Name = "txt_PersonelID";
            txt_PersonelID.Size = new Size(125, 27);
            txt_PersonelID.TabIndex = 9;
            // 
            // lbl_PersonelID
            // 
            lbl_PersonelID.AutoSize = true;
            lbl_PersonelID.Location = new Point(2, 156);
            lbl_PersonelID.Name = "lbl_PersonelID";
            lbl_PersonelID.Size = new Size(86, 20);
            lbl_PersonelID.TabIndex = 10;
            lbl_PersonelID.Text = "Personel ID:";
            // 
            // btn_KayitSil
            // 
            btn_KayitSil.Location = new Point(244, 103);
            btn_KayitSil.Name = "btn_KayitSil";
            btn_KayitSil.Size = new Size(113, 39);
            btn_KayitSil.TabIndex = 11;
            btn_KayitSil.Text = "Kayıt Sil";
            btn_KayitSil.UseVisualStyleBackColor = true;
            btn_KayitSil.Click += btn_KayitSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 152);
            label1.Name = "label1";
            label1.Size = new Size(875, 20);
            label1.TabIndex = 12;
            label1.Text = "Kayıt güncellemek ve silmek için Personel ID şarttır bilmiyorsanız Personel Ara kısmından ad soyad yada maaş kısmıyla bulabilirsiniz";
            // 
            // btn_ButunKayitlar
            // 
            btn_ButunKayitlar.Location = new Point(370, 14);
            btn_ButunKayitlar.Name = "btn_ButunKayitlar";
            btn_ButunKayitlar.Size = new Size(113, 39);
            btn_ButunKayitlar.TabIndex = 13;
            btn_ButunKayitlar.Text = "Bütün Kayıtlar";
            btn_ButunKayitlar.UseVisualStyleBackColor = true;
            btn_ButunKayitlar.Click += btn_ButunKayitlar_Click;
            // 
            // btn_PersonelAra
            // 
            btn_PersonelAra.Location = new Point(370, 58);
            btn_PersonelAra.Name = "btn_PersonelAra";
            btn_PersonelAra.Size = new Size(113, 39);
            btn_PersonelAra.TabIndex = 14;
            btn_PersonelAra.Text = "Personel Ara";
            btn_PersonelAra.UseVisualStyleBackColor = true;
            btn_PersonelAra.Click += btn_PersonelAra_Click;
            // 
            // btn_Temizle
            // 
            btn_Temizle.Location = new Point(370, 103);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new Size(113, 39);
            btn_Temizle.TabIndex = 15;
            btn_Temizle.Text = "Ekranı Temizle";
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // btn_ExceleAktar
            // 
            btn_ExceleAktar.Location = new Point(670, 10);
            btn_ExceleAktar.Name = "btn_ExceleAktar";
            btn_ExceleAktar.Size = new Size(114, 74);
            btn_ExceleAktar.TabIndex = 16;
            btn_ExceleAktar.Text = "Excel'e Aktar";
            btn_ExceleAktar.UseVisualStyleBackColor = true;
            btn_ExceleAktar.Click += btn_ExceleAktar_Click;
            // 
            // btn_MaxMinMaas
            // 
            btn_MaxMinMaas.Location = new Point(506, 14);
            btn_MaxMinMaas.Name = "btn_MaxMinMaas";
            btn_MaxMinMaas.Size = new Size(118, 40);
            btn_MaxMinMaas.TabIndex = 17;
            btn_MaxMinMaas.Text = "Max Min Maaş";
            btn_MaxMinMaas.UseVisualStyleBackColor = true;
            btn_MaxMinMaas.Click += btn_MaxMinMaas_Click;
            // 
            // btnHarfleAra
            // 
            btnHarfleAra.Location = new Point(506, 60);
            btnHarfleAra.Name = "btnHarfleAra";
            btnHarfleAra.Size = new Size(118, 37);
            btnHarfleAra.TabIndex = 18;
            btnHarfleAra.Text = "Harfle Ara";
            btnHarfleAra.UseVisualStyleBackColor = true;
            btnHarfleAra.Click += btnHarfleAra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 172);
            label2.Name = "label2";
            label2.Size = new Size(523, 20);
            label2.TabIndex = 19;
            label2.Text = "İsmi tam bilmiyorsanız Harfle Ara kısmından Ad yada Soyadıyla arayabilirsiniz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 450);
            Controls.Add(label2);
            Controls.Add(btnHarfleAra);
            Controls.Add(btn_MaxMinMaas);
            Controls.Add(btn_ExceleAktar);
            Controls.Add(btn_Temizle);
            Controls.Add(btn_PersonelAra);
            Controls.Add(btn_ButunKayitlar);
            Controls.Add(label1);
            Controls.Add(btn_KayitSil);
            Controls.Add(lbl_PersonelID);
            Controls.Add(txt_PersonelID);
            Controls.Add(btn_Guncelle);
            Controls.Add(dataGridView1);
            Controls.Add(txt_Maas);
            Controls.Add(txt_Soyad);
            Controls.Add(txt_Ad);
            Controls.Add(lbl_Maas);
            Controls.Add(lbl_Soyad);
            Controls.Add(lbl_Ad);
            Controls.Add(btn_KayitEkle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_KayitEkle;
        private Label lbl_Ad;
        private Label lbl_Soyad;
        private Label lbl_Maas;
        private TextBox txt_Ad;
        private TextBox txt_Soyad;
        private TextBox txt_Maas;
        private DataGridView dataGridView1;
        private Button btn_Guncelle;
        private TextBox txt_PersonelID;
        private Label lbl_PersonelID;
        private Button btn_KayitSil;
        private Label label1;
        private Button btn_ButunKayitlar;
        private Button btn_PersonelAra;
        private Button btn_Temizle;
        private Button btn_ExceleAktar;
        private Button btn_MaxMinMaas;
        private Button btnHarfleAra;
        private Label label2;
    }
}
