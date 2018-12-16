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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void duzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkformu = new Form2();
            renkformu.ShowDialog();

        }

        private void griYontemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 griformu = new Form3();
            griformu.ShowDialog();
        }

        private void renkSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 renksiralama = new Form4();
            renksiralama.ShowDialog();
        }

        private void histogramAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 histogramalma = new Form5();
            histogramalma.ShowDialog();
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 invert = new Form6();
            invert.ShowDialog();
        }

        private void toplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 invert = new Form7();
            invert.ShowDialog();
        }

        private void thresHoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 invert = new Form8();
            invert.ShowDialog();
        }

        private void filtrelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 invert = new Form9();
            invert.ShowDialog();
        }

        private void hücreSaymaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 invert = new Form10();
            invert.ShowDialog();
        }
    }
}
