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

        public static AcessoFireBird GetInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection GetConexao()
        {
            string parametrosDeConexao = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(parametrosDeConexao);
        }

        public static DataTable GetDados()
        {
            using (FbConnection conexaoFireBird = AcessoFireBird.GetInstancia().GetConexao())
            {
                conexaoFireBird.Open();
                string mSQL = "Select * from Alunos";
                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);
                FbDataAdapter da = new FbDataAdapter(comando);
                DataTable tabelaDeDados = new DataTable();
                return tabelaDeDados;
                conexaoFireBird.Close();

            }
        }

        public static void InserirDados(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = AcessoFireBird.GetInstancia().GetConexao())
            {
                conexaoFireBird.Open();
                string mSQL = "INSERT into Clientes Values(" + aluno.Matricula + ",'" 
                    + aluno.Nome + "','" 
                    + aluno.Sexo + "','" 
                    + aluno.Nascimento + "','" 
                    + aluno.CPF + "')";
                FbCommand comando = new FbCommand(mSQL, conexaoFireBird);
                comando.ExecuteNonQuery();
                conexaoFireBird.Close();
                
            }
        }


    }
}
