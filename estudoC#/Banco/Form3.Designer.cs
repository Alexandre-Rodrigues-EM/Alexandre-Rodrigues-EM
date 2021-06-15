
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeraRelatorioGeral
            // 
            this.btnGeraRelatorioGeral.Location = new System.Drawing.Point(12, 398);
            this.btnGeraRelatorioGeral.Name = "btnGeraRelatorioGeral";
            this.btnGeraRelatorioGeral.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioGeral.TabIndex = 1;
            this.btnGeraRelatorioGeral.Text = "Geral";
            this.btnGeraRelatorioGeral.UseVisualStyleBackColor = true;
            this.btnGeraRelatorioGeral.Click += new System.EventHandler(this.btnGeraRelatorioGeral_Click);
            // 
            // btnGeraRelatorioDeImpostos
            // 
            this.btnGeraRelatorioDeImpostos.Location = new System.Drawing.Point(93, 398);
            this.btnGeraRelatorioDeImpostos.Name = "btnGeraRelatorioDeImpostos";
            this.btnGeraRelatorioDeImpostos.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioDeImpostos.TabIndex = 2;
            this.btnGeraRelatorioDeImpostos.Text = "Impostos";
            this.btnGeraRelatorioDeImpostos.UseVisualStyleBackColor = true;
            // 
            // btnGeraRelatorioDeTrasacoes
            // 
            this.btnGeraRelatorioDeTrasacoes.Location = new System.Drawing.Point(174, 398);
            this.btnGeraRelatorioDeTrasacoes.Name = "btnGeraRelatorioDeTrasacoes";
            this.btnGeraRelatorioDeTrasacoes.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioDeTrasacoes.TabIndex = 3;
            this.btnGeraRelatorioDeTrasacoes.Text = "Transações";
            this.btnGeraRelatorioDeTrasacoes.UseVisualStyleBackColor = true;
            // 
            // btnImprimeRelatorio
            // 
            this.btnImprimeRelatorio.Location = new System.Drawing.Point(304, 398);
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
            this.telaRelatorio.Size = new System.Drawing.Size(405, 169);
            this.telaRelatorio.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar resultado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 119);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 23);
            this.comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor do saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total dos Saldos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Média de saldos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Maior saldo";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Titular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Titular:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Porcetagem sobre o total:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 433);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}