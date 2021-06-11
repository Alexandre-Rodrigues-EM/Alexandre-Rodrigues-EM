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
            
        }
        
        private void btnGeraRelatorioGeral_Click(object sender, EventArgs e)
        {
            var GeraRelatorioGeral = from c in contas
                                     select c;

            foreach (var c in GeraRelatorioGeral) 
            {
                telaRelatorio.Items.Add(c.titular.nome);
            }

                
        }
    }
}
 