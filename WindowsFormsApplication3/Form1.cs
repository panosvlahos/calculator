using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent(); 
        }
       

            private void Form1_Load(object sender, EventArgs e)
            {
            }
        String num1;
        String praxis;

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

        }

        /* buttons */
        private void button0_Click(object sender, EventArgs e)
        {
            int a = 0;
            textBox1.Text += a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            textBox1.Text += a.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 2;
            textBox1.Text += a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 3;
            textBox1.Text += a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 4;
            textBox1.Text += a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 5;
            textBox1.Text += a.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 6;
            textBox1.Text += a.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 7;
            textBox1.Text += a.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 8;
            textBox1.Text += a.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = 9;
            textBox1.Text += a.ToString();
        }

        /*praxeis*/
        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (praxis == "add") { 
            String num2 = textBox1.Text;
            double y = Convert.ToDouble(num2);
            double x = Convert.ToDouble(num1); //na ginoun float gia na kanoume praxeis me dekadikous
            double sum = x + y;
            textBox1.Text = Convert.ToString(sum);
        }
            if (praxis == "sub")
            {
                String num2 = textBox1.Text;
                int y = Convert.ToInt32(num2);
                int x = Convert.ToInt32(num1);
                int sum = x - y;
                textBox1.Text = Convert.ToString(sum);
            }

            if (praxis == "mul")
            {
                String num2 = textBox1.Text;
                int y = Convert.ToInt32(num2);
                int x = Convert.ToInt32(num1);
                int sum = x * y;
                textBox1.Text = Convert.ToString(sum);
            }

            if (praxis == "div")
            {
                String num2 = textBox1.Text;
                int y = Convert.ToInt32(num2);
                int x = Convert.ToInt32(num1);
                int sum = x / y;
                textBox1.Text = Convert.ToString(sum);
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = textBox1.Text;
            praxis = "add";
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = "";
            praxis = "sub";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = "";
            praxis = "mul";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = "";
            praxis = "div";
        }
    }
}
