using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAttributes
{
    public class Aluno
    {
        /// <summary>
        /// Student's name to uppercase.
        /// </summary>
        [Uppercase]
        public string Nome { get; set; }

        /// <summary>
        /// Student's age to year of birth.
        /// </summary>
        [YearOfBirth]
        public int AnoDeNascimento { get; set; }

        public Aluno(string nome, int idade)
        {
            this.Nome = nome;
            this.AnoDeNascimento = idade;
        }
    }
}
