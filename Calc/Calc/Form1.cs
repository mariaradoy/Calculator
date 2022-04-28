using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {

        public string operation;
        public string firstnumber;
        public bool secondnumber;
        public double result, firsValue, secondValue;


        public Form1()
        {
            secondnumber = false;
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (secondnumber == true)
            {
                secondnumber = false;
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            }
            else 
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;

            firstnumber = textBox1.Text;
            secondnumber = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            firsValue = Convert.ToDouble(firstnumber);
            secondValue = Convert.ToDouble(textBox1.Text);
            
            if (operation == "+")
            {
                result = firsValue + secondValue;
            }
            else if(operation == "-")
            {
                result = firsValue - secondValue;
            }
            else if(operation == "*")
            {
                result = firsValue * secondValue;
            }
            else if (operation == "/")
            {
                result = firsValue / secondValue;
            }
            operation = "=";
            secondnumber = true;
            textBox1.Text = Convert.ToString(result);
        }
    }
}
