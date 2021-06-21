using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form3 : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Conta> contasFiltradas = new List<Conta>();
        int numeroDoRelatorio = 0;

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
            double valorDoFiltro;
            if (Double.TryParse(valorDeFiltro.Text, out valorDoFiltro))
            {
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
            else
            {
                MessageBox.Show("Selecione os parâmetros para busca");
            }
            
        }
        private void mostraDados(List<Conta> contasSelecionadas)
        {
            telaRelatorio.Items.Clear();

        /*LINQ
        * LINQ é a linguagem simplificada de consultas imbuída na linguagem C# e na plataforma .NET, com estrutura semelhante a SQL.
        * Nos blocos de código a seguir são realizadas operações com métodos de LINQ: soma (.Sum()), média (.Average()) e contagem (.Count()), pela fluent syntax.
        */
            var calculaSaldo = contasSelecionadas.Sum(c => c.saldo);//Realiza uma consulta a contasSelecionadas e retorna o saldo de cada objeto na lista, em seguida soma todos os saldos
            mostraSomaSaldos.Text = calculaSaldo.ToString("c");

            var calculaMedia = contasSelecionadas.Average(c => c.saldo);//Realiza uma consulta a contasSelecionadas e retorna o saldo de cada objeto na lista, em seguida faz a média de todos os saldos
            mostraMediaSaldos.Text = calculaMedia.ToString("c");

            mostraNumDeContas.Text = contasSelecionadas.Count().ToString();//Realiza uma consulta a contasSelecionadas e retorna a quantidade de objetos na lista.
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
            var valorMenorSaldo = lista.Min(c => c.saldo);//Realiza uma consulta a contasSelecionadas e retorna o menor saldo da lista
            var encontraTitularMenorSaldo = (from c in lista
                                                where c.saldo == valorMenorSaldo
                                                select c.titular.nome).Single();

            mostraTitularMenorSaldo.Text = encontraTitularMenorSaldo;
            mostraMenorSaldo.Text = valorMenorSaldo.ToString("c");

        }

        private void filtraMaior(List<Conta> lista)
        {
            var valorMaiorSaldo = lista.Max(c => c.saldo);//Realiza uma consulta a contasSelecionadas e retorna o maior saldo da lista
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

        // Abaixo temos um método genérico capaz de receber até três tipos diferentes simultaneamente em seus parâmetros
        private void geraListaFiltrada<T1, T2, T3>(List<Conta> Filtrada, T1 _T1, T2 _T2, T3 _T3)
        {

            if (_T2 is -1 && _T3 is -1)
            {
                if (_T1 is "Conta Corrente" || _T1 is ContaCorrente)//Conversão de tipos - Uso do operador booleano "is"
                {

                    filtraContasTipo(contas, Filtrada, _T1 as ContaCorrente);//Na convesão de tipos, enquanto o operador is verifica se é possível a conversão, o operador "as" realiza a conversão
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

        /*LINQ - Continuação
        * Nos blocos de código a seguir são realizadas consultas simples aos objetos das listas, vez que LINQ é voltado para a consulta em coleções,
        * mas são possíveis várias  operações através de operadores como join, group, orderby.
        */
        static void filtraContasTipo<T>(List<Conta> listaOrigem, List<Conta> listaDestino, T tFiltro)
        {
            var filtro = from c in listaOrigem
                         where c is T
                         orderby c.saldo descending
                         select c;
            foreach (var c in filtro)
                listaDestino.Add(c);
        }
        static void filtraContasValor(List<Conta> listaOrigem, List<Conta> listaDestino, string tFiltro, double tValor)
        {
            if (tFiltro is "Acima de")
            {
                var filtro = from c in listaOrigem //Querry expression style
                             where c.saldo >= tValor
                             select c;
                foreach (var c in filtro)
                    listaDestino.Add(c);
            }
            else if (tFiltro is "Abaixo de")
            {
                var filtro = listaOrigem.Where(c => c.saldo <= tValor) //Fluent expression style
                    .OrderBy(c => c.numero)
                    .Select (c => c);
                foreach (var c in filtro)
                    listaDestino.Add(c);
            }
        }

        private void valorDeFiltro_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnImprimeRelatorio_Click(object sender, EventArgs e)
        {

            string relatorio = $"relatoriodecontas-{numeroDoRelatorio}.txt";
            Stream saida = new FileStream (relatorio, FileMode.OpenOrCreate);
            StreamWriter escritor = new StreamWriter(saida);
            if (selecionaTipoDeConta.SelectedIndex == -1)
            {
                foreach (var c in contas)
                {
                    escritor.WriteLine(c.numero);
                    escritor.WriteLine(c.titular.nome);
                    escritor.WriteLine(c.saldo);
                    escritor.WriteLine(c.GetType());
                }
                numeroDoRelatorio++;
            }
            else
            {
                foreach (var c in contasFiltradas)
                {
                    escritor.WriteLine(c.numero);
                    escritor.WriteLine(c.titular.nome);
                    escritor.WriteLine(c.saldo);
                    escritor.WriteLine(c.GetType());
                }
                numeroDoRelatorio++;

            }
            escritor.Close();
            saida.Close();
            MessageBox.Show("Relatório gerado na pasta raíz");


        }
    }
        
    
}
 