namespace exer02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vParcela, vFinal;
            double desconto = 0.10;
            double juros = 0.07;

            double valor = double.Parse(textBox1.Text);
            int parcela = int.Parse(textBox2.Text);

            if (parcela <= 1)
            {
                vFinal = valor - (valor * desconto);
                vParcela = vFinal;
            }
            else if (parcela <= 5)
            {
                vParcela = valor / parcela;
                vFinal = valor;
            }
            else
            {
                vFinal = valor + (valor * juros);
                vParcela = vFinal / parcela;
            }
            label3.Text = "Valor da parcela = " + vParcela;
            label4.Text = "Valor total = " + vFinal;


        }
    }
}