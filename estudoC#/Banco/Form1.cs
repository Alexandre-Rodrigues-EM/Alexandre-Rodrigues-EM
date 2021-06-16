using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public List<Conta> contas;
        
        public Dictionary<Int32, Conta> dicionarioDeContas = new Dictionary<Int32, Conta>();

        public Form1()
        {
            InitializeComponent();
            
            /*/	vamos	inicializar	algumas	instâncias	de	Conta.
            Conta c1 = new Conta();
            c1.titular = new Cliente("victor");
            c1.numero = 1;
            this.AdicionaConta(c1);
            Conta c2 = new ContaPoupanca();
            c2.titular = new Cliente("mauricio");
            c2.numero = 2;
            this.AdicionaConta(c2);
            Conta c3 = new ContaCorrente();
            c3.titular = new Cliente("osni");
            c3.numero = 3;
            this.AdicionaConta(c3);
            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();
            Conta c1 = new ContaCorrente();
            c1.saldo = 500;
            c1.numero = ++Conta.numeroDeContas;
            c1.titular = new Cliente("José Alvaro");
            this.AdicionaConta(c1);
            Conta c2 = new ContaCorrente();
            c2.saldo = 1200;
            c2.numero = ++Conta.numeroDeContas;
            c2.titular = new Cliente("Pietro Félix");
            this.AdicionaConta(c2);
            Conta c3 = new ContaPoupanca();
            c3.saldo = 2300;
            c3.numero = ++Conta.numeroDeContas;
            c3.titular = new Cliente("Igor Navarro");
            this.AdicionaConta(c3);
            Conta c4 = new ContaDeInvestimentos();
            c4.saldo = 600;
            c4.numero = ++Conta.numeroDeContas;
            c4.titular = new Cliente("Washington Veiga");
            this.AdicionaConta(c4);
            Conta c5 = new ContaDeInvestimentos();
            c5.saldo = 3500;
            c5.numero = ++Conta.numeroDeContas;
            c5.titular = new Cliente("Alfonso Costa");
            this.AdicionaConta(c5);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valorSaque = Convert.ToDouble(textoValor.Text);
            if (this.contas[indice].saldo >= valorSaque)
            {
                this.contas[indice].Saca(valorSaque);
                textoSaldo.Text = Convert.ToString(selecionada.saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            mostraDados(selecionada);
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
                Form2 formularioDeCadastro = new Form2(this);
                formularioDeCadastro.ShowDialog();
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta);
            comboContas.Items.Add("titular: " + conta.titular.nome);
            contaDestino.Items.Add("titular: " + conta.titular.nome);
            dicionarioDeContas.Add(conta.numero, conta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            this.contas[indice].Deposita(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(selecionada.saldo);
            MessageBox.Show("Deposito realizado às " + DateTime.Now);
        }

        private void contaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void realizaTransferencia_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(valorTransferencia.Text);
            int indiceOrigem = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indiceOrigem];
            int indiceDestino = contaDestino.SelectedIndex;
            Conta destino = this.contas[indiceDestino];
            this.contas[indiceOrigem].Transfere(valor, this.contas[indiceDestino]);
        }

        private void btnCalculaImpostos_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Erro: Selecione uma conta");
            }
            else
            {
                Conta selecionada = this.contas[indice];
                if (selecionada is ITributavel)//ContaCorrente)
                {
                     ContaCorrente corrente = (ContaCorrente)selecionada;
                     double imposto = corrente.calculaTributos();
                     MessageBox.Show("Valor do imposto: R$" + Convert.ToString(imposto));
                     MessageBox.Show("Saldo: R$" + Convert.ToString(corrente.saldo));
                     textoSaldo.Text = Convert.ToString(corrente.saldo);
                 }
                 else if (selecionada is ContaDeInvestimentos)
                 {
                     ContaDeInvestimentos corrente = (ContaDeInvestimentos)selecionada;
                     double imposto = corrente.calculaTributos();
                     MessageBox.Show("Valor do imposto: R$" + Convert.ToString(imposto));
                     MessageBox.Show("Saldo: R$" + Convert.ToString(corrente.saldo));
                     textoSaldo.Text = Convert.ToString(corrente.saldo);
                 }
                else
                {
                    MessageBox.Show("Conta isenta de impostos");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta busca = dicionarioDeContas[Convert.ToInt32(valorBuscaConta.Text)];
            mostraDados(busca);
        }


        private void mostraDados(Conta conta)
        {
            textoNumero.Text = Convert.ToString(conta.numero);
            textoTitular.Text = conta.titular.nome;
            textoSaldo.Text = Convert.ToString(conta.saldo);
        }

/*        private void consultaCadastro()
        {
            string entrada = File.OpenRead("contas.txt");
            StreamReader leitor = new StreamReader(entrada);
 //           leitor  }
*/
       

        private void btnGeraRelatorios_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(contas);
            form.ShowDialog();
        }
    }
}
