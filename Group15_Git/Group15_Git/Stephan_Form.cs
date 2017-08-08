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
    public partial class Stephan_Form : Form
    {
        public Stephan_Form()
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


                CalcMed c = new CalcMed();
                MessageBox.Show("Median: " + Convert.ToString(c.calcMed(Convert.ToInt32(textBox2.Text))));
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox1.Text + " is not an integer.  Try again!!");
            }
        }
        
}
}
