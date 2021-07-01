
namespace EM.WidowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insereCPF = new System.Windows.Forms.TextBox();
            this.insereNumeroMatricula = new System.Windows.Forms.TextBox();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.insereDataDeNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selecionaSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insereNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barraDePesquisa = new System.Windows.Forms.TextBox();
            this.botaoPesquisar = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insereCPF);
            this.groupBox1.Controls.Add(this.insereNumeroMatricula);
            this.groupBox1.Controls.Add(this.botaoAdicionar);
            this.groupBox1.Controls.Add(this.botaoLimpar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.insereDataDeNascimento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.selecionaSexo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.insereNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(603, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo aluno";
            // 
            // insereCPF
            // 
            this.insereCPF.Location = new System.Drawing.Point(272, 106);
            this.insereCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insereCPF.MaxLength = 11;
            this.insereCPF.Name = "insereCPF";
            this.insereCPF.Size = new System.Drawing.Size(131, 23);
            this.insereCPF.TabIndex = 5;
            this.insereCPF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.insereCPF_MouseClick);
            this.insereCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insereCPF_KeyPress);
            // 
            // insereNumeroMatricula
            // 
            this.insereNumeroMatricula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.insereNumeroMatricula.Location = new System.Drawing.Point(14, 55);
            this.insereNumeroMatricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insereNumeroMatricula.MaxLength = 9;
            this.insereNumeroMatricula.Name = "insereNumeroMatricula";
            this.insereNumeroMatricula.Size = new System.Drawing.Size(116, 23);
            this.insereNumeroMatricula.TabIndex = 1;
            this.insereNumeroMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.insereNumeroMatricula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.insereNumeroMatricula_MouseClick);
            this.insereNumeroMatricula.TextChanged += new System.EventHandler(this.insereNumeroMatricula_TextChanged);
            this.insereNumeroMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insereNumeroMatricula_KeyPress);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(506, 103);
            this.botaoAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(88, 27);
            this.botaoAdicionar.TabIndex = 7;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(412, 104);
            this.botaoLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(88, 27);
            this.botaoLimpar.TabIndex = 6;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "CPF";
            // 
            // insereDataDeNascimento
            // 
            this.insereDataDeNascimento.Location = new System.Drawing.Point(148, 106);
            this.insereDataDeNascimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insereDataDeNascimento.Mask = "00/00/0000";
            this.insereDataDeNascimento.Name = "insereDataDeNascimento";
            this.insereDataDeNascimento.Size = new System.Drawing.Size(116, 23);
            this.insereDataDeNascimento.TabIndex = 4;
            this.insereDataDeNascimento.ValidatingType = typeof(System.DateTime);
            this.insereDataDeNascimento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.insereDataDeNascimento_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nascimento";
            // 
            // selecionaSexo
            // 
            this.selecionaSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecionaSexo.FormattingEnabled = true;
            this.selecionaSexo.Location = new System.Drawing.Point(14, 106);
            this.selecionaSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selecionaSexo.Name = "selecionaSexo";
            this.selecionaSexo.Size = new System.Drawing.Size(126, 23);
            this.selecionaSexo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sexo";
            // 
            // insereNome
            // 
            this.insereNome.Location = new System.Drawing.Point(191, 55);
            this.insereNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insereNome.Name = "insereNome";
            this.insereNome.Size = new System.Drawing.Size(403, 23);
            this.insereNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Matrícula";
            // 
            // barraDePesquisa
            // 
            this.barraDePesquisa.Location = new System.Drawing.Point(16, 168);
            this.barraDePesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barraDePesquisa.Name = "barraDePesquisa";
            this.barraDePesquisa.Size = new System.Drawing.Size(497, 23);
            this.barraDePesquisa.TabIndex = 8;
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Location = new System.Drawing.Point(532, 167);
            this.botaoPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(88, 27);
            this.botaoPesquisar.TabIndex = 9;
            this.botaoPesquisar.Text = "Pesquisar";
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(15, 200);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(604, 173);
            this.dataGrid.TabIndex = 10;
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(532, 380);
            this.botaoExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(88, 27);
            this.botaoExcluir.TabIndex = 12;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(438, 380);
            this.botaoEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(88, 27);
            this.botaoEditar.TabIndex = 11;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 420);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.barraDePesquisa);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox insereDataDeNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selecionaSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox insereNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barraDePesquisa;
        private System.Windows.Forms.Button botaoPesquisar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.TextBox insereNumeroMatricula;
        private System.Windows.Forms.TextBox insereCPF;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

