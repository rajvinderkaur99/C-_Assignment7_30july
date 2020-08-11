using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculateLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace WinCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator cal = new Calculator();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cal.num1 = Convert.ToInt32(textBox1.Text);
            cal.num2 = Convert.ToInt32(textBox2.Text);
            lblOutput.Text="Addition Result:" +cal.Add().ToString();
            textBox1.Text = " ";
            textBox2.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cal.num1 = Convert.ToInt32(textBox1.Text);
            cal.num2 = Convert.ToInt32(textBox2.Text);
            lblOutput.Text = "Subtraction Result" +cal.Sub().ToString();
            textBox1.Text = " ";
            textBox2.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cal.num1 = Convert.ToInt32(textBox1.Text);
            cal.num2 = Convert.ToInt32(textBox2.Text);
            lblOutput.Text = "Multiplication Result" +cal.Multiple().ToString();
            textBox1.Text =" ";
            textBox2.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cal.num1 = Convert.ToInt32(textBox1.Text);
            cal.num2 = Convert.ToInt32(textBox2.Text);
            lblOutput.Text ="Divide Result" + cal.Divide().ToString();
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
