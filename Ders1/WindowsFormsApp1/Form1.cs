﻿using System;
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
    }
}
