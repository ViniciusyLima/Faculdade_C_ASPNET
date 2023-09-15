using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomarDoisValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double a, b, s=0.0;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (sender.Equals(button1)) s = a + b;
            if (sender.Equals(button2)) s = a - b;
            if (sender.Equals(button3)) s = a / b;
            if (sender.Equals(button4)) s = a * b;
            label3.Text = "Resultado: " + s;
        }
    }
}
