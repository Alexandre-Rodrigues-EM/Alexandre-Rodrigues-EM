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
        public void Add(T objeto) { }
        public void Remove(T objeto) { }
        public void Update(T objeto) { }

        public void GetAll() { }

        public void Get() { }

        RepositorioAbstrato<Aluno> RepositorioAluno = new RepositorioAbstrato<Aluno>();
    }
}
