using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Both numbers are mandortry");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int sum = num1 + num2;
                MessageBox.Show(sum.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Both numbers are mandortry");
                }
                else
                {
                    int num1 = Int32.Parse(textBox1.Text);
                    int num2 = Int32.Parse(textBox2.Text);
                    int subtract = num1 - num2;
                    MessageBox.Show(subtract.ToString());
                }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Both numbers are mandortry");
                }
                else
                {
                    int num1 = Int32.Parse(textBox1.Text);
                    int num2 = Int32.Parse(textBox2.Text);
                    int multiply = num1 * num2;
                    MessageBox.Show(multiply.ToString());
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Both numbers are mandortry");
            }
            else
            {
                float num1 = Int32.Parse(textBox1.Text);
              float num2 = Int32.Parse(textBox2.Text);
                float Divide = num1 / num2;
                MessageBox.Show(Divide.ToString());
            }

        }
    }
}
