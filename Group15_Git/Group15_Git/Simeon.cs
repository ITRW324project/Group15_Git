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
    public partial class Simeon : Form
    {
        public Simeon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int test = Int32.Parse(textBox2.Text);

            Except exc = new Except();
            if (exc.BetweenTest(Convert.ToInt32(textBox2.Text)) == true)
                MessageBox.Show("Between 5 and 20");
            else
                MessageBox.Show("Not Between 5 and 20");

            CalcMin c = new CalcMin();
            MessageBox.Show(Convert.ToString(c.calcMinimum(Convert.ToInt32(textBox2.Text))));
        }
    }
}
