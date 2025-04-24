using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http.Headers;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        private int sayfaNumarasi = 0;
        private const int sayfaBoyutu = 12;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //FilmleriYukle();
            textBoxFilmAra.Text = "Film Ara...";
            textBoxFilmAra.ForeColor = Color.Gray;
            FilmTurleriDoldur(); // Film Türlerini Çekme
            FilmYilAraliklariDoldur(); // Film Yıl Aralıklarını Ekleme
            FilmleriGetir(); // Tüm filmleri listeleme
        }

        private void FilmleriYukle()
        {
            flowLayoutPanel1.Controls.Clear();

            string query = "SELECT TOP (@sayfaBoyutu) * FROM Filmler WHERE FilmID NOT IN " +
                           "(SELECT TOP (@sayfaNumarasi * @sayfaBoyutu) FilmID FROM Filmler ORDER BY FilmID ASC) " +
                           "ORDER BY FilmID ASC";

            using (SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
                    cmd.Parameters.AddWithValue("@sayfaNumarasi", sayfaNumarasi);
                    cmd.Parameters.AddWithValue("@sayfaBoyutu", sayfaBoyutu);

                    baglanti.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Panel filmPanel = new Panel();
                            filmPanel.Size = new Size(150, 250);
                            filmPanel.BorderStyle = BorderStyle.FixedSingle;

                            PictureBox pb = new PictureBox();
                            pb.Size = new Size(140, 180);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;

                            if (dr["Resim"] != DBNull.Value)
                            {
                                byte[] resimBytes = (byte[])dr["Resim"];
                                using (MemoryStream ms = new MemoryStream(resimBytes))
                                {
                                    pb.Image = Image.FromStream(ms);
                                }
                            }

                            Label lblFilmAd = new Label();
                            lblFilmAd.Text = "Film: " + dr["FilmAd"].ToString();
                            lblFilmAd.TextAlign = ContentAlignment.MiddleCenter;
                            lblFilmAd.AutoSize = true;

                            Label lblFilmTur = new Label();
                            lblFilmTur.Text = "Tür: " + dr["FilmTur"].ToString();
                            lblFilmTur.AutoSize = true;

                            Label lblFilmYil = new Label();
                            lblFilmYil.Text = "Yıl: " + Convert.ToDateTime(dr["VizyonTarih"]).ToString("dd.MM.yyyy");
                            lblFilmYil.AutoSize = true;

                            filmPanel.Controls.Add(pb);
                            filmPanel.Controls.Add(lblFilmAd);
                            filmPanel.Controls.Add(lblFilmTur);
                            filmPanel.Controls.Add(lblFilmYil);

                            pb.Location = new Point(5, 5);
                            lblFilmAd.Location = new Point(5, 190);
                            lblFilmTur.Location = new Point(5, 210);
                            lblFilmYil.Location = new Point(5, 230);

                            flowLayoutPanel1.Controls.Add(filmPanel);

                            ToolTip toolTip = new ToolTip();
                            toolTip.SetToolTip(lblFilmAd, dr["FilmAd"].ToString());
                            toolTip.SetToolTip(lblFilmTur, dr["FilmTur"].ToString());
                            toolTip.SetToolTip(lblFilmYil, dr["VizyonTarih"].ToString());
                        }
                    }
                }
            }
        }

        //Film Türlerini Veritabanından Çekme
        private void FilmTurleriDoldur()
        {
            comboBoxFilmTur.Items.Clear();
            comboBoxFilmTur.Items.Add("Vazgeç"); //Filtreyi sıfırlamak için

            HashSet<string> turSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase); // Tekrarları önlemek için ve Büyük/küçük harf duyarsızlaştırma

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT FilmTur FROM Filmler", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string turler = dr["FilmTur"].ToString();
                    string[] turArray = turler.Split(','); // Virgüle göre ayırma

                    foreach (string tur in turArray)
                    {
                        string temizTur = tur.Trim(); // Boşlukları temizleyerek Hashset'e ekleme
                        turSet.Add(temizTur); // Tekrar edenleri engelleme
                    }
                }

                con.Close();
            }

            // Combobox'a ekleme
            foreach (string tur in turSet.OrderBy(x => x)) // Alfabetik Sıralama
            {
                comboBoxFilmTur.Items.Add(tur);
            }
        }

        private void FilmYilAraliklariDoldur()
        {
            comboBoxFilmYil.Items.Clear();
            comboBoxFilmYil.Items.Add("Vazgeç"); // Filtreyi sıfırlamak için
            comboBoxFilmYil.Items.Add("1950-1960");
            comboBoxFilmYil.Items.Add("1960-1970");
            comboBoxFilmYil.Items.Add("1970-1980");
            comboBoxFilmYil.Items.Add("1980-1990");
            comboBoxFilmYil.Items.Add("1990-2000");
            comboBoxFilmYil.Items.Add("2000-2010");
            comboBoxFilmYil.Items.Add("2010-2020");
            comboBoxFilmYil.Items.Add("2020-2030");
        }

        private void FilmleriGetir()
        {
            flowLayoutPanel1.Controls.Clear();
            string sql = "SELECT * FROM Filmler WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            string secilenTur = comboBoxFilmTur.SelectedItem?.ToString();
            string secilenYil = comboBoxFilmYil.SelectedItem?.ToString();

            if (comboBoxFilmTur.SelectedItem != null && comboBoxFilmTur.SelectedItem.ToString() != "Vazgeç")
            {
                sql += " AND FilmTur LIKE @FilmTur";
                parameters.Add(new SqlParameter("@FilmTur", "%" + comboBoxFilmTur.SelectedItem.ToString() + "%"));
            }

            if (comboBoxFilmYil.SelectedItem != null && comboBoxFilmYil.SelectedItem.ToString() != "Vazgeç")
            {
                string[] yilAralik = comboBoxFilmYil.SelectedItem.ToString().Split('-');
                int yilBaslangic = int.Parse(yilAralik[0]);
                int yilBitis = int.Parse(yilAralik[1]);

                sql += " AND YEAR(VizyonTarih) BETWEEN @YilBaslangic AND @YilBitis";
                parameters.Add(new SqlParameter("@YilBaslangic", yilBaslangic));
                parameters.Add(new SqlParameter("@YilBitis", yilBitis));
            }

            sql += " ORDER BY FilmID OFFSET @SayfaNumara ROWS FETCH NEXT @SayfaBoyutu ROWS ONLY";
            parameters.Add(new SqlParameter("@SayfaNumara", sayfaNumarasi * sayfaBoyutu));
            parameters.Add(new SqlParameter("@SayfaBoyutu", sayfaBoyutu));

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(parameters.ToArray());
                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    string mesaj = "Seçmiş olduğunuz kriterlere uygun film bulunamadı.";
                    if (comboBoxFilmTur.SelectedItem != null && comboBoxFilmTur.SelectedItem.ToString() != "Vazgeç" &&
                        comboBoxFilmYil.SelectedItem != null && comboBoxFilmYil.SelectedItem.ToString() != "Vazgeç")
                    {
                        mesaj = $"Seçmiş olduğunuz {comboBoxFilmYil.SelectedItem} yılları arasında herhangi bir {comboBoxFilmTur.SelectedItem} filmi bulunamamıştır.";
                    }
                    else if (comboBoxFilmTur.SelectedItem != null && comboBoxFilmTur.SelectedItem.ToString() != "Vazgeç")
                    {
                        mesaj = $"Seçmiş olduğunuz {comboBoxFilmTur.SelectedItem} türüne ait film bulunamamıştır.";
                    }
                    else if (comboBoxFilmYil.SelectedItem != null && comboBoxFilmYil.SelectedItem.ToString() != "Vazgeç")
                    {
                        mesaj = $"Seçmiş olduğunuz {comboBoxFilmYil.SelectedItem} yılları arasında film bulunamamıştır.";
                    }

                    MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    while (dr.Read())
                    {
                        Panel filmPanel = new Panel { Size = new Size(150, 250), BorderStyle = BorderStyle.FixedSingle };
                        PictureBox pb = new PictureBox { Size = new Size(140, 180), SizeMode = PictureBoxSizeMode.StretchImage };
                        if (dr["Resim"] != DBNull.Value)
                        {
                            byte[] resimBytes = (byte[])dr["Resim"];
                            using (MemoryStream ms = new MemoryStream(resimBytes))
                            {
                                pb.Image = Image.FromStream(ms);
                            }
                        }
                        Label lblFilmAd = new Label { Text = "Film: " + dr["FilmAd"].ToString(), AutoSize = true };
                        Label lblFilmTur = new Label { Text = "Tür: " + dr["FilmTur"].ToString(), AutoSize = true };
                        Label lblFilmYil = new Label { Text = "Yıl: " + Convert.ToDateTime(dr["VizyonTarih"]).ToString("yyyy"), AutoSize = true };

                        filmPanel.Controls.Add(pb);
                        filmPanel.Controls.Add(lblFilmAd);
                        filmPanel.Controls.Add(lblFilmTur);
                        filmPanel.Controls.Add(lblFilmYil);

                        pb.Location = new Point(5, 5);
                        lblFilmAd.Location = new Point(5, 190);
                        lblFilmTur.Location = new Point(5, 210);
                        lblFilmYil.Location = new Point(5, 230);

                        flowLayoutPanel1.Controls.Add(filmPanel);
                    }
                }
                con.Close();
            }
        }

        private void comboBoxFilmTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            sayfaNumarasi = 0;
            FilmleriGetir();
        }

        private void comboBoxFilmYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            sayfaNumarasi = 0;
            FilmleriGetir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayfaNumarasi++;
            FilmleriGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayfaNumarasi > 0)
            {
                sayfaNumarasi--;
                FilmleriGetir();
            }
            else
            {
                MessageBox.Show("Zaten ilk sayfadasınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxFilmAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void FilmleriAdaGoreGetir(string filmAdi)
        {
            flowLayoutPanel1.Controls.Clear();

            string sql = "SELECT * FROM Filmler WHERE FilmAd LIKE @FilmAd ORDER BY FilmID DESC";

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Filmler;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@FilmAd", "%" + filmAdi + "%");
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Panel filmPanel = new Panel { Size = new Size(150, 250), BorderStyle = BorderStyle.FixedSingle };
                    PictureBox pb = new PictureBox { Size = new Size(140, 180), SizeMode = PictureBoxSizeMode.StretchImage };

                    if (dr["Resim"] != DBNull.Value)
                    {
                        byte[] resimBytes = (byte[])dr["Resim"];
                        using (MemoryStream ms = new MemoryStream(resimBytes))
                        {
                            pb.Image = Image.FromStream(ms);
                        }
                    }

                    Label lblFilmAd = new Label { Text = "Film: " + dr["FilmAd"].ToString(), AutoSize = true };
                    Label lblFilmTur = new Label { Text = "Tür: " + dr["FilmTur"].ToString(), AutoSize = true };
                    Label lblFilmYil = new Label { Text = "Yıl: " + Convert.ToDateTime(dr["VizyonTarih"]).ToString("yyyy"), AutoSize = true };

                    filmPanel.Controls.Add(pb);
                    filmPanel.Controls.Add(lblFilmAd);
                    filmPanel.Controls.Add(lblFilmTur);
                    filmPanel.Controls.Add(lblFilmYil);

                    pb.Location = new Point(5, 5);
                    lblFilmAd.Location = new Point(5, 190);
                    lblFilmTur.Location = new Point(5, 210);
                    lblFilmYil.Location = new Point(5, 230);

                    flowLayoutPanel1.Controls.Add(filmPanel);
                }

                con.Close();
            }
        }

        private void textBoxFilmAra_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxFilmAra_Leave(object sender, EventArgs e)
        {

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {

        }
    }
}
