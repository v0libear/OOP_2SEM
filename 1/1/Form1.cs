﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Calc : Form 
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button10_Click(object sender, EventArgs e)/// And
        {
            textBox1.Text += "\r\n&\r\n";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)/// радио 2
        {

        }

        public void button20_Click(object sender, EventArgs e)/// == РАВНО
        {
            try
            {
                int result = Calculator.Parse(textBox1.Lines);

                //В КАКАОЙ СС ОТВЕТ
                int intBase = 0;
                if (radioBatnHex.Checked)
                    intBase = 16;
                else if (radioBtnBinary.Checked)
                    intBase = 2;
                else if (radioBtnDecemical.Checked)
                    intBase = 10;
                else if (radioBtnOctal.Checked)
                    intBase = 8;

                textBox1.Clear();
                textBox1.AppendText("\r\n=" + Convert.ToString(result, intBase));
                textBox1.AppendText("\r\n");
            }
            catch (Exception)
            {
                textBox1.AppendText("\r\nERROR\r\n");
            }

        }

        private void button11_Click(object sender, EventArgs e)/// Or
        {
            textBox1.Text += "\r\n|\r\n";
        }

        private void button13_Click(object sender, EventArgs e)/// XOR
        {
            textBox1.Text += "\r\n^\r\n";
        }

        private void button12_Click(object sender, EventArgs e)/// Neg
        {
            textBox1.Text += "\r\n~";
        }

        private void button14_Click(object sender, EventArgs e)/// 0
        {
            textBox1.Text += '0';
        }

        public void button18_Click(object sender, EventArgs e)/// CE
        {
        textBox1.Clear();
        }

        private void radioBtnOctal_CheckedChanged(object sender, EventArgs e)/// радио 8
        {

        }

        private void radioBatnHex_CheckedChanged(object sender, EventArgs e)/// радио 16
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
