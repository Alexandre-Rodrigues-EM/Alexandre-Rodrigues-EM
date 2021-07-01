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
     
        public static DataTable GetDados()
        {
            using (var conexaoBancoDeDados = new FbConnection(@"database=localhost:c:\Users\Alexandre - Estagio\Documents\Alexandre-Rodrigues-EM\estudoC#\EM\EM.db\EM2.5.fdb;user=sysdba;password=masterkey")) //var conexaoBancoDeDados = new FbConnection("FireBirdConnectionString"))
            {
                conexaoBancoDeDados.Open();
                string mSQL = "Select * from Aluno";
                FbCommand comando = new FbCommand(mSQL, conexaoBancoDeDados);
                FbDataAdapter da = new FbDataAdapter(comando);
                DataTable tabelaDeDados = new DataTable();
                da.Fill(tabelaDeDados);
                return tabelaDeDados;
                
            }
        }

        public static void InserirDados<T> (T objeto)
        {
            
            using (var conexaoFireBird = new FbConnection(@"database=localhost:c:\Users\Alexandre - Estagio\Documents\Alexandre-Rodrigues-EM\estudoC#\EM\EM.db\EM2.5.fdb;user=sysdba;password=masterkey"))
            {
                conexaoFireBird.Open();
                string TabelaDestino = Convert.ToString(objeto.GetType().Name);
                string mSQL = $"INSERT into {TabelaDestino} Values {objeto.ToString()}";
              
               // string mSQL = "INSERT into Aluno (MATRICULA, NOME, SEXO, NASCIMENTO) values(101010101,'Thyago Martins', 1, date '20.04.1980')";

               // using (var comando = new FbCommand())

                
                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);
                comando.ExecuteNonQuery();
                conexaoFireBird.Close();
            }
            
        }

        //public static void AlteraDados<T> (T objeto)
        //{
        //    conexaoFireBird.Open();
        //    string TabelaDestino = Convert.ToString(objeto.GetType().Name);
        //    string mSQL = $"UPDATE into {TabelaDestino}" +
        //        $"Where Values {objeto.ToString()}";

        //    // string mSQL = "INSERT into Aluno (MATRICULA, NOME, SEXO, NASCIMENTO) values(101010101,'Thyago Martins', 1, date '20.04.1980')";

        //    // using (var comando = new FbCommand())


        //    FbCommand comando = new FbCommand(mSQL, conexaoFireBird);
        //    comando.ExecuteNonQuery();
        //    conexaoFireBird.Close();
        //}

    }
}
