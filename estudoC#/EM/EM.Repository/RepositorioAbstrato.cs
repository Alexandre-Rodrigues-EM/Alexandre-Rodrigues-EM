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
            this.Add(objeto);
        }
        public void Remove(T objeto) 
        {
            this.Remove(objeto);
        }
        public void Update(T objeto) 
        { }

        /*
        public IEnumerable<T> GetAll() 
        {
            DataTable tabelaDeTudo = new DataTable();
            tabelaDeTudo = AcessoFireBird.FireBird_GetDados();
            List<T> ListaTudo = new List<T>;

            var itemsDaTabela = tabelaDeTudo.AsEnumerable().Select(linha =>
            {
                Matricula = linha.Field<T>("MATRICULA"),
                Nome = linha.Field<T>("NOME")
            }).ToList();
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
