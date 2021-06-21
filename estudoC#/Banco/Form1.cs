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
        /* GENERICS
         * Genéricos permitem escrever uma classe ou método que aceita qualquer tipo como parâmetro.
         * A plataforma .NET possui diversas classes e métodos genéricos padrão nas coleções e nos métodos que operam nelas
         * como a List<T> e o Dictionary<Tkey, TValue> utilizados logo abaixo.
         * O tipo aceito pode ser definido na instanciação da classe/método, como nos exemplos aqui, ou deixados em aberto através de um tipo genérico, como será visto
         * mais a seguir.
         */

        public List<Conta> contas;//Esta lista foi definida para receber objetos do tipo Conta

        public Dictionary<Int32, Conta> dicionarioDeContas = new Dictionary<Int32, Conta>();//Este dicionário teve seus parâmetros de tipo definidos como Int32 para a chave e Conta para o objeto armazenado.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();

            /*UPCAST
             *O upcast é a conversão de um objeto de um tipo mais específico para um tipo mais abrengente, por exemplo de subclasse para superclasse.
             *Como o tipo mais específico faz parte e já possui as características da classe mais geral, a conversão pode ser implícita:
             */
            ContaCorrente cc = new ContaCorrente();
            Conta c1 = cc;
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
            /*Boxing
            * Conversão de um tipo primário (Value Type) em um tipo de referência.
            * ocorreria se por exemplo houvesse uma variável valorSaldo do tipo objeto:
            */
            object valorSaldo = c5.saldo; //tipo primário (double - c2.saldo) em tipo referência (object - valorSaldo)
            //Já o UNBOXING é a conversão do tipo referência para o tipo primário, que deve ser feito de forma explícita:
            double d = (double)valorSaldo;
            double a = Conta.numeroDeContas;//Conversão de tipos numéricos - implícita, sem perda de dados
            int b = (int)d;//Conversão de tipos numéricos - explícita, possível perda de dados quando não compatíveis
            MessageBox.Show("Programa iniciado. \n Resultado do unboxing: " + d);

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
            comboContas.Items.Add("Titular: " + conta.titular.nome);
            contaDestino.Items.Add("Titular: " + conta.titular.nome);
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


        private void realizaTransferencia_Click(object sender, EventArgs e)
        {
            if (valorTransferencia.Text == "" || comboContas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione as contas de destino e origem e o valor a transferir");
            }
            else
            { 
                double valor = Convert.ToDouble(valorTransferencia.Text);
                int indiceOrigem = comboContas.SelectedIndex;
                Conta selecionada = this.contas[indiceOrigem];
                int indiceDestino = contaDestino.SelectedIndex;
                Conta destino = this.contas[indiceDestino];
                this.contas[indiceOrigem].Transfere(valor, this.contas[indiceDestino]);
                mostraDados(selecionada);
                MessageBox.Show("Transferência de {1} realizada", valor.ToString("c"));
            }
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
                /*DOWNCAST
                * É a atribuição de uma classe mais específica a partir de um objeto de uma classe superior, mais geral, ou seja
                * a conversão de um objeto de tipo de superclasse para tipo subclasse.
                * No exemplo a seguir é feito o downcast de um objeto do tipo Conta, superclasse, para um objeto do tipo ContaCorrente, subclasse.
                * O downcast deve ser feito de forma explícita.
                */
                if (selecionada is ContaCorrente)//Na conversão de tipos o operador "is", um operador booleano, atesta se a conversão é possível retornando true ou false
                {
                    ContaCorrente corrente = (ContaCorrente)selecionada;//DOWNCASTING - selecionada convertida de Conta para ContaCorrente
                    double imposto = corrente.calculaTributos();
                    MessageBox.Show("Valor do imposto: " + imposto.ToString("c"));
                    MessageBox.Show("Saldo:  " + corrente.saldo.ToString("c"));
                    textoSaldo.Text = corrente.saldo.ToString("c");
                 }
                else if (selecionada is ContaDeInvestimentos)
                {
                    ContaDeInvestimentos corrente = (ContaDeInvestimentos)selecionada;//DOWNCASTING - selecionada convertida de Conta para ContaDeInvestimentos
                    double imposto = corrente.calculaTributos();
                    //Outra forma de conversão de tipos é o uso de métodos padrão fornecidos pela plataforma .NET como o .ToString()...
                    MessageBox.Show("Valor do imposto: R$" + imposto.ToString());
                    MessageBox.Show("Saldo: R$" + Convert.ToString(corrente.saldo));// que também pode ser invocado encapsulando a variável ou o objeto a ser convertido pela classe Convert...
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
            Conta busca = dicionarioDeContas[Convert.ToInt32(valorBuscaConta.Text)];// e o Convert.ToInt32(), dentre vários outros tipos suportados pela Classe Convert e seus métodos;
            mostraDados(busca);
            
        }


        private void mostraDados(Conta conta)
        {
            textoNumero.Text = Convert.ToString(conta.numero);
            textoTitular.Text = conta.titular.nome;
            textoSaldo.Text = Convert.ToString(conta.saldo);
        }


        private void btnGeraRelatorios_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(contas);
            form.ShowDialog();
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
        private void contaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
