namespace aula03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicao = listBox1.SelectedIndex;
            if (posicao == -1)
            {
                MessageBox.Show("Por favor, selecione um modelo", "Selecionar");
            }
            else
            {
                float preco = 0.0f;
                string modelo = listBox1.SelectedItem.ToString();

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
                MessageBox.Show("Voc� ir� pagar R$ " + preco, "Pagamento");
            }
        }
    }
}