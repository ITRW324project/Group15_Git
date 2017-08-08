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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Stephan_Form ss = new Stephan_Form();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Altus alt = new Altus();
            alt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            David daf = new David();
            daf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simeon sim = new Simeon();
            sim.Show();
        }
    }
}
