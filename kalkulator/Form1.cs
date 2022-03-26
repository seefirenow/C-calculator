using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        string sign;
        double num1;
        double num2;
        bool startNewNumber = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumberBt_Click("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberBt_Click("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberBt_Click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberBt_Click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberBt_Click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberBt_Click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberBt_Click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberBt_Click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberBt_Click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberBt_Click("9");
        }

        private void NumberBt_Click(string number)
        {
            if (startNewNumber == false)
            {
                textBox1.Text += number;
            }
            else
            {
                textBox1.Text = number;
                startNewNumber = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Operation("√");
            textBox1.Text = Convert.ToString(Math.Sqrt (Convert.ToDouble(textBox1.Text)));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Operation("1/x");
            textBox1.Text = Convert.ToString(1/Convert.ToDouble(textBox1.Text));
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Operation("%");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            label1.Text = String.Empty;
            switch (sign)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        textBox1.Text = "Nie można dzielić przez 0";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(num1 / num2);
                    }
                    break;
                case "√":
                    textBox1.Text = Convert.ToString(Math.Sqrt(num1));
                    break;
                case "%":
                    textBox1.Text = Convert.ToString((num1 / 100) * num2);
                    break;
                case "1/x":
                    textBox1.Text = Convert.ToString(1 / num1);
                    break;
            }
            sign = String.Empty;
            startNewNumber = true;

            
        }
        private void Operation(string sign)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text;
            label1.Text += sign;
            this.sign = sign;
            startNewNumber = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = String.Empty;
            sign = String.Empty;
            startNewNumber = true;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            startNewNumber = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length ==1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
                }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text +=",";
                startNewNumber = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * -1);        }
    }
}
