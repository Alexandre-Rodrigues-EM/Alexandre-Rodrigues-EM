using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    interface ITributavel
    {
        double calculaTributos(double Saldo);
    }

    public interface IRentavel
    {
        double calculaRendimento(double Saldo);
    }



}
