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
        public Form1()
        {
            InitializeComponent();
        }

        private double firstNumber;
        private double secondNumber;
        private string operation; // (+, -, *, /)
        private bool NewInput;


        private void button0_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "0";
                NewInput = false;
            }
            else
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "0";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "1";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "2";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "3";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "4";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "5";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "6";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "7";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "8";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (NewInput)
            {
                textBox1.Text = "9";
                NewInput = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }


        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            NewInput = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            firstNumber = double.Parse(textBox1.Text);
            operation = "+";
            NewInput = true;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            firstNumber = double.Parse(textBox1.Text);
            operation = "-";
            NewInput = true;
        }

      
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            firstNumber = double.Parse(textBox1.Text);
            operation = "/";
            NewInput = true;
        }

       
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            firstNumber = double.Parse(textBox1.Text);
            operation = "*";
            NewInput = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            if (!NewInput)
            {            
                secondNumber = double.Parse(textBox1.Text);
            }

            switch (operation)
            {
                case "+":
                    textBox1.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    textBox1.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    textBox1.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                        textBox1.Text = (firstNumber / secondNumber).ToString();
                    else
                        textBox1.Text = "Ошибка";
                    break;

            }

            listHistory.Items.Add($"{firstNumber} {operation} {secondNumber} = {textBox1.Text}");
            listHistory.TopIndex = listHistory.Items.Count - 1;

            firstNumber = double.Parse(textBox1.Text);
            NewInput = true;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (NewInput || string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0,";
                NewInput = false;
                return;
            }

            if (!textBox1.Text.Contains(",") && !textBox1.Text.Contains("."))
            {
                textBox1.Text += ",";
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            double current = double.Parse(textBox1.Text);
            textBox1.Text = (current * -1).ToString();
        }

        
    }
}
