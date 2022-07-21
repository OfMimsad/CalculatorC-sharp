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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
