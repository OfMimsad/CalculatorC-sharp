using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
       String operation = "";
       double firstNum, secondNum;  

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + b.Text;
                }
            } else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void Operational_function(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            firstNum = double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            } 
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);

            } else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btnEQ_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstNum * secondNum);
                    break;
                case "/":
                    txtDisplay.Text = Convert.ToString(firstNum / secondNum);
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string f, s;
            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);

            f = "";
            s = "";
            
        }
    }
}
