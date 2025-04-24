namespace WindowsFormsApp2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmFotoDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmAraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmToolStripMenuItem,
            this.filmEditToolStripMenuItem,
            this.filmBilgileriToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filmToolStripMenuItem.Text = "Film ";
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmEkleToolStripMenuItem.Text = "Film Ekle";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.filmEkleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // filmEditToolStripMenuItem
            // 
            this.filmEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmDüzenleToolStripMenuItem,
            this.filmFotoDeğiştirToolStripMenuItem});
            this.filmEditToolStripMenuItem.Name = "filmEditToolStripMenuItem";
            this.filmEditToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.filmEditToolStripMenuItem.Text = "Film Düzenle";
            // 
            // filmDüzenleToolStripMenuItem
            // 
            this.filmDüzenleToolStripMenuItem.Name = "filmDüzenleToolStripMenuItem";
            this.filmDüzenleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.filmDüzenleToolStripMenuItem.Text = "Film Sil/Güncelle";
            this.filmDüzenleToolStripMenuItem.Click += new System.EventHandler(this.filmDüzenleToolStripMenuItem_Click);
            // 
            // filmFotoDeğiştirToolStripMenuItem
            // 
            this.filmFotoDeğiştirToolStripMenuItem.Name = "filmFotoDeğiştirToolStripMenuItem";
            this.filmFotoDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.filmFotoDeğiştirToolStripMenuItem.Text = "Film Foto Değiştir";
            this.filmFotoDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.filmFotoDeğiştirToolStripMenuItem_Click);
            // 
            // filmBilgileriToolStripMenuItem
            // 
            this.filmBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmAraToolStripMenuItem1});
            this.filmBilgileriToolStripMenuItem.Name = "filmBilgileriToolStripMenuItem";
            this.filmBilgileriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.filmBilgileriToolStripMenuItem.Text = "Film Bilgileri";
            // 
            // filmAraToolStripMenuItem1
            // 
            this.filmAraToolStripMenuItem1.Name = "filmAraToolStripMenuItem1";
            this.filmAraToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.filmAraToolStripMenuItem1.Text = "Film Ara";
            this.filmAraToolStripMenuItem1.Click += new System.EventHandler(this.filmAraToolStripMenuItem1_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmFotoDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmAraToolStripMenuItem1;
    }
}

