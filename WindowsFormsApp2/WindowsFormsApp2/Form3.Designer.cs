namespace WindowsFormsApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonFoto = new System.Windows.Forms.Button();
            this.textBoxFilmAd = new System.Windows.Forms.TextBox();
            this.textBoxFilmTur = new System.Windows.Forms.TextBox();
            this.textBoxFilmSure = new System.Windows.Forms.TextBox();
            this.textBoxFilmYonetmen = new System.Windows.Forms.TextBox();
            this.textBoxFilmTarih = new System.Windows.Forms.TextBox();
            this.textBoxFilmKonu = new System.Windows.Forms.TextBox();
            this.labelFilmID = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.labelFilmSayfa = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonFotoGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Film Süresi (dk):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Film Yönetmeni:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vizyon Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Konusu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(280, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 121);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Film Görseli:";
            // 
            // buttonFoto
            // 
            this.buttonFoto.Location = new System.Drawing.Point(280, 187);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(100, 23);
            this.buttonFoto.TabIndex = 9;
            this.buttonFoto.Text = "Fotoğraf Seç";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // textBoxFilmAd
            // 
            this.textBoxFilmAd.Location = new System.Drawing.Point(106, 57);
            this.textBoxFilmAd.Name = "textBoxFilmAd";
            this.textBoxFilmAd.Size = new System.Drawing.Size(117, 20);
            this.textBoxFilmAd.TabIndex = 10;
            // 
            // textBoxFilmTur
            // 
            this.textBoxFilmTur.Location = new System.Drawing.Point(106, 83);
            this.textBoxFilmTur.Name = "textBoxFilmTur";
            this.textBoxFilmTur.Size = new System.Drawing.Size(117, 20);
            this.textBoxFilmTur.TabIndex = 11;
            // 
            // textBoxFilmSure
            // 
            this.textBoxFilmSure.Location = new System.Drawing.Point(106, 109);
            this.textBoxFilmSure.Name = "textBoxFilmSure";
            this.textBoxFilmSure.Size = new System.Drawing.Size(117, 20);
            this.textBoxFilmSure.TabIndex = 12;
            // 
            // textBoxFilmYonetmen
            // 
            this.textBoxFilmYonetmen.Location = new System.Drawing.Point(106, 135);
            this.textBoxFilmYonetmen.Name = "textBoxFilmYonetmen";
            this.textBoxFilmYonetmen.Size = new System.Drawing.Size(117, 20);
            this.textBoxFilmYonetmen.TabIndex = 13;
            // 
            // textBoxFilmTarih
            // 
            this.textBoxFilmTarih.Enabled = false;
            this.textBoxFilmTarih.Location = new System.Drawing.Point(106, 161);
            this.textBoxFilmTarih.Name = "textBoxFilmTarih";
            this.textBoxFilmTarih.Size = new System.Drawing.Size(117, 20);
            this.textBoxFilmTarih.TabIndex = 14;
            // 
            // textBoxFilmKonu
            // 
            this.textBoxFilmKonu.Location = new System.Drawing.Point(12, 251);
            this.textBoxFilmKonu.Multiline = true;
            this.textBoxFilmKonu.Name = "textBoxFilmKonu";
            this.textBoxFilmKonu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFilmKonu.Size = new System.Drawing.Size(368, 93);
            this.textBoxFilmKonu.TabIndex = 15;
            // 
            // labelFilmID
            // 
            this.labelFilmID.AutoSize = true;
            this.labelFilmID.Location = new System.Drawing.Point(103, 16);
            this.labelFilmID.Name = "labelFilmID";
            this.labelFilmID.Size = new System.Drawing.Size(39, 13);
            this.labelFilmID.TabIndex = 16;
            this.labelFilmID.Text = "Film ID";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(252, 429);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(88, 38);
            this.buttonGuncelle.TabIndex = 17;
            this.buttonGuncelle.Text = "Film Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(54, 429);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(88, 38);
            this.buttonSil.TabIndex = 18;
            this.buttonSil.Text = "Film Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(148, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(221, 372);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(252, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // labelFilmSayfa
            // 
            this.labelFilmSayfa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelFilmSayfa.Location = new System.Drawing.Point(179, 377);
            this.labelFilmSayfa.Name = "labelFilmSayfa";
            this.labelFilmSayfa.Size = new System.Drawing.Size(39, 13);
            this.labelFilmSayfa.TabIndex = 23;
            this.labelFilmSayfa.Text = "1";
            this.labelFilmSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(40, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonFotoGuncelle
            // 
            this.buttonFotoGuncelle.Location = new System.Drawing.Point(280, 213);
            this.buttonFotoGuncelle.Name = "buttonFotoGuncelle";
            this.buttonFotoGuncelle.Size = new System.Drawing.Size(100, 23);
            this.buttonFotoGuncelle.TabIndex = 25;
            this.buttonFotoGuncelle.Text = "Foto Güncelle";
            this.buttonFotoGuncelle.UseVisualStyleBackColor = true;
            this.buttonFotoGuncelle.Click += new System.EventHandler(this.buttonFotoGuncelle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 479);
            this.Controls.Add(this.buttonFotoGuncelle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelFilmSayfa);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.labelFilmID);
            this.Controls.Add(this.textBoxFilmKonu);
            this.Controls.Add(this.textBoxFilmTarih);
            this.Controls.Add(this.textBoxFilmYonetmen);
            this.Controls.Add(this.textBoxFilmSure);
            this.Controls.Add(this.textBoxFilmTur);
            this.Controls.Add(this.textBoxFilmAd);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Film Sil/Güncelle";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.TextBox textBoxFilmAd;
        private System.Windows.Forms.TextBox textBoxFilmTur;
        private System.Windows.Forms.TextBox textBoxFilmSure;
        private System.Windows.Forms.TextBox textBoxFilmYonetmen;
        private System.Windows.Forms.TextBox textBoxFilmTarih;
        private System.Windows.Forms.TextBox textBoxFilmKonu;
        private System.Windows.Forms.Label labelFilmID;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labelFilmSayfa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonFotoGuncelle;
    }
}