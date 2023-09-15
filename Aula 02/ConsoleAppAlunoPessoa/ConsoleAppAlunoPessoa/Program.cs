using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAlunoPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            String oRgmAluno;
            Console.WriteLine("Digite o RGM do aluno:");
            oRgmAluno = Console.ReadLine();
            Aluno al = new Aluno("José Alves", oRgmAluno, "123.456.789-3");
            Console.WriteLine(al.ToString());

            al.Rgm = "12344-8";  //alteramos a propriedade Rgm
            al.Nome = "Ana Lopes Souza";  //alteramos a propriedade Nome
            Console.WriteLine("Depois de alterar os dados do aluno:");
            Console.WriteLine(al.ToString());
            Console.ReadLine();
        }
    }

    public class Pessoa
    {
        private String nome;  //ou chamar de _nome

        public Pessoa(String nome)   //método construtor
        {
            this.nome = nome;   //ou padrão:  _nome = nome; 
        }

        public String Nome   //esta é a propriedade Nome
        {
            get {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public override string ToString()
        {
            return "Nome: " + Nome;
        }

    }//fim da classe Pessoa

    public class Aluno : Pessoa
    {

        private String rgm, cpf;  //seria mais padrão utilizar:  _rgm, _cpf

        public Aluno(String nome, String umrgm, String cpf) : base(nome)
        {
            Cpf = cpf;    //usando a propriedade Cpf
            Rgm = umrgm;  //usando a propriedade Rgm
        }

        public String Rgm   //esta é a propriedade Rgm
        {   
            get
            {
                return rgm;
            }

            set
            {
                rgm = value;  //palavra reservada value
            }

        }   //fim da propriedade Rgm

        public String Cpf   //esta é a propriedade Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;  //palavra reservada value
            }
        }   //fim da propriedade Cpf


        public override string ToString()
        {
            //chamamos o método ToString() da classe Pessoa e adicionamos
            //os restantes dados do aluno (propriedades Rgm e Cpf):
            return base.ToString() + ", RGM: " + Rgm + ", CPF: " + Cpf;
        }

    }//fim da classe Aluno

}
