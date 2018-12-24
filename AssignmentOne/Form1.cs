using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentOne
{
    public partial class MyForm : Form
    {
        Double value = 0;
        String operation;
        bool operator_pressed = false;
        public MyForm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txtCalculation.Text = (value + double.Parse( txtCalculation.Text)).ToString();
                    break;
                case "-":
                    txtCalculation.Text = (value - double.Parse(txtCalculation.Text)).ToString();
                    break;
                case "*":
                    txtCalculation.Text = (value * double.Parse(txtCalculation.Text)).ToString();
                    break;
                case "/":
                    txtCalculation.Text = (value / double.Parse(txtCalculation.Text)).ToString();
                    break;
                default:
                    break;
            }
            operator_pressed = false;
                
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if ((txtCalculation.Text == "0")||(operator_pressed))
            {
                txtCalculation.Clear();
            }
            Button buttonClicked = (Button)sender;
            txtCalculation.Text = txtCalculation.Text+ buttonClicked.Text;
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalculation.Text = "0";
            txtCalculation.Focus();
        }

        private void operation_Clicked(object sender, EventArgs e)
        {
            Button bOperator = (Button)sender;
            operation = bOperator.Text;
            operator_pressed = true;
            value = Double.Parse(txtCalculation.Text);
        }
    }
}
