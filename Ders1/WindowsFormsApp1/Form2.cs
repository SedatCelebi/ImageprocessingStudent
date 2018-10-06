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
    public partial class Form2 : Form
    {
        Bitmap kaynak;
        public Form2()
        {
            InitializeComponent();
        }


        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();//burda resim almak için dosya aç penceeresi açılıyor     
            if(sonuc == DialogResult.OK)//eğer dosya seçimi ok ise 
            {
                kaynak = new Bitmap(openFileDialog1.FileName);//kaynak değişkenine resimi ata   
                KaynakBox.Image = kaynak;// resmi imageboxa eşitle
            }

        }

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xKor.Text);//Texten x ve y değerleri alınıyor
            int y = int.Parse(yKor.Text);

            Color renk = kaynak.GetPixel(x, y);//o x ve y noktasındaki renk değeri alınıyo ve renk değişkenine eşitleniyor
            pictureBox1.BackColor = renk;//renk değişkeninde bulunan değer picturebox arkaplanı oluyor

           label5 .Text= ("R: " + renk.R + " G: " + renk.G + " B: " + renk.B);
                
         }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xKor.Text);//Texten x ve y değerleri alınıyor
            int y = int.Parse(yKor.Text);

            Color renk = kaynak.GetPixel(x, y);//o x ve y noktasındaki renk değeri alınıyo ve renk değişkenine eşitleniyor
            pictureBox1.BackColor = renk;//renk değişkeninde bulunan değer picturebox arkaplanı oluyor

            label5.Text = ("R: " + renk.R + " G: " + renk.G + " B: " + renk.B);
        }
    }
}
