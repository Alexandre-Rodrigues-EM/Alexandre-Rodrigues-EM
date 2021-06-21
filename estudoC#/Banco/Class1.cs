using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public virtual void Saca(double valor)
        {
            if (saldo >= valor && valor > 0)
            {
                this.saldo -= valor;
            }
            else if (saldo < valor && valor > 0)
            {
                MessageBox.Show("Saldo insuficiente para a operação solicitada");
            }
            else
            {
                MessageBox.Show("Insira um valor numérico positivo");
            }

        }

        public virtual void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public virtual void Transfere(double valor, Conta destino)
        {
            if(saldo >= valor && valor > 0)
            {
                this.saldo -= valor;
                destino.saldo += valor;
            }
            else if (saldo < valor && valor > 0)
            {
                MessageBox.Show("Saldo insuficiente para a operação solicitada");
            }
            else
            {
                MessageBox.Show("Insira um valor numérico positivo");
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
    }

    public class ContaPoupanca : Conta, IRentavel
    {
        public new string tipoDeConta = "Conta Poupança";
        public override void Saca(double valor)
        {
            valor += 0.1;
            if (saldo >= valor && valor > 0)
            {
                this.saldo -= valor;
            }
            else if (saldo < valor && valor > 0)
            {
                MessageBox.Show("Saldo insuficiente para a operação solicitada");
            }
            else
            {
                MessageBox.Show("Insira um valor numérico positivo");
            }
        }
        double IRentavel.calculaRendimento()
        {
            return this.saldo *= 0.03;
        }
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
    }

}
