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
        private static readonly AcessoFireBird instanciaFireBird = new AcessoFireBird();
        private AcessoFireBird() { }

        //string StringDeConexão = @"database=localhost:c:\Users\Alexandre - Estagio\Documents\Alexandre-Rodrigues-EM\estudoC#\EM\EM.db\EM2.5.fdb;user=sysdba;password=masterkey"; 
        public static AcessoFireBird GetInstancia()
        {
            return instanciaFireBird;
        }

        /* public FbConnection GetConexao()
         {
             string parametrosDeConexao = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ConnectionString;
             return new FbConnection(parametrosDeConexao);
         }
        */
        public static void TesteDeConexao()
        {
            using (var conexaoBancoDeDados = new FbConnection(@"database=localhost:c:\Users\Alexandre - Estagio\Documents\Alexandre-Rodrigues-EM\estudoC#\EM\EM.db\EM2.5.fdb;user=sysdba;password=masterkey"))
            {
                conexaoBancoDeDados.Open();
                Console.Write("Conexão estabelecida");
                conexaoBancoDeDados.Close();

            }
        }
     
        /*public static void GetDados()
        {
            using (var conexaoBancoDeDados = new FbConnection(@"database=localhost:c:\Users\Alexandre - Estagio\Documents\Alexandre-Rodrigues-EM\estudoC#\EM\EM.db\EM2.5.fdb;user=sysdba;password=masterkey")) //var conexaoBancoDeDados = new FbConnection("FireBirdConnectionString"))
            {
                conexaoBancoDeDados.Open();
                using (var transaction = conexaoBancoDeDados.BeginTransaction())
                {
                    using (var comandoSQL = new FbCommand("Select * from Aluno", conexaoBancoDeDados, transaction))
                    {
                        using (var reader = comandoSQL.ExecuteReader())
                        {
                            DataTable Tabela = new DataTable();

                            while (reader.Read())
                            {
                                var valores = new object[reader.FieldCount];
                                Tabela.Rows.Add(reader.GetValues(valores));
                            }
                            foreach (DataRow coluna in Tabela.Rows)
                            {
                                Console.Write(Tabela.Rows);
                            }
                               
                        }
                    }
                }
                /*string mSQL = "Select * from Alunos";
                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);
                FbDataAdapter da = new FbDataAdapter(comando);
                DataTable tabelaDeDados = new DataTable();
                return tabelaDeDados;
                
            }
        }
*/
        public static void InserirDados<T> (T objeto)
        {
            
            using (var conexaoFireBird = new FbConnection(@"database=localhost:c:\Users\Alexandre - Estagio\Documents\Alexandre-Rodrigues-EM\estudoC#\EM\EM.db\EM2.5.fdb;user=sysdba;password=masterkey"))
            {
                conexaoFireBird.Open();
                string TabelaDestino = Convert.ToString(objeto.GetType().Name);
                string mSQL = $"INSERT into {TabelaDestino} Values({objeto.ToString()})";
              
               // string mSQL = "INSERT into Aluno (MATRICULA, NOME, SEXO, NASCIMENTO) values(101010101,'Thyago Martins', 1, date '20.04.1980')";

               // using (var comando = new FbCommand())

                
                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);
                comando.ExecuteNonQuery();
            }
            
        }



    }
}
