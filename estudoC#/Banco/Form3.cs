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
            mostraDados(contas);

        }

        private void btnGeraRelatorioGeral_Click(object sender, EventArgs e)
        {
            relatorioGeralPadrao();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoSelecionado = selecionaTipoDeConta.SelectedItem;
            if (tipoSelecionado != null)
            { 
                List<Conta> contasFiltradas = new List<Conta>();
                geraListaFiltrada(contasFiltradas, tipoSelecionado.ToString());
                mostraDados(contasFiltradas);

            }
        }

        private void mostraDados(List<Conta> contasSelecionadas)
        {
            telaRelatorio.Items.Clear();
            
            var calculaSaldo = contasSelecionadas.Sum(c => c.saldo);
            mostraSomaSaldos.Text = calculaSaldo.ToString("c");
            
            var calculaMedia = contasSelecionadas.Average(c => c.saldo);
            mostraMediaSaldos.Text = calculaMedia.ToString("c");
            
            mostraNumDeContas.Text = contasSelecionadas.Count().ToString();

            
            
            var GeraRelatorio = from c in contasSelecionadas
                                select c;

            foreach (var c in GeraRelatorio)
            {
                telaRelatorio.Items.Add(c.titular.nome);
            }
            filtraMenor(contasSelecionadas);

        }

        private void filtraMenor(List<Conta> lista)
        {
            var valorMenorSaldo = lista.Min(c => c.saldo);
            var encontraTitularMenorSaldo = (from c in lista
                                             where c.saldo == valorMenorSaldo
                                             select c.titular.nome).Single();

            mostraTitularMenorSaldo.Text = encontraTitularMenorSaldo;
            mostraMenorSaldo.Text = valorMenorSaldo.ToString("c");

        }

        private void relatorioGeralPadrao()
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

        private void geraListaFiltrada<T1/*, T2, T3*/>(List<Conta> Filtrada, T1 _T1/*, T2 _T2, T3 _T3*/)
        {

            //if (_T1 is not null && _T2 is null && _T3 is null)
            //{
                if (_T1 is "Conta Corrente" || _T1 is ContaCorrente)
                {
                    filtraContas(contas, Filtrada, _T1 as ContaCorrente);
                }
                else if (_T1 as string == "Conta Poupança" || _T1 is ContaPoupanca)
                {
                    filtraContas(contas, Filtrada, _T1 as ContaPoupanca);

                }
                else if (_T1 is "Conta de Investimentos" || _T1 is ContaDeInvestimentos)
                {
                    filtraContas(contas, Filtrada, _T1 as ContaDeInvestimentos);
                }

            /*}
            else if (_T1 is not null && _T2 is not null && _T3 is not null)
            {

            }*/
            else
            {
                throw new ArgumentException("e");
            }
            static void filtraContas<T>(List<Conta> listaOrigem, List<Conta> listaDestino, T tFiltro) 
            {
                var filtro = from c in listaOrigem
                             where c is T
                             select c;
                foreach (var c in filtro) 
                    listaDestino.Add(c);
            }
            

        }


    }
}

 