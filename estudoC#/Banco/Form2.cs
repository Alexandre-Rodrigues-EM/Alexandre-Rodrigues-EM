using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form2 : Form
    {
        private Form1 formPrincipal;

        public Form2(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            selecionaTipoConta.Items.Add("Conta Corrente");
            selecionaTipoConta.Items.Add("Conta Poupanca");
            selecionaTipoConta.Items.Add("Conta de Investimentos");

        }

        private void criaNovaConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (selecionaTipoConta.Text == "Conta Corrente")
                {
                    Conta novaConta = new ContaCorrente()
                    {
                        numero = Conta.numeroDeContas + 1,
                        saldo = Convert.ToDouble(textoCriaSaldo.Text),
                        titular = new Cliente(textoCriaTitular.Text)
                    };
                    this.formPrincipal.AdicionaConta(novaConta);
                    geraCadastro(novaConta);
                    Conta.numeroDeContas++;

                }
                else
                if (selecionaTipoConta.Text == "Conta Poupanca")
                {
                    Conta novaConta = new ContaPoupanca()
                    {
                        numero = Conta.numeroDeContas + 1,
                        saldo = Convert.ToDouble(textoCriaSaldo.Text),
                        titular = new Cliente(textoCriaTitular.Text)
                    };
                    this.formPrincipal.AdicionaConta(novaConta);
                    geraCadastro(novaConta);
                    Conta.numeroDeContas++;

                }
                else
                if (selecionaTipoConta.Text == "Conta de Investimentos")
                {
                    Conta novaConta = new ContaDeInvestimentos()
                    {
                        numero = Conta.numeroDeContas + 1,
                        saldo = Convert.ToDouble(textoCriaSaldo.Text),
                        titular = new Cliente(textoCriaTitular.Text)
                    };

                    this.formPrincipal.AdicionaConta(novaConta);
                    geraCadastro(novaConta);
                    Conta.numeroDeContas++;
                }

                MessageBox.Show("Conta criada com sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Conta não criada pelo seguinte erro:\n {ex}");
            }
        }

        private void selecionaTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textoCriaNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void geraCadastro(Conta conta)
        {
            var cadastraConta = new Conta
            {
                numero = conta.numero,
                titular = conta.titular,
                saldo = conta.saldo
            };              
            string saida = "contas.json";
            string jsonString = JsonSerializer.Serialize(cadastraConta,new JsonSerializerOptions { WriteIndented = true } );
            File.WriteAllText(saida, jsonString);
            Console.Write(jsonString);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textoCriaTitular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

           
  