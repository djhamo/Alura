namespace CaixaEletronico
{
    partial class CadastroDeContas
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
            this.titularConta = new System.Windows.Forms.TextBox();
            this.numeroDaConta = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.cbTipoConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(87, 12);
            this.titularConta.Name = "titularConta";
            this.titularConta.Size = new System.Drawing.Size(100, 20);
            this.titularConta.TabIndex = 0;
            // 
            // numeroDaConta
            // 
            this.numeroDaConta.Location = new System.Drawing.Point(87, 50);
            this.numeroDaConta.Name = "numeroDaConta";
            this.numeroDaConta.Size = new System.Drawing.Size(100, 20);
            this.numeroDaConta.TabIndex = 1;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(95, 226);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // cbTipoConta
            // 
            this.cbTipoConta.FormattingEnabled = true;
            this.cbTipoConta.Location = new System.Drawing.Point(87, 83);
            this.cbTipoConta.Name = "cbTipoConta";
            this.cbTipoConta.Size = new System.Drawing.Size(121, 21);
            this.cbTipoConta.TabIndex = 3;
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbTipoConta);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.numeroDaConta);
            this.Controls.Add(this.titularConta);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.Load += new System.EventHandler(this.CadastroDeContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.TextBox numeroDaConta;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ComboBox cbTipoConta;
    }
}