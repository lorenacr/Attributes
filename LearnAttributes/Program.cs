using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnAttributes
{
    class Program
    {
        static void Main()
        {          
            string nome = "lorena";
            int idade = 20;

            Aluno aluno = new Aluno(nome, idade);

            object student = CommandParser.Parse(aluno);
            
            Console.Clear();
            Console.WriteLine("Nome: " + aluno.Nome + ", Ano de nascimento: " + aluno.AnoDeNascimento);

            Console.ReadKey(true);
        }
    }
}
