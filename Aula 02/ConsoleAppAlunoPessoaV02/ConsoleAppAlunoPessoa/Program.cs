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
            Aluno al = new Aluno("José Alves", oRgmAluno, "333.444.555-6");
            Console.WriteLine("\nDados iniciais do aluno: \n" + al.ToString());

            al.Rgm = "12345-6";            //alteramos a propriedade Rgm
            al.Nome = "Ana Lopes Souza";   //alteramos a propriedade Nome
            al.Cpf = "123.456.789-10";     //alteramos a propriedade Cpf
            Console.WriteLine("\nDepois de alterar todos os dados do aluno:");
            Console.WriteLine(al.ToString());
            Console.ReadLine();
        }
    }

    public class Pessoa
    {
        //Observe que não declaramos nenhum atributo nesta classe
        public Pessoa(String nome)   //método construtor
        {
          Nome = nome; //utilizamos a propriedade Nome
        }

        public String Nome   //esta é a propriedade Nome
        { get; set; }  //notação para uma propriedade 'autoimplementada' 

        public override string ToString()
        {
            return "Nome: " + Nome;
        }

    }//fim da classe Pessoa

    public class Aluno : Pessoa   //Aluno é uma classe derivada de Pessoa
    {
        //Observe que não declaramos nenhum atributo nesta classe
        public Aluno(String nome, String rgm, String cpf) : base(nome)
        {
             Cpf = cpf;  //usando a propriedade Cpf
             Rgm = rgm;  //usando a propriedade Rgm
        }

        public String Rgm   //esta é a propriedade Rgm 'autoimplementada'
        { get; set; }

        public String Cpf   //exemplo de uma propriedade 'autoimplementada'
        { get; set; }       //se for uma propriedade de somente leitura: { get; }

        public override string ToString()
        {
            //chamamos o método ToString() da classe Pessoa e adicionamos
            //os restantes dados do aluno (propriedades Rgm e Cpf):
            return base.ToString() + ", RGM: " + Rgm + ", CPF: " + Cpf;
        }

    }//fim da classe Aluno

}
