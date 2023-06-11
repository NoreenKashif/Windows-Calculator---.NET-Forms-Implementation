using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayText(string text)
        {
            textBox1.Text += text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button14_Click(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click_1(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private string Add(double n1, double n2)
        {
            double res = n1 + n2;
            string res1 = res.ToString();
            MessageBox.Show(res1);
            return res1;
        }
        private string Subtract(double n1, double n2)
        {
            string num;
            double sub = 0.0;
            if(n2 > n1)
            {
                sub = n2 - n1;
                num = "-" + sub;
                return num;
            }
            sub = n1 - n2;
            return sub.ToString();
        }
        private string Divide(double n1, double n2)
        {
            if(n2 == 0)
            {
                MessageBox.Show($"Division by 0 is infinite!!!");
            }
            double res =  n1 / n2;
            
            string res1 = res.ToString();
            return res1;
        }
        private string Multiply(double n1, double n2)
        {
            double res =  n1 * n2;
            string result = res.ToString();
            return result;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            /* string resultTextBox = " ";
             string text = textBox1.Text;
             if (string.IsNullOrEmpty(text))
             {
                 MessageBox.Show("Enter Expression to evaluate!!!!");
                 return;
             }
             //MessageBox.Show(text);
             string[] equation = text.Split('+', '-', '*', '/');
             if ((string.IsNullOrEmpty(equation[0])) || (string.IsNullOrEmpty(equation[1])))
             {
                 MessageBox.Show($"Operation can't perform\nEnter valid expression!!!!");
                 textBox1.Text = "";
                 return;
             }
             int length = equation.Length;
             int i = 0;
             int index = 0;
             while(i<length)
             {

             }
             //char[] operators = { '+', '-', '/', '*' };//9+9-98+8*1
             char[] ch = text.ToArray();
             char[] add = Array.FindAll(ch,x => x == '+');
             char[] subtract = Array.FindAll(ch, x => x == '-');
             char[] div = Array.FindAll(ch, x => x == '/');
             char[] mul = Array.FindAll(ch, x => x == '*');

             //while (i < length)
             //{
             //    double num1 = double.Parse(equation[i]);
             //    double num2 = double.Parse(equation[i+1]);
             //    foreach (var c in operator1)
             //    {
             //
             //        MessageBox.Show($"The character '{c}' is in both arrays");
             //    }
             //
             //}

             //double num1 = double.Parse(equation[0]);
             //double num2 = double.Parse(equation[1]);


             //MessageBox.Show(op);

            // if(op == "+")
            // {
            //     resultTextBox = Add(num1, num2);
            // }
            // if(op == "-")
            // {
            //     resultTextBox = Subtract(num1, num2);
            // }
            // if(op == "*")
            // {
            //     resultTextBox = Multiply(num1, num2);
            // }
            // if(op == "/")
            // {
            //     resultTextBox = Divide(num1,num2);
            // }
            // textBox1.Text = "";
            // textBox1.Text = resultTextBox;
            */
            string input = textBox1.Text;
            double result = 0;

            // Split the input string into tokens using whitespace as the delimiter
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Perform the operations in the correct order
            for (int i = 0; i < tokens.Length; i++)
            {
                if (i == 0)
                {
                    // The first token is a number, so set the result to its value
                    result = double.Parse(tokens[i]);
                }
                else if (i % 2 == 1)
                {
                    // The odd-indexed tokens are operators
                    string op = tokens[i];
                    double operand = double.Parse(tokens[i + 1]);

                    // Perform the operation
                    switch (op)
                    {
                        case "+":
                            result += operand;
                            break;
                        case "-":
                            result -= operand;
                            break;
                        case "*":
                            result *= operand;
                            break;
                        case "/":
                            result /= operand;
                            break;
                        default:
                            throw new Exception("Invalid operator: " + op);
                    }
                }
            }

            // Display the result in the output textbox
            textBox1.Text = result.ToString();
        }


    

        
        

        private void btn_click_num(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DisplayText(button.Text);
        }

        private void button_clear(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
