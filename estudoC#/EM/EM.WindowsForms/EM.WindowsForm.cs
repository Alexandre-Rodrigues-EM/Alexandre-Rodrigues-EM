using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EM.Domain;
using EM.Repository;

namespace EM.WidowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Type tipo = typeof(EnumeradorSexo.Sexo);
            string[] sexos = tipo.GetEnumNames();
            foreach (var sexo in sexos)
                Console.WriteLine(sexo);
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
            //  if seleciona;
            Aluno aluno = new Aluno()
            {
                CPF = insereCPF.Text,
                Nascimento = Convert.ToDateTime(insereDataDeNascimento.Text),
                Nome = insereNome.Text,
                Matricula = Convert.ToInt32(insereNumeroMatricula.Text),
               // Sexo = Equals(selecionaSexo.Text,EnumeradorSexo.Sexo
            };

            new RepositorioAluno().Add(aluno);

        }

        private void fbConnection1_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {
            
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
