using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form3 : Form
    {
        List<Conta> contas = new List<Conta>();

        public Form3(List<Conta> contas)
        {
            this.contas = contas;
            InitializeComponent();
            selecionaTipoDeConta.Items.AddRange(Conta.tiposDeConta);
            selecionaFiltroDeValor.Items.Add("Acima de");
            selecionaFiltroDeValor.Items.Add("Abaixo de");
            mostraDados();
            filtraMenor(contas);

        }

        private void btnGeraRelatorioGeral_Click(object sender, EventArgs e)
        {
            telaRelatorio.Items.Clear();
            selecionaFiltroDeValor.SelectedItem = null;
            selecionaTipoDeConta.SelectedItem = null;
            valorDeFiltro.Clear();
            var GeraRelatorioGeral = from c in contas
                                     select c;

            foreach (var c in GeraRelatorioGeral) 
            {
                telaRelatorio.Items.Add(c.titular.nome);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = selecionaTipoDeConta.SelectedItem.ToString();
            if 
        }

        private void mostraDados()
        {
            var calculaSaldo = contas.Sum(c => c.saldo);
            mostraSomaSaldos.Text = Convert.ToString(calculaSaldo);
            var calculaMedia = contas.Average(c => c.saldo);
            mostraMediaSaldos.Text = Convert.ToString(calculaMedia);
            mostraNumDeContas.Text = Convert.ToString(Conta.numeroDeContas);
        }

        private void filtraMenor(List<Conta> lista)
        {
            var valorMenorSaldo = lista.Min(c => c.saldo);
            var encontraTitularMenorSaldo = (from c in lista
                                            where c.saldo == valorMenorSaldo
                                            select c.titular.nome).Single();
            
            mostraTitularMenorSaldo.Text = encontraTitularMenorSaldo;
            mostraMenorSaldo.Text = valorMenorSaldo.ToString();

        }
    }
}
 