using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;
namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        Bitmap kaynak, islem;

        public Form10()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hücreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new ExtractNormalizedRGBChannel(RGB.G).Apply(kaynak);
            islem = new OtsuThreshold().Apply(islem);
            islem = new Invert().Apply(islem);
            islem = new Opening().Apply(islem);

            BlobCounter bc = new BlobCounter();
            bc.FilterBlobs = true;
            bc.MinHeight = 5;
            bc.MinWidth = 5;
            bc.ProcessImage(islem);
            Rectangle[] kare = bc.GetObjectsRectangles();
            listBox1.Items.Add(kare.Length + "tane hücre var");
            foreach(Rectangle rect in kare)
            {
                listBox1.Items.Add(rect.Location + " " + rect.Size);
            }

            KaynakBox.Image = islem;

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
