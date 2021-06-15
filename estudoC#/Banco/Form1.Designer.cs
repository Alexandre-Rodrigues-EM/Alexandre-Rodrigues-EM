
namespace Banco
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
            this.EscolhaDeConta = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.valorBuscaConta = new System.Windows.Forms.TextBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.demonstrativoConta = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.realizaTransferencia = new System.Windows.Forms.Button();
            this.valorTransferencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contaDestino = new System.Windows.Forms.ComboBox();
            this.btnCalculaImpostos = new System.Windows.Forms.Button();
            this.btnGeraRelatorios = new System.Windows.Forms.Button();
            this.EscolhaDeConta.SuspendLayout();
            this.demonstrativoConta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EscolhaDeConta
            // 
            this.EscolhaDeConta.Controls.Add(this.button3);
            this.EscolhaDeConta.Controls.Add(this.label7);
            this.EscolhaDeConta.Controls.Add(this.valorBuscaConta);
            this.EscolhaDeConta.Controls.Add(this.comboContas);
            this.EscolhaDeConta.Location = new System.Drawing.Point(173, 14);
            this.EscolhaDeConta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EscolhaDeConta.Name = "EscolhaDeConta";
            this.EscolhaDeConta.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EscolhaDeConta.Size = new System.Drawing.Size(233, 115);
            this.EscolhaDeConta.TabIndex = 0;
            this.EscolhaDeConta.TabStop = false;
            this.EscolhaDeConta.Text = "Escolha De Conta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Número da Conta";
            // 
            // valorBuscaConta
            // 
            this.valorBuscaConta.Location = new System.Drawing.Point(120, 52);
            this.valorBuscaConta.Name = "valorBuscaConta";
            this.valorBuscaConta.Size = new System.Drawing.Size(105, 23);
            this.valorBuscaConta.TabIndex = 1;
            // 
            // comboContas
            // 
            this.comboContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContas.FormattingEnabled = true;
            this.comboContas.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboContas.Location = new System.Drawing.Point(8, 22);
            this.comboContas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(217, 23);
            this.comboContas.TabIndex = 0;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // demonstrativoConta
            // 
            this.demonstrativoConta.Controls.Add(this.label4);
            this.demonstrativoConta.Controls.Add(this.label3);
            this.demonstrativoConta.Controls.Add(this.label2);
            this.demonstrativoConta.Controls.Add(this.label1);
            this.demonstrativoConta.Controls.Add(this.button2);
            this.demonstrativoConta.Controls.Add(this.textoValor);
            this.demonstrativoConta.Controls.Add(this.button1);
            this.demonstrativoConta.Controls.Add(this.textoSaldo);
            this.demonstrativoConta.Controls.Add(this.textoNumero);
            this.demonstrativoConta.Controls.Add(this.textoTitular);
            this.demonstrativoConta.Location = new System.Drawing.Point(15, 136);
            this.demonstrativoConta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.demonstrativoConta.Name = "demonstrativoConta";
            this.demonstrativoConta.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.demonstrativoConta.Size = new System.Drawing.Size(550, 179);
            this.demonstrativoConta.TabIndex = 1;
            this.demonstrativoConta.TabStop = false;
            this.demonstrativoConta.Text = "Informações da Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor para operação";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 136);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Depósito";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(286, 106);
            this.textoValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(235, 23);
            this.textoValor.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Saque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Enabled = false;
            this.textoSaldo.Location = new System.Drawing.Point(286, 76);
            this.textoSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(235, 23);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoNumero
            // 
            this.textoNumero.Enabled = false;
            this.textoNumero.Location = new System.Drawing.Point(286, 46);
            this.textoNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(235, 23);
            this.textoNumero.TabIndex = 1;
            // 
            // textoTitular
            // 
            this.textoTitular.Enabled = false;
            this.textoTitular.Location = new System.Drawing.Point(286, 16);
            this.textoTitular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(235, 23);
            this.textoTitular.TabIndex = 0;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(15, 452);
            this.botaoCadastro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(106, 27);
            this.botaoCadastro.TabIndex = 2;
            this.botaoCadastro.Text = "Nova Conta";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.realizaTransferencia);
            this.groupBox1.Controls.Add(this.valorTransferencia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.contaDestino);
            this.groupBox1.Location = new System.Drawing.Point(15, 322);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(550, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transferência";
            // 
            // realizaTransferencia
            // 
            this.realizaTransferencia.Location = new System.Drawing.Point(364, 84);
            this.realizaTransferencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.realizaTransferencia.Name = "realizaTransferencia";
            this.realizaTransferencia.Size = new System.Drawing.Size(88, 27);
            this.realizaTransferencia.TabIndex = 12;
            this.realizaTransferencia.Text = "Transferir";
            this.realizaTransferencia.UseVisualStyleBackColor = true;
            this.realizaTransferencia.Click += new System.EventHandler(this.realizaTransferencia_Click);
            // 
            // valorTransferencia
            // 
            this.valorTransferencia.Location = new System.Drawing.Point(286, 54);
            this.valorTransferencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.valorTransferencia.Name = "valorTransferencia";
            this.valorTransferencia.Size = new System.Drawing.Size(235, 23);
            this.valorTransferencia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor para operação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Selecione a conta de destino";
            // 
            // contaDestino
            // 
            this.contaDestino.FormattingEnabled = true;
            this.contaDestino.Location = new System.Drawing.Point(286, 23);
            this.contaDestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contaDestino.Name = "contaDestino";
            this.contaDestino.Size = new System.Drawing.Size(235, 23);
            this.contaDestino.TabIndex = 0;
            this.contaDestino.SelectedIndexChanged += new System.EventHandler(this.contaDestino_SelectedIndexChanged);
            // 
            // btnCalculaImpostos
            // 
            this.btnCalculaImpostos.Location = new System.Drawing.Point(237, 452);
            this.btnCalculaImpostos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculaImpostos.Name = "btnCalculaImpostos";
            this.btnCalculaImpostos.Size = new System.Drawing.Size(106, 27);
            this.btnCalculaImpostos.TabIndex = 4;
            this.btnCalculaImpostos.Text = "Impostos";
            this.btnCalculaImpostos.UseVisualStyleBackColor = true;
            this.btnCalculaImpostos.Click += new System.EventHandler(this.btnCalculaImpostos_Click);
            // 
            // btnGeraRelatorios
            // 
            this.btnGeraRelatorios.Location = new System.Drawing.Point(458, 452);
            this.btnGeraRelatorios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGeraRelatorios.Name = "btnGeraRelatorios";
            this.btnGeraRelatorios.Size = new System.Drawing.Size(106, 27);
            this.btnGeraRelatorios.TabIndex = 5;
            this.btnGeraRelatorios.Text = "Relatórios";
            this.btnGeraRelatorios.UseVisualStyleBackColor = true;
            this.btnGeraRelatorios.Click += new System.EventHandler(this.btnGeraRelatorios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 489);
            this.Controls.Add(this.btnGeraRelatorios);
            this.Controls.Add(this.btnCalculaImpostos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.demonstrativoConta);
            this.Controls.Add(this.EscolhaDeConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EscolhaDeConta.ResumeLayout(false);
            this.EscolhaDeConta.PerformLayout();
            this.demonstrativoConta.ResumeLayout(false);
            this.demonstrativoConta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EscolhaDeConta;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.GroupBox demonstrativoConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button realizaTransferencia;
        private System.Windows.Forms.TextBox valorTransferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox contaDestino;
        private System.Windows.Forms.Button btnCalculaImpostos;
        private System.Windows.Forms.Button btnGeraRelatorios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox valorBuscaConta;
    }
}

