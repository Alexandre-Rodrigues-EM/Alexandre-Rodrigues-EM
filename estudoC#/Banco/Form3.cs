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
        List<Conta> contasFiltradas = new List<Conta>();

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
            contasFiltradas.Clear();
            var tipoSelecionado = selecionaTipoDeConta.SelectedItem;
            if (tipoSelecionado != null)
            {
                
                geraListaFiltrada(contasFiltradas, tipoSelecionado.ToString(),-1,-1);
                mostraDados(contasFiltradas);

            }
        }

        private void realizaFiltro_Click(object sender, EventArgs e)
        {
            contasFiltradas.Clear();
            var tipoSelecionado = selecionaTipoDeConta.SelectedItem;
            var tipoDeFiltro = selecionaFiltroDeValor.Text;
            var valorDoFiltro = Convert.ToDouble(valorDeFiltro.Text);
            geraListaFiltrada(contasFiltradas, tipoSelecionado.ToString(), tipoDeFiltro, valorDoFiltro);
            if (contasFiltradas.Count == 0)
            {
                MessageBox.Show("Não há contas com as características selecionadas.");
            }
            else
            {
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
            mostraPorcentagemFiltro.Text = (Convert.ToDouble(contasSelecionadas.Count()) / Convert.ToDouble(contas.Count())).ToString("p");


            var GeraRelatorio = from c in contasSelecionadas
                                select c;

            foreach (var c in GeraRelatorio)
            {
                telaRelatorio.Items.Add(c.titular.nome);
            }
            filtraMenor(contasSelecionadas);
            filtraMaior(contasSelecionadas);

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

        private void filtraMaior(List<Conta> lista)
        {
            var valorMaiorSaldo = lista.Max(c => c.saldo);
            var encontraTitularMaiorSaldo = (from c in lista
                                             where c.saldo == valorMaiorSaldo
                                             select c.titular.nome).Single();

            mostraTitularMaiorSaldo.Text = encontraTitularMaiorSaldo;
            mostraMaiorSaldo.Text = valorMaiorSaldo.ToString("c");

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

        private void geraListaFiltrada<T1, T2, T3>(List<Conta> Filtrada, T1 _T1, T2 _T2, T3 _T3)
        {

            if (_T2 is -1 && _T3 is -1)
            {
                if (_T1 is "Conta Corrente" || _T1 is ContaCorrente)
                {

                    filtraContasTipo(contas, Filtrada, _T1 as ContaCorrente);
                }
                else if (_T1 as string == "Conta Poupança" || _T1 is ContaPoupanca)
                {
                    filtraContasTipo(contas, Filtrada, _T1 as ContaPoupanca);

                }
                else if (_T1 is "Conta de Investimentos" || _T1 is ContaDeInvestimentos)
                {
                    filtraContasTipo(contas, Filtrada, _T1 as ContaDeInvestimentos);
                }

            }
            else if (_T3 is -1)
            {
                if (_T1 is string && _T2 is double)
                {
                    //List<Conta> ListaMeio = new List<Conta>;
                    var valor = Convert.ToDouble(_T2);
                    filtraContasValor(contas, Filtrada, _T1 as string, valor);
                }

            }
            else 
            {
                var valor = Convert.ToDouble(_T3);

                if (_T1 is "Conta Corrente" || _T1 is ContaCorrente)
                {
                    List<Conta> listaMeio = new List<Conta>();
                    filtraContasTipo(contas, listaMeio, _T1 as ContaCorrente);
                    filtraContasValor(listaMeio, Filtrada, _T2 as string, valor);
                }
                else if (_T1 as string == "Conta Poupança" || _T1 is ContaPoupanca)
                {
                    List<Conta> listaMeio = new List<Conta>();
                    filtraContasTipo(contas, listaMeio, _T1 as ContaPoupanca);
                    filtraContasValor(listaMeio, Filtrada, _T2 as string, valor);


                }
                else if (_T1 is "Conta de Investimentos" || _T1 is ContaDeInvestimentos)
                {
                    List<Conta> listaMeio = new List<Conta>();
                    filtraContasTipo(contas, listaMeio, _T1 as ContaDeInvestimentos);
                    filtraContasValor(listaMeio, Filtrada, _T2 as string, valor);

                }
            }

            

        }
        static void filtraContasTipo<T>(List<Conta> listaOrigem, List<Conta> listaDestino, T tFiltro)
        {
            var filtro = from c in listaOrigem
                         where c is T
                         select c;
            foreach (var c in filtro)
                listaDestino.Add(c);
        }
        static void filtraContasValor(List<Conta> listaOrigem, List<Conta> listaDestino, string tFiltro, double tValor)
        {
            if (tFiltro is "Acima de")
            {
                var filtro = from c in listaOrigem
                             where c.saldo >= tValor
                             select c;
                foreach (var c in filtro)
                    listaDestino.Add(c);
            }
            else if (tFiltro is "Abaixo de")
            {
                var filtro = from c in listaOrigem
                             where c.saldo <= tValor
                             select c;
                foreach (var c in filtro)
                    listaDestino.Add(c);
            }
        }

        private void valorDeFiltro_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
 