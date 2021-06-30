using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain
{
    public class Aluno : IEntidade
    {

        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public EnumeradorSexo Sexo
        {
            get; set;
        }

        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   Matricula == aluno.Matricula &&
                   Nome == aluno.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Matricula, Nome);
        }

        
        public override string ToString()
        {
            string dataDeNascimento = this.Nascimento.ToString("d");
            string aluno = @$"({this.Matricula}, '{this.Nome}',{this.Sexo}, date '{dataDeNascimento}',{this.CPF})";
            return aluno;
        }

    }
}
