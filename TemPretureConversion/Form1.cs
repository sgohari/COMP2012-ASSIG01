using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemPretureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cel;
            double far;

            far = double.Parse(txtFa.Text);
            cel = 5.0 / 9.0 * (far - 32);
            lbDisplay.Text = cel.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFa.Text = "";
            lbDisplay.Text = "";
            txtFa.Focus();

        }
    }
}
