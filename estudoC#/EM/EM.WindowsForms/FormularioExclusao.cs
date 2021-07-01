using EM.WidowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM.WindowsForms
{
    public partial class confirmaExclusao : Form
    {
        private Form1 formPrincipal;
        public confirmaExclusao(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void botaoConfirmaExclusao_Click(object sender, EventArgs e)
        {

        }

        private void botaoCancelaExclusao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
