
namespace EM.WindowsForms
{
    partial class formConfirmaExclusao
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
            this.label1 = new System.Windows.Forms.Label();
            this.botaoConfirmaExclusao = new System.Windows.Forms.Button();
            this.botaoCancelaExclusao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tem certeza que deseja excluir o aluno?";
            // 
            // botaoConfirmaExclusao
            // 
            this.botaoConfirmaExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoConfirmaExclusao.Location = new System.Drawing.Point(54, 42);
            this.botaoConfirmaExclusao.Name = "botaoConfirmaExclusao";
            this.botaoConfirmaExclusao.Size = new System.Drawing.Size(75, 23);
            this.botaoConfirmaExclusao.TabIndex = 1;
            this.botaoConfirmaExclusao.Text = "Sim";
            this.botaoConfirmaExclusao.UseVisualStyleBackColor = true;
            this.botaoConfirmaExclusao.Click += new System.EventHandler(this.botaoConfirmaExclusao_Click);
            // 
            // botaoCancelaExclusao
            // 
            this.botaoCancelaExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoCancelaExclusao.Location = new System.Drawing.Point(135, 42);
            this.botaoCancelaExclusao.Name = "botaoCancelaExclusao";
            this.botaoCancelaExclusao.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelaExclusao.TabIndex = 2;
            this.botaoCancelaExclusao.Text = "Não";
            this.botaoCancelaExclusao.UseVisualStyleBackColor = true;
            this.botaoCancelaExclusao.Click += new System.EventHandler(this.botaoCancelaExclusao_Click);
            // 
            // confirmaExclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 89);
            this.Controls.Add(this.botaoCancelaExclusao);
            this.Controls.Add(this.botaoConfirmaExclusao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "confirmaExclusao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoConfirmaExclusao;
        private System.Windows.Forms.Button botaoCancelaExclusao;
    }
}