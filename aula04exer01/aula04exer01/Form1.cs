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
            double valor = 60.00;
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
            double valor = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double valor = 30.00;
        }
    }
}
