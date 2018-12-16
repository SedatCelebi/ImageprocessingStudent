using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {

        Bitmap kaynak, islem;

        public Form8()
        {
            InitializeComponent();
        }

        private void önTanımlıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int tValue = 128;


            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    int ortalama = (renk.R + renk.G + renk.B) / 3;
                    if (ortalama > tValue) ortalama = 255; else ortalama = 0;//ön tanımlı
                    Color gri = Color.FromArgb(ortalama, ortalama, ortalama);
                    islem.SetPixel(x, y, gri);

                }

            }
            islemBox.Image = islem;
        }

        private void brandlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new GrayscaleBT709().Apply(kaynak);
            islem = new BradleyLocalThresholding().Apply(islem);
            islemBox.Image = islem;
        }

        private void otsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new GrayscaleBT709().Apply(kaynak);
            islem = new OtsuThreshold().Apply(islem);
            islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                KaynakBox.Image = kaynak;
            }
        }
    }
}
