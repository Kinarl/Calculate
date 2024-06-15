using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        double firstNumber;
        char arithmetic;
        bool nextOperation = true;

        private void Button_Click(object sender, EventArgs e)
        {
            var inputNumber = ((Button)sender).Text;

            if (textBox1.Text == "0" || nextOperation)
            {
                textBox1.Text = inputNumber;
            }
            else
            {
                textBox1.Text += inputNumber;
            }
            nextOperation = false;
        }

        private void Arithmetic_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + ((Button)sender).Text;
            firstNumber = int.Parse(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = char.Parse(((Button)sender).Text);
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox1.Text);
            textBox2.Text += textBox1.Text;
            nextOperation = true;
            switch (arithmetic)
            {
                case '+':
                    textBox1.Text = Convert.ToString(firstNumber + secondNumber); break;
                case '-':
                    textBox1.Text = Convert.ToString(firstNumber - secondNumber); break;
                case 'x':
                    textBox1.Text = Convert.ToString(firstNumber * secondNumber); break;
                case '/':
                    if (secondNumber <= 0)
                        textBox1.Text = "Неверная операция";
                    else textBox1.Text = Convert.ToString(firstNumber / secondNumber); break;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
