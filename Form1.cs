using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_1__WindowsForm_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, a, b;
            n = Convert.ToInt32(textBox1.Text);
            a = Convert.ToInt32(textBox2.Text);
            b = Convert.ToInt32(textBox3.Text);

            if (n < 1)
            {

                textBox4.Text = "Ваше число не натурально";
            }
            else
            {

                string n_string = n.ToString();
                int sum = 0;
                foreach (char c in n_string)
                {
                    sum += (int)Char.GetNumericValue(c); 
                }
                Console.WriteLine(sum);
                textBox4.Text = sum + "fsdf";
                if (sum > a)
                {
                    textBox4.Text = sum + "  Это правда что сумма чисел больше чем a";

                }
                else
                {
                    textBox4.Text = sum + "  Это не правда что сумма чисел больше чем a";
                }

                if (n % 2 != 0)
                {
                    
                    textBox5.Text = "Это правда что n не делиться на b";
                }
                else
                {
                   
                    textBox5.Text = "Это не правда что n не делиться на b";
                }
            }

            

        }
    }
}
