using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double op1, op2, result = 0;
            string op;
            try
            {
                op1 = Double.Parse(textBox1.Text);
                op2 = Double.Parse(textBox2.Text);
                op = comboBox1.Text;
                switch (op)
                {
                    case "+": result = op1 + op2; label2.Text = Convert.ToString(result); break;
                    case "-": result = op1 - op2; label2.Text = Convert.ToString(result); break;
                    case "*": result = op1 * op2; label2.Text = Convert.ToString(result); break;
                    case "/": result = op1 / op2; label2.Text = Convert.ToString(result); break;
                    default: label2.Text = "请选择正确的运算符"; break;
                }
            }
            catch (System.FormatException ex)
            {
                label2.Text = "请输入正确的操作数";
                Console.WriteLine(ex.Message);
            }
        }
    }
}
