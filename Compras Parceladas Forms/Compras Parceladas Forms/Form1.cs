using System.Configuration;
using System.Drawing;

namespace Compras_Parceladas_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double valorParcela, valorFinal;
            double desconto = 0.10;
            double juros = 0.07;

            double valor = double.Parse(textBox1.Text);
            int parcela = int.Parse(textBox2.Text);

            if (parcela <= 1)
            {
                valorFinal = valor - (valor * desconto);
                valorParcela = valorFinal;
            }
            else if (parcela <= 5)
            {
                valorParcela = valor / parcela;
                valorFinal = valor;
            }
            else
            {
                valorFinal = valor + (valor * juros);
                valorParcela = valorFinal / parcela;
            }
            label4.Text = "Valor das parcelas =  " + valorParcela;
            label5.Text = "Valor total da compra =  " + valorFinal;
        }
    }
}