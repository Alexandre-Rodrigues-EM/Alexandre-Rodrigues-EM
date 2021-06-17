using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        public string tipoDeConta;
        public int numero;
        public static int numeroDeContas;
        public static string[] tiposDeConta = new string[] { "Conta Poupança", "Conta Corrente", "Conta de Investimentos" };
        public Cliente titular;
        public double saldo;
    //    public tipoConta id;


        public virtual void Saca(double valor)
        {
            if (saldo >= valor)
            {
                this.saldo -= valor;
            }
            else if (saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            else if (valor<0)
            {
                throw new ValorNegativoException();
            }
            else
            {
                throw new ArgumentException();
            }

        }

        public virtual void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public virtual void Transfere(double valor, Conta destino)
        {
            if(saldo >= valor)
            {
                this.saldo -= valor;
                destino.saldo += valor;
            }
            else if (saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            else if (valor < 0)
            {
                throw new ValorNegativoException();
            }
            else
            {
                throw new ArgumentException();
            }
            this.saldo -= valor;
            destino.saldo += valor;
        }
    }

    public class ContaCorrente : Conta, ITributavel
    {
        public new string tipoDeConta = "Conta Corrente";
        public double calculaTributos()
        {
            double imposto;
            imposto = this.saldo*0.02;
            this.saldo -= imposto;
            return imposto;
        }
    //    public const int id = 1;
   //     public const string nomeTipo = "Conta Corrente";
    }

    public class ContaPoupanca : Conta, IRentavel
    {
        public new string tipoDeConta = "Conta Poupança";
        public override void Saca(double valor)
        {
            valor += 0.1;
            if (saldo >= (valor))
            {
                this.saldo -= (valor);
            }
            else if (saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            else if (valor < 0)
            {
                throw new ValorNegativoException();
            }
            else
            {
                throw new ArgumentException();
            }
        }
        double IRentavel.calculaRendimento()
        {
            return this.saldo *= 0.03;
        }
    //    public const int id = 2;
    //    public const string nomeTipo = "Conta Poupanca";
    }

    public class ContaDeInvestimentos : Conta, ITributavel, IRentavel
    {
        public new string tipoDeConta = "Conta de Investimentos";
        public double calculaTributos()
        {
            double imposto;
            imposto = this.saldo * 0.02;
            this.saldo -= imposto;
            return imposto;
        }
        public double calculaRendimento()
        {
            return this.saldo * 0.09;
        }
     //   public const tipoConta id = 3;
      //  public const string nomeTipo = "Conta de Investimentos";
    }

    public class SaldoInsuficienteException : Exception
    {

    }

    public class ValorNegativoException : Exception
    {

    }

    /*  public class tipoConta
      {
          public int id;
          public string nomeTipo;

          public void atribuiTipoConta(int id)
          {
              if (id==1)
              {
                  Conta conta = new ContaCorrente();
              }
              else if (id == 2)
              {
                  Conta conta = new ContaPoupanca();
              }
          }
          public void consultaTipoConta(Conta conta)
          {
              if
          }
      }*/
}
