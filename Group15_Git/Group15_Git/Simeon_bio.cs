﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group15_Git
{
    public partial class Simeon_bio : Form
    {
        public Simeon_bio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClcMin c = new ClcMin();
            MessageBox.Show(Convert.ToString(c.calcMinimum(Convert.ToInt32(textBox2.Text))));
        }
    }
}
