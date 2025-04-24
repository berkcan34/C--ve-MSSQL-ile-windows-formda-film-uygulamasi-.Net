using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True");
        int mevcutFilmID = 1; //Başlangıç FilmID

        private bool butonFotoDegistir; //Dışarıdan alınan parametre
        private bool butonSilGuncelle; //Dışarıdan alınan parametre

        private Dictionary<string, string> eskiDegerler = new Dictionary<string, string>();
        private bool ilkTiklama = true;

        //Form3'ü parametre ile açan constructor
        public Form3(bool butonFoto, bool butonSilGun)
        {
            InitializeComponent();
            butonFotoDegistir = butonFoto;
            butonSilGuncelle = butonSilGun;
            FilmYukle(mevcutFilmID);
        }

        private void FilmYukle(int filmID)
        {
            DateTime VizyonTarihi = GetVizyonTarihiFromDatabase(filmID);

            dateTimePicker1.Value = VizyonTarihi;

            try
            {
                baglanti.Open();
                string query = "SELECT * FROM Filmler WHERE FilmID = @id";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@id", filmID);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBoxFilmAd.Text = dr["FilmAd"].ToString();
                    textBoxFilmTur.Text = dr["FilmTur"].ToString();
                    textBoxFilmSure.Text = dr["FilmSure"].ToString();
                    textBoxFilmYonetmen.Text = dr["FilmYonetmen"].ToString();
                    textBoxFilmKonu.Text = dr["Konu"].ToString();

                    labelFilmID.Text = dr["FilmID"].ToString();
                    labelFilmSayfa.Text = dr["FilmID"].ToString();

                    // Tarihi gün ay yıl formatında yazdırma
                    DateTime vizyonTarihi = Convert.ToDateTime(dr["VizyonTarih"]);
                    textBoxFilmTarih.Text = vizyonTarihi.ToString("dd.MM.yyyy");

                    // Resmi pictureBox'a yükleme
                    if (dr["Resim"] != DBNull.Value)
                    {
                        byte[] resimBytes = (byte[])dr["Resim"];
                        using (MemoryStream ms = new MemoryStream(resimBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi pictureBox'a tam sığdırma
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Film Bulunamadı.");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void SonFilmYukle(int filmID)
        {
            DateTime VizyonTarihi = GetVizyonTarihiFromDatabase(filmID);
            mevcutFilmID = SonFilmIDGetir();
            FilmYukle(mevcutFilmID);
            dateTimePicker1.Value = VizyonTarihi;

            try
            {
                baglanti.Open();
                string query = "SELECT TOP 1 * FROM Filmler ORDER BY FilmID DESC";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                //cmd.Parameters.AddWithValue("@id", filmID);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int sonFilmID = Convert.ToInt32(dr["FilmID"]);

                    // Eğer FilmID en yüksek değerse, uyarı mesajı göster
                    if (mevcutFilmID == sonFilmID)
                    {
                        MessageBox.Show("En son filmdeyiz.");
                        return;
                    }

                    textBoxFilmAd.Text = dr["FilmAd"].ToString();
                    textBoxFilmTur.Text = dr["FilmTur"].ToString();
                    textBoxFilmSure.Text = dr["FilmSure"].ToString();
                    textBoxFilmYonetmen.Text = dr["FilmYonetmen"].ToString();
                    textBoxFilmKonu.Text = dr["Konu"].ToString();

                    labelFilmID.Text = dr["FilmID"].ToString();
                    labelFilmSayfa.Text = dr["FilmID"].ToString();

                    // Tarihi gün ay yıl formatında yazdırma
                    DateTime vizyonTarihi = Convert.ToDateTime(dr["VizyonTarih"]);
                    textBoxFilmTarih.Text = vizyonTarihi.ToString("dd.MM.yyyy");

                    // Resmi pictureBox'a yükleme
                    if (dr["Resim"] != DBNull.Value)
                    {
                        byte[] resimBytes = (byte[])dr["Resim"];
                        using (MemoryStream ms = new MemoryStream(resimBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi pictureBox'a tam sığdırma
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Film Bulunamadı.");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private Image originalImage;

        private bool IsPhotoChanged()
        {
            return pictureBox1.Image != originalImage;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // İlk fotoğrafı kaydediyoruz
            originalImage = pictureBox1.Image;

            // Eğer fotoğraf değişmişse buttonFotoGuncelle butonunu aktif yapıyoruz
            buttonFotoGuncelle.Enabled = IsPhotoChanged();

            // Başlangıçta tüm textboxlar sadece okunabilir durumda
            //textBoxFilmAd.ReadOnly = true;
            //textBoxFilmTur.ReadOnly = true;
            //textBoxFilmSure.ReadOnly = true;
            //textBoxFilmYonetmen.ReadOnly = true;
            textBoxFilmKonu.ReadOnly = true;

            textBoxFilmAd.Enabled = false;
            textBoxFilmTur.Enabled = false;
            textBoxFilmSure.Enabled = false;
            textBoxFilmYonetmen.Enabled = false;
            //textBoxFilmKonu.Enabled = false;

            // DateTimePicker'ı sadece ikon şeklinde göster
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " "; // Boş bırak, kutuyu gizle
            dateTimePicker1.Width = 40; // Küçük tut
            dateTimePicker1.ShowCheckBox = true; // Checkbox aktif (ikon görünmesi için)
            dateTimePicker1.Checked = false; // Tarih seçili olmasın
            dateTimePicker1.Enabled = false; // Başlangıçta tıklanamaz olsun

            // TextBox elle değiştirilemez
            textBoxFilmTarih.ReadOnly = true;


            if (butonFotoDegistir) // Eğer form1'den kapatma talebi geldiyse
            {
                buttonSil.Enabled = false;
                buttonGuncelle.Enabled = false;
                buttonFoto.Enabled = true; // Form1'de "Film foto değiştir" sekmesine basılınca aktif olacak tek buton
                //buttonFotoGuncelle.Enabled = true;
            }
            if (butonSilGuncelle)
            {
                buttonSil.Enabled = true;
                buttonGuncelle.Enabled = true;
                buttonFoto.Enabled = false;
                buttonFotoGuncelle.Enabled = false;
            }
        }

        // İleri butonu
        private void button6_Click(object sender, EventArgs e)
        {
            //DegisiklikVarMi();
            mevcutFilmID++;
            FilmYukle(mevcutFilmID);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int yeniFilmID = OncekiFilmIDGetir(mevcutFilmID);
            if (yeniFilmID < mevcutFilmID) // Yeni filmID küçükse devam edebiliriz
            {
                mevcutFilmID = yeniFilmID;
                FilmYukle(mevcutFilmID);
            }
            else
            {
                MessageBox.Show("Zaten ilk filmdeyiz!");
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (ilkTiklama)
            {
                // TextBox'ları düzenlenebilir hale getir
                //textBoxFilmAd.ReadOnly = false;
                //textBoxFilmTur.ReadOnly = false;
                //textBoxFilmSure.ReadOnly = false;
                //textBoxFilmYonetmen.ReadOnly = false;
                textBoxFilmKonu.ReadOnly = false;

                textBoxFilmAd.Enabled = true;
                textBoxFilmTur.Enabled = true;
                textBoxFilmSure.Enabled = true;
                textBoxFilmYonetmen.Enabled = true;
                //textBoxFilmKonu.Enabled = true;

                // DateTimePicker aktif hale gelsin
                dateTimePicker1.Enabled = true;
                dateTimePicker1.Checked = true; // Tarih seçilebilir hale gelsin

                // Mevcut verileri saklıyoruz
                eskiDegerler["FilmAd"] = textBoxFilmAd.Text;
                eskiDegerler["FilmTur"] = textBoxFilmTur.Text;
                eskiDegerler["FilmSure"] = textBoxFilmSure.Text;
                eskiDegerler["FilmYonetmen"] = textBoxFilmYonetmen.Text;
                eskiDegerler["Konu"] = textBoxFilmKonu.Text;
                eskiDegerler["VizyonTarih"] = dateTimePicker1.Value.ToString("dd.MM.yyyy");

                // Kullanıcıya mesaj göster
                MessageBox.Show("Şimdi filmi güncelleyebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ilkTiklama = false; // İkinci tıklamayı kontrol etmek için değişkeni güncelliyoruz.
            }
            else
            {
                // Güncellenen verileri alıyoruz
                string yeniFilmAd = textBoxFilmAd.Text;
                string yeniFilmTur = textBoxFilmTur.Text;
                string yeniFilmSure = textBoxFilmSure.Text;
                string yeniFilmYonetmen = textBoxFilmYonetmen.Text;
                string yeniFilmKonu = textBoxFilmKonu.Text;
                string yeniVizyonTarih = dateTimePicker1.Value.ToString("dd.MM.yyyy");

                // Değişiklikleri kontrol etmek için bir liste 
                List<string> degisenAlanlar = new List<string>();

                if (eskiDegerler["FilmAd"] != yeniFilmAd)
                {
                    degisenAlanlar.Add($"Film Adı: {eskiDegerler["FilmAd"]} -> {yeniFilmAd}");
                }
                if (eskiDegerler["FilmTur"] != yeniFilmTur)
                {
                    degisenAlanlar.Add($"Film Türü: {eskiDegerler["FilmTur"]} -> {yeniFilmTur}");
                }
                if (eskiDegerler["FilmSure"] != yeniFilmSure)
                {
                    degisenAlanlar.Add($"Film Süresi: {eskiDegerler["FilmSure"]} -> {yeniFilmSure}");
                }
                if (eskiDegerler["FilmYonetmen"] != yeniFilmYonetmen)
                {
                    degisenAlanlar.Add($"Yönetmen: {eskiDegerler["FilmYonetmen"]} -> {yeniFilmYonetmen}");
                }
                if (eskiDegerler["Konu"] != yeniFilmKonu)
                {
                    degisenAlanlar.Add($"Film Konusu: {eskiDegerler["Konu"]} -> {yeniFilmKonu}");
                }
                if (eskiDegerler["VizyonTarih"] != yeniVizyonTarih)
                {
                    degisenAlanlar.Add($"Vizyon Tarihi: {eskiDegerler["VizyonTarih"]} -> {yeniVizyonTarih}");
                }

                // Eğer değişiklik yoksa kullanıcıya bilgi verip işlem sonlanıyor.
                if (degisenAlanlar.Count == 0)
                {
                    MessageBox.Show("Herhangi bir değişiklik yapılmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Değişiklikleri mesaj kutusunda gösteriyoruz. 
                string mesaj = "Aşağıdaki bilgiler değiştirildi:\n\n" + string.Join("\n", degisenAlanlar) + "\n\nOnaylıyor musunuz?";
                DialogResult sonuc = MessageBox.Show(mesaj, "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    // Kullanıcı onayladıysa veritabanında güncelleme yap.
                    int filmID = int.Parse(labelFilmID.Text); // FilmID'yi al
                    FilmGuncelle(filmID, yeniFilmAd, yeniFilmTur, yeniFilmSure, yeniFilmYonetmen, yeniFilmKonu, yeniVizyonTarih);
                    MessageBox.Show("Film başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mevcutFilmID++;
                    FilmYukle(mevcutFilmID);
                }
                else
                {
                    // Kullanıcı hayır dediyse eski değerler geri yüklenir
                    textBoxFilmAd.Text = eskiDegerler["FilmAd"];
                    textBoxFilmTur.Text = eskiDegerler["FilmTur"];
                    textBoxFilmSure.Text = eskiDegerler["FilmSure"];
                    textBoxFilmYonetmen.Text = eskiDegerler["FilmYonetmen"];
                    textBoxFilmKonu.Text = eskiDegerler["Konu"];
                    dateTimePicker1.Value = DateTime.Parse(eskiDegerler["VizyonTarih"]);
                }

                // Formu tekrar düzenlenemez hale getiriyoruz.
                textBoxFilmKonu.ReadOnly = true;

                textBoxFilmAd.Enabled = false;
                textBoxFilmTur.Enabled = false;
                textBoxFilmSure.Enabled = false;
                textBoxFilmYonetmen.Enabled = false;
                //textBoxFilmKonu.Enabled = false;

                // DateTimePicker'ı sadece ikon şeklinde göster
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = " "; // Boş bırak, kutuyu gizle
                dateTimePicker1.Width = 40; // Küçük tut
                dateTimePicker1.ShowCheckBox = true; // Checkbox aktif (ikon görünmesi için)
                dateTimePicker1.Checked = false; // Tarih seçili olmasın
                dateTimePicker1.Enabled = false; // Başlangıçta tıklanamaz olsun

                // TextBox elle değiştirilemez
                textBoxFilmTarih.ReadOnly = true;
                

                ilkTiklama = true; // Güncelleme işlemi tamamlandı, tekrar başa dönüş.
            }
        }

        // Veritabanında güncelleme işlemi
        private void FilmGuncelle(int FilmID, string ad, string tur, string sure, string yonetmen, string konu, string vizyonTarih)
        {
            string connectionString = "Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Filmler SET " +
                               "FilmAd = @FilmAd, " +
                               "FilmTur = @FilmTur, " +
                               "FilmSure = @FilmSure, " +
                               "FilmYonetmen = @FilmYonetmen, " +
                               "Konu = @Konu, " +
                               "vizyonTarih = @vizyonTarih " +
                               "WHERE FilmID = @FilmID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parametreler
                    cmd.Parameters.AddWithValue("FilmID", FilmID);
                    cmd.Parameters.AddWithValue("FilmAd", ad);
                    cmd.Parameters.AddWithValue("FilmTur", tur);
                    cmd.Parameters.AddWithValue("FilmSure", sure);
                    cmd.Parameters.AddWithValue("FilmYonetmen", yonetmen);
                    cmd.Parameters.AddWithValue("Konu", konu);
                    cmd.Parameters.AddWithValue("VizyonTarih", dateTimePicker1.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        // Kullanıcı başka filme geçmeye çalıştığında değişiklik kontrolü yap
        private void DegisiklikVarMi()
        {

            // Güncellenen verileri alıyoruz
            string yeniFilmAd = textBoxFilmAd.Text;
            string yeniFilmTur = textBoxFilmTur.Text;
            string yeniFilmSure = textBoxFilmSure.Text;
            string yeniFilmYonetmen = textBoxFilmYonetmen.Text;
            string yeniFilmKonu = textBoxFilmKonu.Text;
            string yeniVizyonTarih = dateTimePicker1.Value.ToString("dd.MM.yyyy");

            // Değişiklikleri kontrol etmek için bir liste 
            List<string> degisenAlanlar = new List<string>();

            if (eskiDegerler["FilmAd"] != yeniFilmAd)
            {
                degisenAlanlar.Add($"Film Adı: {eskiDegerler["FilmAd"]} -> {yeniFilmAd}");
            }
            if (eskiDegerler["FilmTur"] != yeniFilmTur)
            {
                degisenAlanlar.Add($"Film Türü: {eskiDegerler["FilmTur"]} -> {yeniFilmTur}");
            }
            if (eskiDegerler["FilmSure"] != yeniFilmSure)
            {
                degisenAlanlar.Add($"Film Süresi: {eskiDegerler["FilmSure"]} -> {yeniFilmSure}");
            }
            if (eskiDegerler["FilmYonetmen"] != yeniFilmYonetmen)
            {
                degisenAlanlar.Add($"Yönetmen: {eskiDegerler["FilmYonetmen"]} -> {yeniFilmYonetmen}");
            }
            if (eskiDegerler["Konu"] != yeniFilmKonu)
            {
                degisenAlanlar.Add($"Film Konusu: {eskiDegerler["Konu"]} -> {yeniFilmKonu}");
            }
            if (eskiDegerler["VizyonTarih"] != yeniVizyonTarih)
            {
                degisenAlanlar.Add($"Vizyon Tarihi: {eskiDegerler["VizyonTarih"]} -> {yeniVizyonTarih}");
            }

            // Eğer değişiklik yoksa kullanıcıya bilgi verip işlem sonlanıyor.
            if (degisenAlanlar.Count == 0)
            {
                //MessageBox.Show("Herhangi bir değişiklik yapılmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Değişiklikleri mesaj kutusunda gösteriyoruz. 
            string mesaj = "Aşağıdaki bilgiler değiştirildi:\n\n" + string.Join("\n", degisenAlanlar) + "\n\nOnaylıyor musunuz?";
            DialogResult sonuc = MessageBox.Show(mesaj, "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                // Kullanıcı onayladıysa veritabanında güncelleme yap.
                int filmID = int.Parse(labelFilmID.Text); // FilmID'yi al
                FilmGuncelle(filmID, yeniFilmAd, yeniFilmTur, yeniFilmSure, yeniFilmYonetmen, yeniFilmKonu, yeniVizyonTarih);
                MessageBox.Show("Film başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mevcutFilmID++;
                FilmYukle(mevcutFilmID);
            }
            else
            {
                // Kullanıcı hayır dediyse eski değerler geri yüklenir
                textBoxFilmAd.Text = eskiDegerler["FilmAd"];
                textBoxFilmTur.Text = eskiDegerler["FilmTur"];
                textBoxFilmSure.Text = eskiDegerler["FilmSure"];
                textBoxFilmYonetmen.Text = eskiDegerler["FilmYonetmen"];
                textBoxFilmKonu.Text = eskiDegerler["Konu"];
                dateTimePicker1.Value = DateTime.Parse(eskiDegerler["VizyonTarih"]);
            }

            // Formu tekrar düzenlenemez hale getiriyoruz.
            textBoxFilmKonu.ReadOnly = true;

            textBoxFilmAd.Enabled = false;
            textBoxFilmTur.Enabled = false;
            textBoxFilmSure.Enabled = false;
            textBoxFilmYonetmen.Enabled = false;
            //textBoxFilmKonu.Enabled = false;

            // DateTimePicker'ı sadece ikon şeklinde göster
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " "; // Boş bırak, kutuyu gizle
            dateTimePicker1.Width = 40; // Küçük tut
            dateTimePicker1.ShowCheckBox = true; // Checkbox aktif (ikon görünmesi için)
            dateTimePicker1.Checked = false; // Tarih seçili olmasın
            dateTimePicker1.Enabled = false; // Başlangıçta tıklanamaz olsun

            // TextBox elle değiştirilemez
            textBoxFilmTarih.ReadOnly = true;

            ilkTiklama = true;
        }

        private DateTime GetVizyonTarihiFromDatabase(int filmId)
        {
            DateTime vizyonTarihi = DateTime.Today;
            string connectionString = "Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT VizyonTarih FROM Filmler WHERE FilmID = @filmId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filmId", filmId);
                        object result = cmd.ExecuteScalar();
                        if (result != null && DateTime.TryParse(result.ToString(), out DateTime tarih))
                        {
                            vizyonTarihi = tarih;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return vizyonTarihi;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Seçilen tarihi "gün/ay/yıl" formatında textBox'a yaz
            textBoxFilmTarih.Text = dateTimePicker1.Value.ToString("dd.MM.yyyy");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SonFilmYukle(mevcutFilmID);
        }

        private int SonFilmIDGetir()
        {
            int sonFilmID = 1; // Varsayılan değer
            try
            {
                baglanti.Open();
                string query = "SELECT MAX(FilmID) FROM Filmler";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    sonFilmID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            return sonFilmID;
        }

        private int OncekiFilmIDGetir(int mevcutID)
        {
            int oncekiID = mevcutID;
            try
            {
                baglanti.Open();
                string query = "SELECT MAX(FilmID) FROM Filmler WHERE FilmID < @mevcutID";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@mevcutID", mevcutID);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    oncekiID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            return oncekiID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Eğer zaten ilk filmdeysek, uyarı mesajı ver ve işlemi durdur
            if (mevcutFilmID == 1)
            {
                MessageBox.Show("Zaten ilk filmdeyiz!");
                return;
            }

            try
            {
                baglanti.Open();
                string query = "SELECT TOP 1 * FROM Filmler ORDER BY FilmID ASC"; // İlk film ID'sini getir
                SqlCommand cmd = new SqlCommand(query, baglanti);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Film bilgilerini ekranda güncelle
                    textBoxFilmAd.Text = dr["FilmAd"].ToString();
                    textBoxFilmTur.Text = dr["FilmTur"].ToString();
                    textBoxFilmSure.Text = dr["FilmSure"].ToString();
                    textBoxFilmYonetmen.Text = dr["FilmYonetmen"].ToString();
                    textBoxFilmKonu.Text = dr["Konu"].ToString();

                    labelFilmID.Text = dr["FilmID"].ToString();
                    labelFilmSayfa.Text = dr["FilmID"].ToString();

                    // Tarihi gün ay yıl formatında yazdırma
                    DateTime vizyonTarihi = Convert.ToDateTime(dr["VizyonTarih"]);
                    textBoxFilmTarih.Text = vizyonTarihi.ToString("dd.MM.yyyy");

                    // Resmi pictureBox'a yükleme
                    if (dr["Resim"] != DBNull.Value)
                    {
                        byte[] resimBytes = (byte[])dr["Resim"];
                        using (MemoryStream ms = new MemoryStream(resimBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi pictureBox'a tam sığdırma
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }

                    // İlk Film ID'yi mevcutFilmID olarak ata
                    mevcutFilmID = Convert.ToInt32(dr["FilmID"]);
                }
                else
                {
                    MessageBox.Show("Veritabanında film bulunamadı.");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            // Ekranda gösterilen FilmID'yi alıyoruz
            int filmID = Convert.ToInt32(labelFilmID.Text);
            string filmAd = textBoxFilmAd.Text;  // Film adını ekrandan alıyoruz

            // Kullanıcıya silme onayı soruluyor
            DialogResult result = MessageBox.Show($"Seçmiş olduğunuz \"{filmAd}\" adlı filmi silmek üzeresiniz. Onaylıyor musunuz?",
                                                  "Film Silme",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // Eğer kullanıcı "Evet" derse
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Veritabanı bağlantısı
                    baglanti.Open();

                    // 1. Silinen filmden sonra gelen film ID'yi alalım
                    string query1 = "SELECT TOP 1 FilmID FROM Filmler WHERE FilmID > @FilmID ORDER BY FilmID ASC";
                    SqlCommand cmd1 = new SqlCommand(query1, baglanti);
                    cmd1.Parameters.AddWithValue("@FilmID", filmID);
                    SqlDataReader dr1 = cmd1.ExecuteReader();

                    if (dr1.Read())
                    {
                        int nextFilmID = Convert.ToInt32(dr1["FilmID"]);

                        // 2. Silinen filmin yerini almak için, FilmID güncellemesi yapıyoruz
                        dr1.Close();
                        string query2 = "UPDATE Filmler SET FilmID = @NewFilmID WHERE FilmID = @NextFilmID";
                        SqlCommand cmd2 = new SqlCommand(query2, baglanti);
                        cmd2.Parameters.AddWithValue("@NewFilmID", filmID);  // Yeni FilmID
                        cmd2.Parameters.AddWithValue("@NextFilmID", nextFilmID);  // Silinen filmin sonrasındaki FilmID
                        cmd2.ExecuteNonQuery();

                        // 3. Şimdi silinen filmi veritabanından siliyoruz
                        string query3 = "DELETE FROM Filmler WHERE FilmID = @FilmID";
                        SqlCommand cmd3 = new SqlCommand(query3, baglanti);
                        cmd3.Parameters.AddWithValue("@FilmID", nextFilmID);  // Aslında silmek istediğimiz film, bir üst film
                        cmd3.ExecuteNonQuery();

                        MessageBox.Show("Film başarıyla silindi ve ID güncellendi.");

                        // 4. UI'yı güncellemek için FilmYukle fonksiyonu ile ekranda doğru filmi gösteriyoruz
                        SonFilmYukle(filmID);
                    }
                    else
                    {
                        MessageBox.Show("Silme işleminde bir sorun oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Fotoğraf Seç",
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Fotoğraf değiştiyse buttonFotoGuncelle butonunu aktif yapıyoruz
                buttonFotoGuncelle.Enabled = true;
            }
        }

        private void buttonFotoGuncelle_Click(object sender, EventArgs e)
        {
            // Veritabanına bağlanma ve fotoğrafı güncelleme işlemi
            try
            {
                // Veritabanı bağlantısı
                using (SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True"))
                {
                    baglanti.Open();

                    // Fotoğrafı byte dizisine dönüştürme
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] resimBytes = ms.ToArray();

                    // SQL Update komutunu hazırlıyoruz (FilmID'yi uygun şekilde değiştirmelisiniz)
                    string query = "UPDATE Filmler SET Resim = @Resim WHERE FilmID = @FilmID";

                    using (SqlCommand cmd = new SqlCommand(query, baglanti))
                    {
                        // Parametreleri ekliyoruz
                        cmd.Parameters.AddWithValue("@Resim", resimBytes);
                        cmd.Parameters.AddWithValue("@FilmID", mevcutFilmID); // mevcutFilmID'yi kullanarak doğru filmi seçiyoruz

                        // SQL komutunu çalıştırıyoruz
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Fotoğraf başarıyla güncellendi!");
                buttonFotoGuncelle.Enabled = false; // Güncelleme sonrasında butonu devre dışı bırakıyoruz
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
