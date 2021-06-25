using EM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Repository
{
    public class RepositorioAbstrato<T> where T : IEntidade

    {
        public void Add(T objeto) 
        {
            this.Add(objeto);
        }
        public void Remove(T objeto) 
        {
            this.Remove(objeto);
        }
        public void Update(T objeto) 
        { }

        public IEnumerable<T> GetAll() 
        {
            private IEnumerator<T> GetEnumerator()
            {
                return new GetAll();

            }
        }

        public void Get() 
        { }
    
    }

    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        public Aluno GetByMatricula(int matricula)
        {
            Aluno aluno = new Aluno();

            return aluno;
        }

        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {
            public void Enumerador 
        }
    }
}
