using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SomeMethod(int N)
        {
            double s = 0;
            double f = 1;

            for (int i = 1; i <= N; i++)
            {
                f *= i; 
                s += f;
            }
            label2.Text = "Сумма факториалов от 1 до " + N + " равна: " + s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int N) && N > 0)
            {
                SomeMethod(N);
            }
            else
            {
                label1.Text = "Введите корректное положительное целое число.";
            }
        }





    }
}
