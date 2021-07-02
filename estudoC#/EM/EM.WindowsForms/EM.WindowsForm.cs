using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EM.Domain;
using EM.Repository;
using EM.WindowsForms;

namespace EM.WidowsForms
{
    public partial class Form1 : Form
    {
        protected bool Editando = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            if (Editando == true)
            {
                Editando = false;
                MudaTextoNovoAluno();
                LimpaCampos();
            }
            else
            {
                LimpaCampos();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Type tipo = typeof(EnumeradorSexo.Sexo);
            string[] sexos = tipo.GetEnumNames();
            foreach (var sexo in sexos)
                selecionaSexo.Items.Add(sexo);

            preencheGrid();

        }

        private void insereCPF_MouseClick(object sender, MouseEventArgs e)
        {
            insereCPF.SelectionStart = 0;
        }

        private void insereDataDeNascimento_MouseClick(object sender, MouseEventArgs e)
        {
            insereDataDeNascimento.SelectionStart = 0;
        }

        private void insereNumeroMatricula_MouseClick(object sender, MouseEventArgs e)
        {
            insereNumeroMatricula.SelectionStart = 0;
        }

        private void insereNumeroMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar));
        }

        private void insereCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void insereNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            if (Editando == false)
            {
                Aluno aluno = new Aluno()
                {
                    CPF = insereCPF.Text,
                    Nascimento = Convert.ToDateTime(insereDataDeNascimento.Text),
                    Nome = insereNome.Text,
                    Matricula = Convert.ToInt32(insereNumeroMatricula.Text),
                    Sexo = new EnumeradorSexo(selecionaSexo.SelectedIndex, selecionaSexo.SelectedItem.ToString())
                };
                new RepositorioAluno().Add(aluno);
                MessageBox.Show("Aluno cadastrado com sucesso!");
                LimpaCampos();

            }
            else
            {
                MessageBox.Show("Aluno alterado com sucesso!");
                LimpaCampos();
            }
        }

        private void preencheGrid()
        {
            DataSet conjuntoDadosAlunos = new DataSet();
            AcessoFireBird.GetDados(conjuntoDadosAlunos);
            bindingSource1.DataSource = conjuntoDadosAlunos.ToBindingList();
            dataGrid.DataSource = bindingSource1;
        }

        private void fbConnection1_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {
            
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            if (Editando == true)
            {
                Editando = false;
                MudaTextoNovoAluno();

            }
            else
            {
                Editando = true;
                MudaTextoEditandoAluno();
                botaoEditar.Hide();
            }

        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            formConfirmaExclusao formularioExclusao = new formConfirmaExclusao(this);
            formularioExclusao.ShowDialog();
        }

        private void MudaTextoEditandoAluno()
        {
            botaoAdicionar.Text = "Modificar";
            botaoLimpar.Text = "Cancelar";
            groupBox1.Text = "Editando aluno";
        }

        private void MudaTextoNovoAluno()
        {
            botaoAdicionar.Text = "Adicionar";
            botaoLimpar.Text = "Limpar";
            groupBox1.Text = "Novo aluno";
            botaoEditar.Show();
        }

        private void LimpaCampos()
        {
            insereCPF.Clear();
            insereDataDeNascimento.Clear();
            insereNome.Clear();
            insereNumeroMatricula.Clear();
            selecionaSexo.SelectedIndex = -1;
        }
    }
}
