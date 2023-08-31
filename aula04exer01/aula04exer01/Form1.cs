using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula04exer01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Vínicius Yonagusuku Lima\nRGM: 4963121457", "Dados");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float res = 0;
            string modelo = comboBox1.SelectedItem.ToString();

            if (modelo.Equals("São Paulo"))
                res = 140.00f;
            if (modelo.Equals("Rio de Janeiro"))
                res = 140.00f;
            if (modelo.Equals("Campo Grande"))
                res = 135.00f;
            if (modelo.Equals("Fortaleza"))
                res = 120.00f;
            if (modelo.Equals("Belo Horizonte"))
                res = 120.00f;
            if (modelo.Equals("Brasília"))
                res = 120.00f;
            if (modelo.Equals("Manaus"))
                res = 120.00f;
            if (modelo.Equals("Recife"))
                res = 120.00f;
            if (modelo.Equals("Salvador"))
                res = 120.00f;
            if (modelo.Equals("Curitiba"))
                res = 120.00f;
            if (modelo.Equals("Natal"))
                res = 120.00f;
            if (modelo.Equals("Aracaju"))
                res = 120.00f;

            if (radioButton2.Checked) 
                res += 30.00f;
            if (radioButton3.Checked) 
                res += 60.00f;

            if (checkBox1.Checked) 
                res += 10.00f;
            if (checkBox2.Checked) 
                res += 15.00f;
            textBox2.Text = "Valor Total: " + res;
        }
    }
}
