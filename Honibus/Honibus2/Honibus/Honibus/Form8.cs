﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honibus
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 newForm9 = new Form9();
            newForm9.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.ShowDialog();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newForm6 = new Form6();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm7 = new Form7();
            newForm7.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
