using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp8
{
    public partial class formInputBuku : Form
    {
        public formInputBuku()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string judulBuku = textBox1.Text;
            string namaPenulis = textBox2.Text;
            int hargaBuku = int.Parse(textBox3.Text);

            //ini untuk pembuatan list yang mau diisi
            List<Buku> buku = new List<Buku>();
            buku.Add(new Buku(judulBuku, namaPenulis, hargaBuku));
        }
    }
}
