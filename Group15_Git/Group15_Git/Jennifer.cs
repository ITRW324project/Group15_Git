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
    public partial class Jennifer : Form
    {
        public Jennifer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int test = Int32.Parse(textBox1.Text);

            Except exc = new Except();
            if (exc.BetweenTest(Convert.ToInt32(textBox1.Text)) == true)
                MessageBox.Show("Between 5 and 20");
            else
                MessageBox.Show("Not Between 5 and 20");

            AvgJennifer num = new AvgJennifer();
            MessageBox.Show("Average:  " + Convert.ToString(num.generate_number_J(Convert.ToInt32(textBox1.Text))));
        }
    }
}
