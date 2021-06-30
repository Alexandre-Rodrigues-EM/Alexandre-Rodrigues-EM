using EM.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EM.Repository
{
    public class RepositorioAbstrato<T> where T : IEntidade

    {
        public void Add(T objeto) 
        {
            AcessoFireBird.InserirDados(objeto);
        }
        public void Remove(T objeto) 
        {
            this.Remove(objeto);
        }
        public void Update(T objeto) 
        { }

        
  /*      public IEnumerable<T> GetAll() where T:IEntidade =>
            typeof(T).Get(
        {
            return ;
        }
        
        public IEnumerable<T> Get(predicate:Expression<Func<T,bool>>) 
        { }
    */
    }

    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        public Aluno GetByMatricula(int matricula)
        {
            Aluno aluno = new Aluno();

            return aluno;
        }
      /*  
        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {
            List<Aluno> ListaNomesCorrespondentes = new List<Aluno>;
            BancoDeDados.Get()
        }
      */
    }
}
