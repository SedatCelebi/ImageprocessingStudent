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
    public partial class Form6 : Form
    {
        Bitmap kaynak, islem;
        public Form6()
        {
            InitializeComponent();
        }

        private void calistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
           
                    Color gri = Color.FromArgb((255-renk .R ), (255 - renk.G), (255 - renk.B));
                    islem.SetPixel(x, y, gri);
                }

            }
            islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();//burda resim almak için dosya aç penceeresi açılıyor     
            if (sonuc == DialogResult.OK)//eğer dosya seçimi ok ise 
            {
                kaynak = new Bitmap(openFileDialog1.FileName);//kaynak değişkenine resimi ata   
                KaynakBox.Image = kaynak;// resmi imageboxa eşitle
            }
        }
    }
}
