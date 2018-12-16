using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        Bitmap kaynak,kaynak2,islem;
        public Form7()
        {
            InitializeComponent();
        }

        private void goruntuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                KaynakBox.Image = kaynak;
            }
        }

        private void goruntuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak2 = new Bitmap(openFileDialog1.FileName);
                KaynakBox2.Image = kaynak2;
            }
        }

        private void toplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            int red, green, blue = 0;


            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);

                    red = renk.R + renk2.R ;
                    green = renk.G + renk2.G ;
                    blue = renk.B + renk2.B ;

                    if (red > 255) red = 255;
                    if (green > 255) green = 255;
                    if (blue > 255) blue = 255;

                    Color yenirenk = Color.FromArgb(red, green, blue);

                    islem.SetPixel(x, y,yenirenk);
                }

            }
            islemBox.Image = islem;
        }
    }
}
