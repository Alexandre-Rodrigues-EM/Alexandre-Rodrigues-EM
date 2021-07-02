using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using EM.Domain;

namespace EM.Repository
{
    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        public override void Add(Aluno aluno)
        {
            using (var conexaoFireBird = new FbConnection(@"database=localhost:c:\Users\Alexandre - Estagio\Documents\Alexandre-Rodrigues-EM\estudoC#\EM\EM.db\EM2.5.fdb;user=sysdba;password=masterkey"))
            {
                conexaoFireBird.Open();


                string mSQL = $"INSERT into ALUNO Values {aluno.ToString()}";

                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);

                comando.ExecuteNonQuery();

                conexaoFireBird.Close();
            }
        }
        public override void Remove(Aluno aluno)
        {
            using (var conexaoFireBird = new FbConnection(@"database=localhost:c:\Users\Alexandre - Estagio\Documents\Alexandre-Rodrigues-EM\estudoC#\EM\EM.db\EM2.5.fdb;user=sysdba;password=masterkey"))
            {
                conexaoFireBird.Open();


                string mSQL = $"DELETE FROM ALUNO WHERE MATRICULA = {aluno.Matricula}";

                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);

                comando.ExecuteNonQuery();

                conexaoFireBird.Close();
            }
        }
        public override void Update(Aluno aluno)
        {

        }

        public override IEnumerable<Aluno> GetAll()
        {
            List<Aluno> ListaTodosAlunos = new List<Aluno>();

            return ListaTodosAlunos;
        }
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