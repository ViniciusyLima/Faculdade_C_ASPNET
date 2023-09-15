namespace Exer03
{
    public partial class Form1 : Form
    {
        public Form1()
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
            if (radioButton5.Checked) s = (a + b) / 2;

            label4.Text = "Resultado: " + s;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox3.Text);
            c = c * c;
            label5.Text = "Resultado: " + c;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        { }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre tela = new Sobre();
            tela.ShowDialog();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}