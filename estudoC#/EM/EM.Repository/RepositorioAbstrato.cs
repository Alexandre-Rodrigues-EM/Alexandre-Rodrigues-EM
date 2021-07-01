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
        public virtual void Add(T objeto) 
        {
            AcessoFireBird.InserirDados(objeto);
        }
        public virtual void Remove(T objeto) 
        {
            this.Remove(objeto);
        }
        public virtual void Update(T objeto) 
        {

        }

        public virtual IEnumerable<T> GetAll()
        {
            return 
        }
        
        public IEnumerable<T> Get(Expression<Func<T,bool>>:predicate) 
        { }
    */
    }

    
    }
}
