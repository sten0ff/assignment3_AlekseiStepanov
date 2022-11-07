using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.Parse(textBox1.Text) / (float.Parse(textBox2.Text) * float.Parse(textBox2.Text)) < 18.5)
            {
                label3.Text = "BMI: " + (float.Parse(textBox1.Text) / (float.Parse(textBox2.Text) * float.Parse(textBox2.Text))).ToString() + "\n" +
                    "Status: Underweight";
            }
            else if (float.Parse(textBox1.Text) / (float.Parse(textBox2.Text) * float.Parse(textBox2.Text)) > 25)
            {
                label3.Text = "BMI: " + (float.Parse(textBox1.Text) / (float.Parse(textBox2.Text) * float.Parse(textBox2.Text))).ToString() + "\n" +
                    "Status: Overweight";
            }
            else
            {
                label3.Text = "BMI: " + (float.Parse(textBox1.Text) / (float.Parse(textBox2.Text) * float.Parse(textBox2.Text))).ToString() + "\n" +
                   "Status: Optimal";
            }
        }
    }
}
