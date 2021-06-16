using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentação_C_Sharp
{
    public /*abstract*/ class Patrimonio
    {
        public int id;
        public string nomeProduto;
        public int quantidadeProduto;

        public virtual void entradaEstoque(int quantidadeEntrada)
        {
            this.quantidadeProduto += quantidadeEntrada;
        }

        public void saidaEstoque(int quantidadeSaida)
        {
            this.quantidadeProduto -= quantidadeSaida;
        }

    }

    public class Administracao: Patrimonio
    {

    }

    public class Estoque: Patrimonio
    {

    }

    public class Operacional: Patrimonio
    {

    }


}
