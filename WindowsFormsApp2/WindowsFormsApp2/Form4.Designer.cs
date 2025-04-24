namespace WindowsFormsApp2
{
    partial class Form4
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
            this.comboBoxFilmTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFilmYil = new System.Windows.Forms.ComboBox();
            this.textBoxFilmAra = new System.Windows.Forms.TextBox();
            this.labelFilmSayfa = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelTur = new System.Windows.Forms.Label();
            this.labelYil = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FİLTRELE";
            // 
            // comboBoxFilmTur
            // 
            this.comboBoxFilmTur.FormattingEnabled = true;
            this.comboBoxFilmTur.Location = new System.Drawing.Point(83, 38);
            this.comboBoxFilmTur.Name = "comboBoxFilmTur";
            this.comboBoxFilmTur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmTur.TabIndex = 1;
            this.comboBoxFilmTur.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmTur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FİLM TÜRÜ SEÇİNİZ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "YILA GÖRE ARAMA...";
            // 
            // comboBoxFilmYil
            // 
            this.comboBoxFilmYil.FormattingEnabled = true;
            this.comboBoxFilmYil.Location = new System.Drawing.Point(240, 38);
            this.comboBoxFilmYil.Name = "comboBoxFilmYil";
            this.comboBoxFilmYil.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmYil.TabIndex = 4;
            this.comboBoxFilmYil.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmYil_SelectedIndexChanged);
            // 
            // textBoxFilmAra
            // 
            this.textBoxFilmAra.Location = new System.Drawing.Point(464, 38);
            this.textBoxFilmAra.Name = "textBoxFilmAra";
            this.textBoxFilmAra.Size = new System.Drawing.Size(121, 20);
            this.textBoxFilmAra.TabIndex = 5;
            this.textBoxFilmAra.Text = "Film Ara...";
            this.textBoxFilmAra.TextChanged += new System.EventHandler(this.textBoxFilmAra_TextChanged);
            this.textBoxFilmAra.Enter += new System.EventHandler(this.textBoxFilmAra_Enter);
            this.textBoxFilmAra.Leave += new System.EventHandler(this.textBoxFilmAra_Leave);
            // 
            // labelFilmSayfa
            // 
            this.labelFilmSayfa.AutoSize = true;
            this.labelFilmSayfa.Location = new System.Drawing.Point(290, 607);
            this.labelFilmSayfa.Name = "labelFilmSayfa";
            this.labelFilmSayfa.Size = new System.Drawing.Size(55, 13);
            this.labelFilmSayfa.TabIndex = 28;
            this.labelFilmSayfa.Text = "Film Sayfa";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(382, 602);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(351, 602);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(259, 602);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 602);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 186);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Location = new System.Drawing.Point(207, 0);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(31, 13);
            this.labelFilm.TabIndex = 30;
            this.labelFilm.Text = "FİLM";
            // 
            // labelTur
            // 
            this.labelTur.AutoSize = true;
            this.labelTur.Location = new System.Drawing.Point(142, 0);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(30, 13);
            this.labelTur.TabIndex = 31;
            this.labelTur.Text = "TÜR";
            // 
            // labelYil
            // 
            this.labelYil.AutoSize = true;
            this.labelYil.Location = new System.Drawing.Point(178, 0);
            this.labelYil.Name = "labelYil";
            this.labelYil.Size = new System.Drawing.Size(23, 13);
            this.labelYil.TabIndex = 32;
            this.labelYil.Text = "YIL";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(590, 38);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(38, 21);
            this.buttonAra.TabIndex = 33;
            this.buttonAra.Text = "ARA";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.labelTur);
            this.flowLayoutPanel1.Controls.Add(this.labelYil);
            this.flowLayoutPanel1.Controls.Add(this.labelFilm);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 508);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 643);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.labelFilmSayfa);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxFilmAra);
            this.Controls.Add(this.comboBoxFilmYil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFilmTur);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Film Ara";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilmTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFilmYil;
        private System.Windows.Forms.TextBox textBoxFilmAra;
        private System.Windows.Forms.Label labelFilmSayfa;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.Label labelYil;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}