
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo aluno / Editando aluno";
            // 
            // insereCPF
            // 
            this.insereCPF.Location = new System.Drawing.Point(233, 92);
            this.insereCPF.MaxLength = 11;
            this.insereCPF.Name = "insereCPF";
            this.insereCPF.Size = new System.Drawing.Size(113, 20);
            this.insereCPF.TabIndex = 13;
            this.insereCPF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.insereCPF_MouseClick);
            this.insereCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insereCPF_KeyPress);
            // 
            // insereNumeroMatricula
            // 
            this.insereNumeroMatricula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.insereNumeroMatricula.Location = new System.Drawing.Point(12, 48);
            this.insereNumeroMatricula.MaxLength = 9;
            this.insereNumeroMatricula.Name = "insereNumeroMatricula";
            this.insereNumeroMatricula.Size = new System.Drawing.Size(100, 20);
            this.insereNumeroMatricula.TabIndex = 12;
            this.insereNumeroMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.insereNumeroMatricula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.insereNumeroMatricula_MouseClick);
            this.insereNumeroMatricula.TextChanged += new System.EventHandler(this.insereNumeroMatricula_TextChanged);
            this.insereNumeroMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insereNumeroMatricula_KeyPress);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(434, 89);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(75, 23);
            this.botaoAdicionar.TabIndex = 11;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(353, 90);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 23);
            this.botaoLimpar.TabIndex = 10;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF";
            // 
            // insereDataDeNascimento
            // 
            this.insereDataDeNascimento.Location = new System.Drawing.Point(127, 92);
            this.insereDataDeNascimento.Mask = "00/00/0000";
            this.insereDataDeNascimento.Name = "insereDataDeNascimento";
            this.insereDataDeNascimento.Size = new System.Drawing.Size(100, 20);
            this.insereDataDeNascimento.TabIndex = 7;
            this.insereDataDeNascimento.ValidatingType = typeof(System.DateTime);
            this.insereDataDeNascimento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.insereDataDeNascimento_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nascimento";
            // 
            // selecionaSexo
            // 
            this.selecionaSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecionaSexo.FormattingEnabled = true;
            this.selecionaSexo.Location = new System.Drawing.Point(12, 92);
            this.selecionaSexo.Name = "selecionaSexo";
            this.selecionaSexo.Size = new System.Drawing.Size(109, 21);
            this.selecionaSexo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo";
            // 
            // insereNome
            // 
            this.insereNome.Location = new System.Drawing.Point(163, 48);
            this.insereNome.Name = "insereNome";
            this.insereNome.Size = new System.Drawing.Size(346, 20);
            this.insereNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula";
            // 
            // barraDePesquisa
            // 
            this.barraDePesquisa.Location = new System.Drawing.Point(14, 146);
            this.barraDePesquisa.Name = "barraDePesquisa";
            this.barraDePesquisa.Size = new System.Drawing.Size(427, 20);
            this.barraDePesquisa.TabIndex = 1;
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Location = new System.Drawing.Point(456, 145);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(75, 23);
            this.botaoPesquisar.TabIndex = 2;
            this.botaoPesquisar.Text = "Pesquisar";
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 173);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(518, 150);
            this.dataGrid.TabIndex = 3;
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(456, 329);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluir.TabIndex = 4;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(375, 329);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 23);
            this.botaoEditar.TabIndex = 5;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 364);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.barraDePesquisa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
    }
}

