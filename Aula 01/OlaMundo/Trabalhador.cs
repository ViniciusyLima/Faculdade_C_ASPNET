using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    internal class Trabalhador
    {
        private string nome;
        private float salario;

        public Trabalhador(string nome, float salario)
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public float Salario
        {
            get => salario;
            set => salario = value;
        }

        public string toString()
        {
           return nome + ", salário R$" + Salario;
        }
    }
}
