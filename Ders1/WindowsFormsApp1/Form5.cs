using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        Bitmap kaynak;
        public Form5()
        {
            InitializeComponent();
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

        private void veriGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            int[] histogramDiziRed = new int[256];
            int[] histogramDiziGreen = new int[256];
            int[] histogramDiziBlue = new int[256];


            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {

                    Color renkli = kaynak.GetPixel(x, y);
                    for (int m = 0; m < histogramDiziRed.Length; m++)
                    {
                        if (m == renkli.R)
                        {
                            histogramDiziRed[m] = histogramDiziRed[m] + 1;
                        }
                        if (m == renkli.G)
                        {
                            histogramDiziGreen[m] = histogramDiziGreen[m] + 1;
                        }
                        if (m == renkli.B)
                        {
                            histogramDiziBlue[m] = histogramDiziBlue[m] + 1;
                        }
                    }
                }
            }
            chart1.Titles.Add("Histogram Grafikleri");
            chart1.Series.Add("Red");
            chart1.Series["Red"].ChartType = SeriesChartType.Line;
            chart1.Series["Red"].Color = Color.Red;
            chart1.Series.Add("Green");
            chart1.Series["Green"].ChartType = SeriesChartType.Line;
            chart1.Series["Green"].Color = Color.Green;
            chart1.Series.Add("Blue");
            chart1.Series["Blue"].ChartType = SeriesChartType.Line;
            chart1.Series["Blue"].Color = Color.Blue;

            for (int i = 0; i < histogramDiziRed.Length; i++)
            {
                chart1.Series["Red"].Points.Add(histogramDiziRed[i]);
                chart1.Series["Red"].Points[i].AxisLabel = i.ToString();
                chart1.Series["Green"].Points.Add(histogramDiziGreen[i]);
                chart1.Series["Green"].Points[i].AxisLabel = i.ToString();
                chart1.Series["Blue"].Points.Add(histogramDiziBlue[i]);
                chart1.Series["Blue"].Points[i].AxisLabel = i.ToString();

                //Console.WriteLine(i + " " + histogramDizi[i]);
            }

       

        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
