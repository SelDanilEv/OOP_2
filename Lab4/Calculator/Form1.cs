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
        float a, b;
        int CalcOperator;
        bool sign = true;

        public void takeOperator(int oper)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            CalcOperator = oper;
            switch (oper)
            {
                case 1:
                    label1.Text = a.ToString() + "+";
                    break;
                case 2:
                    label1.Text = a.ToString() + "-";
                    break;
                case 3:
                    label1.Text = a.ToString() + "*";
                    break;
                case 4:
                    label1.Text = a.ToString() + "/";
                    break;
            }
            sign = true;
        }

        private void calculate()
        {
            switch (CalcOperator)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            takeOperator(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            takeOperator(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            takeOperator(3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            takeOperator(4);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text += text[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }
    }
}
