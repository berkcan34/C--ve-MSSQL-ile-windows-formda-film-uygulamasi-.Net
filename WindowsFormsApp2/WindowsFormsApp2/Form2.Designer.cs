namespace WindowsFormsApp2
{
    partial class Form2
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
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonFoto = new System.Windows.Forms.Button();
            this.textBoxFilmAd = new System.Windows.Forms.TextBox();
            this.textBoxFilmTur = new System.Windows.Forms.TextBox();
            this.textBoxFilmSure = new System.Windows.Forms.TextBox();
            this.textBoxFilmYonetmen = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxFilmKonu = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Süresi (dk):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Film Yönetmeni:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vizyon Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Konusu:";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(279, 75);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(100, 114);
            this.pictureBoxFoto.TabIndex = 6;
            this.pictureBoxFoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Film Görseli Ekle:";
            // 
            // buttonFoto
            // 
            this.buttonFoto.Location = new System.Drawing.Point(279, 203);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(100, 23);
            this.buttonFoto.TabIndex = 8;
            this.buttonFoto.Text = "Fotoğraf Seç";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // textBoxFilmAd
            // 
            this.textBoxFilmAd.Location = new System.Drawing.Point(101, 46);
            this.textBoxFilmAd.Name = "textBoxFilmAd";
            this.textBoxFilmAd.Size = new System.Drawing.Size(108, 20);
            this.textBoxFilmAd.TabIndex = 9;
            this.textBoxFilmAd.Enter += new System.EventHandler(this.textBoxFilmAd_Enter);
            this.textBoxFilmAd.Leave += new System.EventHandler(this.textBoxFilmAd_Leave);
            // 
            // textBoxFilmTur
            // 
            this.textBoxFilmTur.Location = new System.Drawing.Point(101, 78);
            this.textBoxFilmTur.Name = "textBoxFilmTur";
            this.textBoxFilmTur.Size = new System.Drawing.Size(108, 20);
            this.textBoxFilmTur.TabIndex = 10;
            this.textBoxFilmTur.Enter += new System.EventHandler(this.textBoxFilmTur_Enter);
            this.textBoxFilmTur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilmTur_KeyPress);
            this.textBoxFilmTur.Leave += new System.EventHandler(this.textBoxFilmTur_Leave);
            // 
            // textBoxFilmSure
            // 
            this.textBoxFilmSure.Location = new System.Drawing.Point(101, 110);
            this.textBoxFilmSure.Name = "textBoxFilmSure";
            this.textBoxFilmSure.Size = new System.Drawing.Size(108, 20);
            this.textBoxFilmSure.TabIndex = 11;
            this.textBoxFilmSure.Enter += new System.EventHandler(this.textBoxFilmSure_Enter);
            this.textBoxFilmSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilmSure_KeyPress);
            this.textBoxFilmSure.Leave += new System.EventHandler(this.textBoxFilmSure_Leave);
            // 
            // textBoxFilmYonetmen
            // 
            this.textBoxFilmYonetmen.Location = new System.Drawing.Point(101, 142);
            this.textBoxFilmYonetmen.Name = "textBoxFilmYonetmen";
            this.textBoxFilmYonetmen.Size = new System.Drawing.Size(108, 20);
            this.textBoxFilmYonetmen.TabIndex = 12;
            this.textBoxFilmYonetmen.Enter += new System.EventHandler(this.textBoxFilmYonetmen_Enter);
            this.textBoxFilmYonetmen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilmYonetmen_KeyPress);
            this.textBoxFilmYonetmen.Leave += new System.EventHandler(this.textBoxFilmYonetmen_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textBoxFilmKonu
            // 
            this.textBoxFilmKonu.Location = new System.Drawing.Point(13, 268);
            this.textBoxFilmKonu.Multiline = true;
            this.textBoxFilmKonu.Name = "textBoxFilmKonu";
            this.textBoxFilmKonu.Size = new System.Drawing.Size(366, 93);
            this.textBoxFilmKonu.TabIndex = 14;
            this.textBoxFilmKonu.Enter += new System.EventHandler(this.textBoxFilmKonu_Enter);
            this.textBoxFilmKonu.Leave += new System.EventHandler(this.textBoxFilmKonu_Leave);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(304, 367);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 38);
            this.buttonEkle.TabIndex = 15;
            this.buttonEkle.Text = "Film Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 428);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxFilmKonu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxFilmYonetmen);
            this.Controls.Add(this.textBoxFilmSure);
            this.Controls.Add(this.textBoxFilmTur);
            this.Controls.Add(this.textBoxFilmAd);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Film Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.TextBox textBoxFilmAd;
        private System.Windows.Forms.TextBox textBoxFilmTur;
        private System.Windows.Forms.TextBox textBoxFilmSure;
        private System.Windows.Forms.TextBox textBoxFilmYonetmen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxFilmKonu;
        private System.Windows.Forms.Button buttonEkle;
    }
}