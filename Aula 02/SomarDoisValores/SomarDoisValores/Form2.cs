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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, s = 0.0;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked) s = a + b;
            if (radioButton2.Checked) s = a - b;
            if (radioButton3.Checked) s = a * b;
            if (radioButton4.Checked) s = a / b;
            label3.Text = "Resultado: " + s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();  //ou frm.Show();
        }

    }
}
