using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beginner_C_Sharp_WinFormsApp_Assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + textBox3.Text + textBox2.Text + textBox4.Text + textBox5.Text + textBox6.Text;
            Random random = new Random();
            int number = random.Next(1, 100);
            int number1 = random.Next(1, 100);
            int A = number + number1; int AB = number - number1; int ABC = number * number1; int ABCD = number / number1;
            label2.Text = "" + number + "+" + number1 + "=" + A + "  " + number + "-" + number1 + "=" + AB + "  " + number + "*" + number1 + "=" + ABC + "  " + number + "/" + number1 + "=" + ABCD;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
