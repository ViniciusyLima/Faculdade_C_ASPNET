using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaBDMySQL
{
    public partial class CadastroDoAluno : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conexao
            = new MySql.Data.MySqlClient.MySqlConnection
            ("server=localhost; user id=root; password=; database=escola");
        MySql.Data.MySqlClient.MySqlCommand stm;

        public CadastroDoAluno()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlNovo = "INSERT INTO alunos (rgm,nome,idade,sexo,semestre,curso) VALUES "
                    + "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," +
                    "'" + textBox5.Text + "','" + textBox4.Text + "','" + textBox6.Text + "');";
                stm = new MySql.Data.MySqlClient.MySqlCommand(sqlNovo, conexao);
                int quant = stm.ExecuteNonQuery();
                if (quant == 1)
                {
                    MessageBox.Show(null, "Aluno matriculado", "Ok.");
                }
                stm.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Erro adicionando curso" + ex.Message, "Erro!");
            }
        }

        private void CadastroDoAluno_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Erro na conexão" + ex.Message, "Erro");
            }

        }

        private void CadastroDoAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexao.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        


    }
}
