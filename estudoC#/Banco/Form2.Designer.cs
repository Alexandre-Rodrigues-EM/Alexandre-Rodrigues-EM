
namespace Banco
{
    partial class Form2
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
            this.selecionaTipoConta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoCriaSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.criaTitular = new System.Windows.Forms.Label();
            this.textoCriaTitular = new System.Windows.Forms.TextBox();
            this.criaNovaConta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selecionaTipoConta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoCriaSaldo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.criaTitular);
            this.groupBox1.Controls.Add(this.textoCriaTitular);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(285, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Conta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // selecionaTipoConta
            // 
            this.selecionaTipoConta.FormattingEnabled = true;
            this.selecionaTipoConta.Location = new System.Drawing.Point(127, 78);
            this.selecionaTipoConta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selecionaTipoConta.Name = "selecionaTipoConta";
            this.selecionaTipoConta.Size = new System.Drawing.Size(146, 23);
            this.selecionaTipoConta.TabIndex = 7;
            this.selecionaTipoConta.SelectedIndexChanged += new System.EventHandler(this.selecionaTipoConta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de conta";
            // 
            // textoCriaSaldo
            // 
            this.textoCriaSaldo.Location = new System.Drawing.Point(127, 49);
            this.textoCriaSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textoCriaSaldo.Name = "textoCriaSaldo";
            this.textoCriaSaldo.Size = new System.Drawing.Size(146, 23);
            this.textoCriaSaldo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saldo";
            // 
            // criaTitular
            // 
            this.criaTitular.AutoSize = true;
            this.criaTitular.Location = new System.Drawing.Point(12, 28);
            this.criaTitular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.criaTitular.Name = "criaTitular";
            this.criaTitular.Size = new System.Drawing.Size(40, 15);
            this.criaTitular.TabIndex = 2;
            this.criaTitular.Text = "Titular";
            // 
            // textoCriaTitular
            // 
            this.textoCriaTitular.Location = new System.Drawing.Point(127, 20);
            this.textoCriaTitular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textoCriaTitular.Name = "textoCriaTitular";
            this.textoCriaTitular.Size = new System.Drawing.Size(146, 23);
            this.textoCriaTitular.TabIndex = 0;
            this.textoCriaTitular.TextChanged += new System.EventHandler(this.textoCriaTitular_TextChanged);
            // 
            // criaNovaConta
            // 
            this.criaNovaConta.Location = new System.Drawing.Point(113, 142);
            this.criaNovaConta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.criaNovaConta.Name = "criaNovaConta";
            this.criaNovaConta.Size = new System.Drawing.Size(88, 27);
            this.criaNovaConta.TabIndex = 1;
            this.criaNovaConta.Text = "Criar";
            this.criaNovaConta.UseVisualStyleBackColor = true;
            this.criaNovaConta.Click += new System.EventHandler(this.criaNovaConta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 177);
            this.Controls.Add(this.criaNovaConta);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Cadastro de nova conta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoCriaSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label criaTitular;
        private System.Windows.Forms.TextBox textoCriaTitular;
        private System.Windows.Forms.Button criaNovaConta;
        private System.Windows.Forms.ComboBox selecionaTipoConta;
        private System.Windows.Forms.Label label2;
    }
}