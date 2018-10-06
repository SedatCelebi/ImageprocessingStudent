using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Bitmap kaynak, islem;
       
        public Form3()
        {
            InitializeComponent();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);
            for (int y=0;y<yuk ;y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    int ortalama = (renk.R + renk.G + renk.B)/3;
                    Color gri = Color.FromArgb(ortalama, ortalama, ortalama);
                    islem.SetPixel(x, y, gri);
                  
                }
               
            }
            islemBox.Image = islem;
           
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    int bT = (int)((renk.R * 0.2125) + (renk.G * 0.7154) + (renk.B * 0.072));
                    Color gri = Color.FromArgb(bT, bT, bT);
                    islem.SetPixel(x, y, gri);
                }

            }
            islemBox.Image = islem;
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    int luma = (int)((renk.R *0.3) + (renk.G *0.59) + (renk.B*0.11));
                    Color gri = Color.FromArgb(luma ,luma ,luma );
                    islem.SetPixel(x, y, gri);

                }

            }
            islemBox.Image = islem;
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    int[] renkler = { renk.R, renk.G, renk.B };

                    int min = renkler[0];
                    int mak = renkler[0];

                    for (int i = 1; i < renkler.Length; i++)
                    {
                        if (min > renkler[i])
                            min = renkler[i];
                        if (mak < renkler[i])
                            mak = renkler[i];
                    }
                    int aciklik = (mak + min) / 2;
                    Color gri = Color.FromArgb(aciklik , aciklik , aciklik);
                    islem.SetPixel(x, y, gri);


                }
            }

            islemBox.Image = islem;
        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    int kanal=renk.R ;
                    Color gri = Color.FromArgb(kanal , kanal , kanal );
                    islem.SetPixel(x, y, gri);

                }

            }
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
