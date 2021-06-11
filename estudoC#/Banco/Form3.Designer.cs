
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
            this.telaRelatorio = new System.Windows.Forms.ListView();
            this.btnGeraRelatorioGeral = new System.Windows.Forms.Button();
            this.btnGeraRelatorioDeImpostos = new System.Windows.Forms.Button();
            this.btnGeraRelatorioDeTrasacoes = new System.Windows.Forms.Button();
            this.btnImprimeRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // telaRelatorio
            // 
            this.telaRelatorio.HideSelection = false;
            this.telaRelatorio.Location = new System.Drawing.Point(12, 12);
            this.telaRelatorio.Name = "telaRelatorio";
            this.telaRelatorio.Size = new System.Drawing.Size(406, 285);
            this.telaRelatorio.TabIndex = 0;
            this.telaRelatorio.UseCompatibleStateImageBehavior = false;
            // 
            // btnGeraRelatorioGeral
            // 
            this.btnGeraRelatorioGeral.Location = new System.Drawing.Point(12, 304);
            this.btnGeraRelatorioGeral.Name = "btnGeraRelatorioGeral";
            this.btnGeraRelatorioGeral.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioGeral.TabIndex = 1;
            this.btnGeraRelatorioGeral.Text = "Geral";
            this.btnGeraRelatorioGeral.UseVisualStyleBackColor = true;
            this.btnGeraRelatorioGeral.Click += new System.EventHandler(this.btnGeraRelatorioGeral_Click);
            // 
            // btnGeraRelatorioDeImpostos
            // 
            this.btnGeraRelatorioDeImpostos.Location = new System.Drawing.Point(93, 304);
            this.btnGeraRelatorioDeImpostos.Name = "btnGeraRelatorioDeImpostos";
            this.btnGeraRelatorioDeImpostos.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioDeImpostos.TabIndex = 2;
            this.btnGeraRelatorioDeImpostos.Text = "Impostos";
            this.btnGeraRelatorioDeImpostos.UseVisualStyleBackColor = true;
            // 
            // btnGeraRelatorioDeTrasacoes
            // 
            this.btnGeraRelatorioDeTrasacoes.Location = new System.Drawing.Point(174, 304);
            this.btnGeraRelatorioDeTrasacoes.Name = "btnGeraRelatorioDeTrasacoes";
            this.btnGeraRelatorioDeTrasacoes.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorioDeTrasacoes.TabIndex = 3;
            this.btnGeraRelatorioDeTrasacoes.Text = "Transações";
            this.btnGeraRelatorioDeTrasacoes.UseVisualStyleBackColor = true;
            // 
            // btnImprimeRelatorio
            // 
            this.btnImprimeRelatorio.Location = new System.Drawing.Point(304, 304);
            this.btnImprimeRelatorio.Name = "btnImprimeRelatorio";
            this.btnImprimeRelatorio.Size = new System.Drawing.Size(114, 23);
            this.btnImprimeRelatorio.TabIndex = 4;
            this.btnImprimeRelatorio.Text = "Gerar Arquivo";
            this.btnImprimeRelatorio.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 348);
            this.Controls.Add(this.btnImprimeRelatorio);
            this.Controls.Add(this.btnGeraRelatorioDeTrasacoes);
            this.Controls.Add(this.btnGeraRelatorioDeImpostos);
            this.Controls.Add(this.btnGeraRelatorioGeral);
            this.Controls.Add(this.telaRelatorio);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView telaRelatorio;
        private System.Windows.Forms.Button btnGeraRelatorioGeral;
        private System.Windows.Forms.Button btnGeraRelatorioDeImpostos;
        private System.Windows.Forms.Button btnGeraRelatorioDeTrasacoes;
        private System.Windows.Forms.Button btnImprimeRelatorio;
    }
}