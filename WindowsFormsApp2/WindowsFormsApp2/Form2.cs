using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private string placeholderText = "Film Adı..."; // Text içindeki yazı
        private string placeholderTextFilmTur = "Film Türü..."; // Text içindeki yazı
        private string placeholderTextFilmSure = "Film Süresi..."; // Text içindeki yazı
        private string placeholderTextFilmYonetmen = "Film Yönetmeni..."; // Text içindeki yazı
        private string placeholderTextFilmKonu = "Açıklama..."; // Text içindeki yazı
        private Color placeholderColor = Color.Gray; // Placeholder rengi
        private Color textColor = Color.Black; // Kullanıcı yazı yazarken rengi

        public Form2()
        {
            InitializeComponent();
            InitializeTextBoxFilmAd();
            InitializeTextBoxFilmTur();
            InitializeTextBoxFilmSure();
            InitializeTextBoxFilmYonetmen();
            InitializeTextBoxFilmKonu();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";

            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Checked = false;
        }

        private void InitializeTextBoxFilmAd()
        {
            textBoxFilmAd.Text = placeholderText;
            textBoxFilmAd.ForeColor = placeholderColor;

            textBoxFilmAd.Enter += textBoxFilmAd_Enter;
            textBoxFilmAd.Leave += textBoxFilmAd_Leave;
        }

        private void InitializeTextBoxFilmTur()
        {
            textBoxFilmTur.Text = placeholderTextFilmTur;
            textBoxFilmTur.ForeColor = placeholderColor;

            textBoxFilmTur.Enter += textBoxFilmTur_Enter;
            textBoxFilmTur.Leave += textBoxFilmTur_Leave;
        }

        private void InitializeTextBoxFilmSure()
        {
            textBoxFilmSure.Text = placeholderTextFilmSure;
            textBoxFilmSure.ForeColor = placeholderColor;

            textBoxFilmSure.Enter += textBoxFilmSure_Enter;
            textBoxFilmSure.Leave += textBoxFilmSure_Leave;
        }

        private void InitializeTextBoxFilmYonetmen()
        {
            textBoxFilmYonetmen.Text = placeholderTextFilmYonetmen;
            textBoxFilmYonetmen.ForeColor = placeholderColor;

            textBoxFilmYonetmen.Enter += textBoxFilmYonetmen_Enter;
            textBoxFilmYonetmen.Leave += textBoxFilmYonetmen_Leave;
        }

        private void InitializeTextBoxFilmKonu()
        {
            textBoxFilmKonu.Text = placeholderTextFilmKonu;
            textBoxFilmKonu .ForeColor = placeholderColor;

            textBoxFilmKonu.Enter += textBoxFilmKonu_Enter;
            textBoxFilmKonu.Leave += textBoxFilmKonu_Leave;
        }

        private void textBoxFilmAd_Enter(object sender, EventArgs e)
        {
            if (textBoxFilmAd.Text == placeholderText)
            {
                textBoxFilmAd.Text = "";
                textBoxFilmAd.ForeColor = textColor;
            }
        }

        private void textBoxFilmAd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilmAd.Text))
            {
                textBoxFilmAd.Text = placeholderText;
                textBoxFilmAd.ForeColor = placeholderColor;
            }
        }

        private void textBoxFilmTur_Enter(object sender, EventArgs e)
        {
            if (textBoxFilmTur.Text == placeholderTextFilmTur)
            {
                textBoxFilmTur.Text = "";
                textBoxFilmTur.ForeColor = textColor;
            }
        }

        private void textBoxFilmTur_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilmTur.Text))
            {
                textBoxFilmTur.Text = placeholderTextFilmTur;
                textBoxFilmTur.ForeColor = placeholderColor;
            }
        }

        private void textBoxFilmSure_Enter(object sender, EventArgs e)
        {
            if (textBoxFilmSure.Text == placeholderTextFilmSure)
            {
                textBoxFilmSure.Text = "";
                textBoxFilmSure.ForeColor = textColor;
            }
        }

        private void textBoxFilmSure_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilmSure.Text))
            {
                textBoxFilmSure.Text = placeholderTextFilmSure;
                textBoxFilmSure.ForeColor= placeholderColor;
            }
        }

        private void textBoxFilmYonetmen_Enter(object sender, EventArgs e)
        {
            if (textBoxFilmYonetmen.Text == placeholderTextFilmYonetmen)
            {
                textBoxFilmYonetmen.Text = "";
                textBoxFilmYonetmen.ForeColor = textColor;
            }
        }

        private void textBoxFilmYonetmen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilmYonetmen.Text))
            {
                textBoxFilmYonetmen.Text = placeholderTextFilmYonetmen;
                textBoxFilmYonetmen.ForeColor= placeholderColor;
            }
        }

        private void textBoxFilmKonu_Enter(object sender, EventArgs e)
        {
            if (textBoxFilmKonu.Text == placeholderTextFilmKonu)
            {
                textBoxFilmKonu.Text = "";
                textBoxFilmKonu.ForeColor = textColor;
            }
        }

        private void textBoxFilmKonu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilmKonu.Text))
            {
                textBoxFilmKonu.Text = placeholderTextFilmKonu;
                textBoxFilmKonu.ForeColor= placeholderColor;
            }
        }

        private void Temizle()
        {
            textBoxFilmAd.Text = "";
            textBoxFilmTur.Text = "";
            textBoxFilmSure.Text = "";
            textBoxFilmYonetmen.Text = "";
            textBoxFilmKonu.Text = "";
            dateTimePicker1.Checked = false;
            pictureBoxFoto.Image = null;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilmAd.Text) || textBoxFilmAd.Text == placeholderText)
            {
                MessageBox.Show("Film Adı kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFilmAd.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFilmTur.Text) || textBoxFilmTur.Text == placeholderTextFilmTur)
            {
                MessageBox.Show("Film Türü kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFilmTur.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFilmSure.Text) || textBoxFilmSure.Text == placeholderTextFilmSure)
            {
                MessageBox.Show("Film Süresi kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFilmSure.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFilmYonetmen.Text) || textBoxFilmYonetmen.Text == placeholderTextFilmYonetmen)
            {
                MessageBox.Show("Film Yönetmeni kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFilmYonetmen.Focus();
                return;
            }

            if (!dateTimePicker1.Checked)
            {
                MessageBox.Show("Lütfen bir tarih seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFilmKonu.Text) || textBoxFilmKonu.Text == placeholderTextFilmKonu)
            {
                MessageBox.Show("Açıklama kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFilmKonu.Focus();
                return;
            }

            byte[] resimBytes = null;
            if (pictureBoxFoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    resimBytes = ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Resim alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Filmler (FilmAd, FilmTur, FilmSure, FilmYonetmen, VizyonTarih, Konu, Resim)" +
                               "OUTPUT INSERTED.FilmID " + //Eklenen kaydın ID'sini getir
                               "VALUES (@FilmAd, @FilmTur, @FilmSure, @FilmYonetmen, @VizyonTarih, @Konu, @Resim)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FilmAd", textBoxFilmAd.Text);
                    cmd.Parameters.AddWithValue("@FilmTur", textBoxFilmTur.Text);
                    cmd.Parameters.AddWithValue("@FilmSure", textBoxFilmSure.Text);
                    cmd.Parameters.AddWithValue("@FilmYonetmen", textBoxFilmYonetmen.Text);
                    cmd.Parameters.AddWithValue("@VizyonTarih", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Konu", textBoxFilmKonu.Text);
                    cmd.Parameters.AddWithValue("@Resim", (object)resimBytes ?? DBNull.Value);

                    try
                    {
                        con.Open();
                        int yeniFilmID = (int)cmd.ExecuteScalar(); //Yeni eklenen film ID'sini alır

                        if (yeniFilmID > 0)
                        {
                            MessageBox.Show("Film başarıyla eklendi! Film ID: " + yeniFilmID, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Film eklenirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }




            //MessageBox.Show("Film başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                pictureBoxFoto.Image = Image.FromFile(openFileDialog.FileName);
                pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //Film süre textbox sadece sayı girişi
        private void textBoxFilmSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //Film Tür textbox sadece harf girişi
        private void textBoxFilmTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ','
                && !char.IsSeparator(e.KeyChar);
        }

        //Film Yönetmen textbox sadece harf girişi
        private void textBoxFilmYonetmen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.'
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
