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
    public partial class Form4 : Form
    {
        Bitmap kaynak, islem;

        public Form4()
        {
            InitializeComponent();
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

        private void rGBToBRGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    Color siraliRenk = Color.FromArgb(renkliRenk.B , renkliRenk.R  , renkliRenk.G );
                    islem.SetPixel(x, y, siraliRenk);
                }
            }

            islemBox.Image = islem;
        }

        private void rGBToGBRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    Color siraliRenk = Color.FromArgb(renkliRenk.G, renkliRenk.B, renkliRenk.R);
                    islem.SetPixel(x, y, siraliRenk);
                }
            }

            islemBox.Image = islem;

        }

        private void rGBToBRGToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    Color siraliRenk = Color.FromArgb(renkliRenk.B, renkliRenk.R, renkliRenk.G);
                    islem.SetPixel(x, y, siraliRenk);
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
    }
}
