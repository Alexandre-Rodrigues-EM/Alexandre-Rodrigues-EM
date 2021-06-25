using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain
{
    public class Aluno : IEntidade
    {
        public int Matricula;
        public string Nome; 
        public string CPF;
        public DateTime Nascimento;
        public EnumeradorSexo Sexo;

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
            string codigoHash = Convert.ToString(this.GetHashCode());
            return codigoHash;
        }

    }
}
