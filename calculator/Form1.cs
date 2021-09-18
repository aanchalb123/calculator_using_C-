using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        string function;
        double result=0.0;
        string userinput = "";
        double firstnum;
        double secondnum;

        public Form1()
        {
            InitializeComponent();
        }

        private void num5_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "5";
            display.Text += userinput;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "1";
            display.Text += userinput;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "2";
            display.Text += userinput;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userinput = "";
            result = 0.0;
            display.Text = "0";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "3";
            display.Text += userinput;
        }

        private void div_Click(object sender, EventArgs e)
        {
            function = "/";
            first = userinput;
            userinput = "";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            function = "*";
            first = userinput;
            userinput = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            function = "+";
            first = userinput;
            userinput = "";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            function = "-";
            first = userinput;
            userinput = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
     
            second = userinput;
          
            firstnum = Convert.ToDouble(first);
            secondnum = Convert.ToDouble(second);

            if(function == "+")
            {
                result = firstnum + secondnum;
                display.Text = result.ToString();
            }
            else if(function == "-")
            {
                result = firstnum - secondnum;
                display.Text = result.ToString();
            }
            else if(function == "*")
            {
                result = firstnum * secondnum;
                display.Text = result.ToString();
            }
            else if(function == "/")
            {
                if(secondnum == '0')
                {
                    display.Text = "noo";
                }
                else
                {
                    result = firstnum / secondnum;
                    display.Text = result.ToString();
                }
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "4";
            display.Text += userinput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "6";
            display.Text += userinput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "7";
            display.Text += userinput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "8";
            display.Text += userinput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "9";
            display.Text += userinput;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userinput += "0";
            display.Text += userinput;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            userinput += ".";
            display.Text = userinput;
        }
    }
}
