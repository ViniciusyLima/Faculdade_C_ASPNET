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
            String oRgmAluno, oNome;
            float media;  int idade;

            Console.WriteLine("Digite o nome do aluno:");
            oNome = Console.ReadLine();
            Console.WriteLine("Digite o RGM do aluno:");
            oRgmAluno = Console.ReadLine();
            Console.WriteLine("Digite a média do aluno:");
            media = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a idade do aluno:");
            idade = Convert.ToInt16(Console.ReadLine());
            Aluno al = new Aluno(oNome, oRgmAluno, media, idade);

            Console.WriteLine("\nDados iniciais do aluno: \n" + al.ToString());

            al.Rgm = "123456-7";            //alteramos a propriedade Rgm
            al.Nome = "Ana Lopes Souza";    //alteramos a propriedade Nome
            al.Media = 8.5f;                //alteramos a propriedade Media
            al.Idade = 28;                  //alteramos a idade (propriedade Idade)
            
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
        public Aluno(String nome, String rgm, float media, int idade)
                     : base(nome)  //chamamos o construtor da classe mãe
        {
             Rgm = rgm;  //usando a propriedade Rgm
             Media = media; //usando a propriedade Media
             Idade = idade; //usando a propriedade Idade
        }

        public String Rgm   //esta é a propriedade Rgm 'autoimplementada'
        { get; set; }

        public float Media   //exemplo de uma propriedade 'autoimplementada'
        { get; set; }        //se for uma propriedade de somente leitura: { get; }
        
        public int Idade    //exemplo de uma propriedade 'autoimplementada'
        { get; set; }       //se for uma propriedade de somente leitura: { get; }

        public override string ToString()
        {
            //chamamos o método ToString() da classe Pessoa e adicionamos
            //os restantes dados do aluno (propriedades Rgm e Cpf):
            return base.ToString() + ", RGM: " + Rgm + ", média: " + Media
                                   + ", idade: " + Idade;
        }

    }//fim da classe Aluno

}
