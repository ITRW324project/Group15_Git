using System;
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
    public partial class David : Form
    {
        public David()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int test = Int32.Parse(textBox2.Text);

                Except exc = new Except();
                if (exc.BetweenTest(Convert.ToInt32(textBox2.Text)) == true)
                    MessageBox.Show("Between 5 and 20");
                else
                    MessageBox.Show("Not Between 5 and 20");
                CalcStdDev c = new CalcStdDev();
                MessageBox.Show(textBox2.Text);

            }
            catch
            {
                MessageBox.Show(textBox2.Text + " is not an integer, try again please !");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
