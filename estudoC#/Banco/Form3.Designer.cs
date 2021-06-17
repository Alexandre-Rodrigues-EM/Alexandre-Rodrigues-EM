
namespace Banco
{
    partial class Form3
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
            this.btnGeraRelatorioGeral = new System.Windows.Forms.Button();
            this.btnGeraRelatorioDeImpostos = new System.Windows.Forms.Button();
            this.btnGeraRelatorioDeTrasacoes = new System.Windows.Forms.Button();
            this.btnImprimeRelatorio = new System.Windows.Forms.Button();
            this.telaRelatorio = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.realizaFiltro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valorDeFiltro = new System.Windows.Forms.TextBox();
            this.selecionaFiltroDeValor = new System.Windows.Forms.ComboBox();
            this.selecionaTipoDeConta = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mostraPorcentagemFiltro = new System.Windows.Forms.Label();
            this.mostraTitularMenorSaldo = new System.Windows.Forms.Label();
            this.mostraTitularMaiorSaldo = new System.Windows.Forms.Label();
            this.mostraNumDeContas = new System.Windows.Forms.Label();
            this.mostraMenorSaldo = new System.Windows.Forms.Label();
            this.mostraMaiorSaldo = new System.Windows.Forms.Label();
            this.mostraMediaSaldos = new System.Windows.Forms.Label();
            this.mostraSomaSaldos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeraRelatorioGeral
            // 
            this.btnGeraRelatorioGeral.Location = new System.Drawing.Point(12, 432);
            this.btnGeraRelatorioGeral.Name = "btnGeraRelatorioGeral";
            this.btnGeraRelatorioGeral.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioGeral.TabIndex = 1;
            this.btnGeraRelatorioGeral.Text = "Geral";
            this.btnGeraRelatorioGeral.UseVisualStyleBackColor = true;
            this.btnGeraRelatorioGeral.Click += new System.EventHandler(this.btnGeraRelatorioGeral_Click);
            // 
            // btnGeraRelatorioDeImpostos
            // 
            this.btnGeraRelatorioDeImpostos.Location = new System.Drawing.Point(93, 432);
            this.btnGeraRelatorioDeImpostos.Name = "btnGeraRelatorioDeImpostos";
            this.btnGeraRelatorioDeImpostos.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioDeImpostos.TabIndex = 2;
            this.btnGeraRelatorioDeImpostos.Text = "Impostos";
            this.btnGeraRelatorioDeImpostos.UseVisualStyleBackColor = true;
            // 
            // btnGeraRelatorioDeTrasacoes
            // 
            this.btnGeraRelatorioDeTrasacoes.Location = new System.Drawing.Point(174, 432);
            this.btnGeraRelatorioDeTrasacoes.Name = "btnGeraRelatorioDeTrasacoes";
            this.btnGeraRelatorioDeTrasacoes.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioDeTrasacoes.TabIndex = 3;
            this.btnGeraRelatorioDeTrasacoes.Text = "Transações";
            this.btnGeraRelatorioDeTrasacoes.UseVisualStyleBackColor = true;
            // 
            // btnImprimeRelatorio
            // 
            this.btnImprimeRelatorio.Location = new System.Drawing.Point(368, 432);
            this.btnImprimeRelatorio.Name = "btnImprimeRelatorio";
            this.btnImprimeRelatorio.Size = new System.Drawing.Size(114, 23);
            this.btnImprimeRelatorio.TabIndex = 4;
            this.btnImprimeRelatorio.Text = "Gerar Arquivo";
            this.btnImprimeRelatorio.UseVisualStyleBackColor = true;
            // 
            // telaRelatorio
            // 
            this.telaRelatorio.FormattingEnabled = true;
            this.telaRelatorio.ItemHeight = 15;
            this.telaRelatorio.Location = new System.Drawing.Point(13, 12);
            this.telaRelatorio.Name = "telaRelatorio";
            this.telaRelatorio.Size = new System.Drawing.Size(468, 169);
            this.telaRelatorio.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.realizaFiltro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.valorDeFiltro);
            this.groupBox1.Controls.Add(this.selecionaFiltroDeValor);
            this.groupBox1.Controls.Add(this.selecionaTipoDeConta);
            this.groupBox1.Location = new System.Drawing.Point(13, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar resultado";
            // 
            // realizaFiltro
            // 
            this.realizaFiltro.Location = new System.Drawing.Point(387, 79);
            this.realizaFiltro.Name = "realizaFiltro";
            this.realizaFiltro.Size = new System.Drawing.Size(75, 23);
            this.realizaFiltro.TabIndex = 5;
            this.realizaFiltro.Text = "Filtrar";
            this.realizaFiltro.UseVisualStyleBackColor = true;
            this.realizaFiltro.Click += new System.EventHandler(this.realizaFiltro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor do saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de conta";
            // 
            // valorDeFiltro
            // 
            this.valorDeFiltro.Location = new System.Drawing.Point(253, 50);
            this.valorDeFiltro.Name = "valorDeFiltro";
            this.valorDeFiltro.Size = new System.Drawing.Size(209, 23);
            this.valorDeFiltro.TabIndex = 2;
            this.valorDeFiltro.TextChanged += new System.EventHandler(this.valorDeFiltro_TextChanged);
            // 
            // selecionaFiltroDeValor
            // 
            this.selecionaFiltroDeValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecionaFiltroDeValor.FormattingEnabled = true;
            this.selecionaFiltroDeValor.Location = new System.Drawing.Point(129, 50);
            this.selecionaFiltroDeValor.Name = "selecionaFiltroDeValor";
            this.selecionaFiltroDeValor.Size = new System.Drawing.Size(118, 23);
            this.selecionaFiltroDeValor.TabIndex = 1;
            // 
            // selecionaTipoDeConta
            // 
            this.selecionaTipoDeConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecionaTipoDeConta.FormattingEnabled = true;
            this.selecionaTipoDeConta.Location = new System.Drawing.Point(253, 23);
            this.selecionaTipoDeConta.Name = "selecionaTipoDeConta";
            this.selecionaTipoDeConta.Size = new System.Drawing.Size(209, 23);
            this.selecionaTipoDeConta.TabIndex = 0;
            this.selecionaTipoDeConta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mostraPorcentagemFiltro);
            this.groupBox2.Controls.Add(this.mostraTitularMenorSaldo);
            this.groupBox2.Controls.Add(this.mostraTitularMaiorSaldo);
            this.groupBox2.Controls.Add(this.mostraNumDeContas);
            this.groupBox2.Controls.Add(this.mostraMenorSaldo);
            this.groupBox2.Controls.Add(this.mostraMaiorSaldo);
            this.groupBox2.Controls.Add(this.mostraMediaSaldos);
            this.groupBox2.Controls.Add(this.mostraSomaSaldos);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 119);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // mostraPorcentagemFiltro
            // 
            this.mostraPorcentagemFiltro.AutoSize = true;
            this.mostraPorcentagemFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostraPorcentagemFiltro.Location = new System.Drawing.Point(359, 82);
            this.mostraPorcentagemFiltro.Name = "mostraPorcentagemFiltro";
            this.mostraPorcentagemFiltro.Size = new System.Drawing.Size(0, 15);
            this.mostraPorcentagemFiltro.TabIndex = 15;
            // 
            // mostraTitularMenorSaldo
            // 
            this.mostraTitularMenorSaldo.AutoSize = true;
            this.mostraTitularMenorSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostraTitularMenorSaldo.Location = new System.Drawing.Point(259, 67);
            this.mostraTitularMenorSaldo.Name = "mostraTitularMenorSaldo";
            this.mostraTitularMenorSaldo.Size = new System.Drawing.Size(0, 15);
            this.mostraTitularMenorSaldo.TabIndex = 14;
            // 
            // mostraTitularMaiorSaldo
            // 
            this.mostraTitularMaiorSaldo.AutoSize = true;
            this.mostraTitularMaiorSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostraTitularMaiorSaldo.Location = new System.Drawing.Point(259, 52);
            this.mostraTitularMaiorSaldo.Name = "mostraTitularMaiorSaldo";
            this.mostraTitularMaiorSaldo.Size = new System.Drawing.Size(0, 15);
            this.mostraTitularMaiorSaldo.TabIndex = 13;
            // 
            // mostraNumDeContas
            // 
            this.mostraNumDeContas.AutoSize = true;
            this.mostraNumDeContas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostraNumDeContas.Location = new System.Drawing.Point(131, 82);
            this.mostraNumDeContas.Name = "mostraNumDeContas";
            this.mostraNumDeContas.Size = new System.Drawing.Size(0, 15);
            this.mostraNumDeContas.TabIndex = 12;
            // 
            // mostraMenorSaldo
            // 
            this.mostraMenorSaldo.AutoSize = true;
            this.mostraMenorSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostraMenorSaldo.Location = new System.Drawing.Point(131, 67);
            this.mostraMenorSaldo.Name = "mostraMenorSaldo";
            this.mostraMenorSaldo.Size = new System.Drawing.Size(0, 15);
            this.mostraMenorSaldo.TabIndex = 11;
            // 
            // mostraMaiorSaldo
            // 
            this.mostraMaiorSaldo.AutoSize = true;
            this.mostraMaiorSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostraMaiorSaldo.Location = new System.Drawing.Point(131, 52);
            this.mostraMaiorSaldo.Name = "mostraMaiorSaldo";
            this.mostraMaiorSaldo.Size = new System.Drawing.Size(0, 15);
            this.mostraMaiorSaldo.TabIndex = 10;
            // 
            // mostraMediaSaldos
            // 
            this.mostraMediaSaldos.AutoSize = true;
            this.mostraMediaSaldos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostraMediaSaldos.Location = new System.Drawing.Point(131, 37);
            this.mostraMediaSaldos.Name = "mostraMediaSaldos";
            this.mostraMediaSaldos.Size = new System.Drawing.Size(0, 15);
            this.mostraMediaSaldos.TabIndex = 9;
            // 
            // mostraSomaSaldos
            // 
            this.mostraSomaSaldos.AutoSize = true;
            this.mostraSomaSaldos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostraSomaSaldos.Location = new System.Drawing.Point(131, 22);
            this.mostraSomaSaldos.Name = "mostraSomaSaldos";
            this.mostraSomaSaldos.Size = new System.Drawing.Size(0, 15);
            this.mostraSomaSaldos.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Porcetagem sobre o total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Numero de contas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Titular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Titular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Menor saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Maior saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Média de saldos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total dos Saldos:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.telaRelatorio);
            this.Controls.Add(this.btnImprimeRelatorio);
            this.Controls.Add(this.btnGeraRelatorioDeTrasacoes);
            this.Controls.Add(this.btnGeraRelatorioDeImpostos);
            this.Controls.Add(this.btnGeraRelatorioGeral);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGeraRelatorioGeral;
        private System.Windows.Forms.Button btnGeraRelatorioDeImpostos;
        private System.Windows.Forms.Button btnGeraRelatorioDeTrasacoes;
        private System.Windows.Forms.Button btnImprimeRelatorio;
        private System.Windows.Forms.ListBox telaRelatorio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valorDeFiltro;
        private System.Windows.Forms.ComboBox selecionaFiltroDeValor;
        private System.Windows.Forms.ComboBox selecionaTipoDeConta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mostraPorcentagemFiltro;
        private System.Windows.Forms.Label mostraTitularMenorSaldo;
        private System.Windows.Forms.Label mostraTitularMaiorSaldo;
        private System.Windows.Forms.Label mostraNumDeContas;
        private System.Windows.Forms.Label mostraMenorSaldo;
        private System.Windows.Forms.Label mostraMaiorSaldo;
        private System.Windows.Forms.Label mostraMediaSaldos;
        private System.Windows.Forms.Label mostraSomaSaldos;
        private System.Windows.Forms.Button realizaFiltro;
    }
}