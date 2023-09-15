namespace LojaColchoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //l�gica do bot�o Calcular
            int posicao = listBox1.SelectedIndex;
            if (posicao == -1)
            {
                MessageBox.Show("Por favor, selecione um modelo", "Selecionar");
            }
            else
            {
                float preco = 0.0f;
                string modelo = listBox1.SelectedItem.ToString();
                //MessageBox.Show(modelo);
                if (modelo.Equals("colch�o infantil"))
                    preco = 850.00f;
                if (modelo.Equals("colch�o solteiro"))
                    preco = 1200.00f;
                if (modelo.Equals("colch�o casal"))
                    preco = 2000.00f;
                if (modelo.Equals("colch�o queen"))
                    preco = 2350.00f;
                if (modelo.Equals("colch�o king"))
                    preco = 4300.00f;
                if (modelo.Equals("colch�o super king"))
                    preco = 5800.00f;

                /* outra forma de verificar o modelo de colch�o selecionado:
                switch (posicao) {
                    case 0:  //colch�o infantil
                        preco = 850.00f;
                        break;
                    case 1: //colch�o solteiro
                        preco = 1200.00f;
                        break;
                    case 2:
                        preco = 2000.00f;
                        break;
                    case 3:
                        preco = 2350.00f;
                        break;
                    case 4:
                        preco = 4300.00f;
                        break;
                    case 5: //colch�o super king
                        preco = 5800.00f;
                        break;
                }
                */

                //considerar o tipo de pagamento:
                if (radioButton1.Checked == true)
                { //pagto � vista, tem desconto de 5%
                    preco = preco - 5.0f / 100.0f * preco;
                }
                if (radioButton2.Checked)
                { //pagto em at� 3X
                    preco = preco; //sem desconto, nem juros
                }
                if (radioButton3.Checked)
                { //pagto em 4, 5 ou 6 vezes ter� juros de 7%
                    preco = preco + 7.0f / 100.0f * preco;
                }

                //compra adicional do box, para qualquer tipo de colch�o,
                //por apenas R$ 400,00, que n�o entram nos descontos nem
                //nos acr�scimos

                if (checkBox1.Checked == true)  //vai comprar o box?
                {
                    preco += 400.0f;  // mais R$ 400,00
                }

                MessageBox.Show("Voc� ir� pagar R$ " + preco, "Pagamento");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre tela = new Sobre();
            tela.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Sobre tela = new Sobre();
            tela.ShowDialog();
        }
    }
}