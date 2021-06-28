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
    public class AcessoFireBird
    {
     /*   private static readonly AcessoFireBird instanciaFireBird = new AcessoFireBird();
        private AcessoFireBird() { }

        public static AcessoFireBird GetInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection GetConexao()
        {
            string parametrosDeConexao = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ConnectionString;
            return new FbConnection(parametrosDeConexao);
        }
     */
        public static DataTable GetDados()
        {
            using (var conexaoFireBird = new FbConnection("database=localhost:EM2.5.fdb;use=sysdba;password=masterkey"))
            {
                conexaoFireBird.Open();
                using (var transaction = conexaoFireBird.BeginTransaction())
                {
                    using (var comandoSQL = new FbCommand("Select * from Alunos", conexaoFireBird, transaction))
                    {
                        using (var reader = comandoSQL.ExecuteReader())
                        {
                            DataTable Tabela = new DataTable();
                            while (reader.Read())
                            {
                                var valores = new object[reader.FieldCount];
                                Tabela.Rows.Add(reader.GetValues(valores));
                            }
                            return Tabela;
                        }
                    }
                }
                /*string mSQL = "Select * from Alunos";
                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);
                FbDataAdapter da = new FbDataAdapter(comando);
                DataTable tabelaDeDados = new DataTable();
                return tabelaDeDados;
                */
            }
        }

        public static void InserirDados(Aluno aluno)
        {
            /*
            using (var conexaoFireBird = new FbConnection("database=localhost:EM2.5.fdb;use=sysdba;password=masterkey"))
            {
                conexaoFireBird.Open();
                string mSQL = "INSERT into Clientes Values(" + aluno.Matricula + ",'"
                    + aluno.Nome + "','"
                    + aluno.Sexo + "','"
                    + aluno.Nascimento + "','"
                    + aluno.CPF + "')";
                using (var comando = new FbCommand())

                
                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);
                comando.ExecuteNonQuery();
                
            }
            */
        }


    }
}
