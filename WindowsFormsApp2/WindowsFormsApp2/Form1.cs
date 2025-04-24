using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void filmFotoDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(true, false); // true göndererek Form3'teki ilgili butonlar aktif/pasif haline geliyor
            form3.ShowDialog();
        }

        private void filmAraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filmDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(false, true); //false göndererek ilgili butonları else konumunda olacağından hepsi aktif hale gelecektir
            form3.ShowDialog();
        }
    }
}
