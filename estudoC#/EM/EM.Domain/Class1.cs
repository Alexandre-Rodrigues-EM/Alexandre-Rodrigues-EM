using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain
{
    class AlunosContext : DbContext
    {
        public AlunosContext() : base("BancoAlunos")
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
