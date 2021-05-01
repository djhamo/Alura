namespace ContaCorrente1
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
            this.cbConta = new System.Windows.Forms.ComboBox();
            this.txContaNumero = new System.Windows.Forms.TextBox();
            this.txContaTitular = new System.Windows.Forms.TextBox();
            this.txContaSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btDeposito = new System.Windows.Forms.Button();
            this.btSacar = new System.Windows.Forms.Button();
            this.txValor = new System.Windows.Forms.TextBox();
            this.destinoTransferencia = new System.Windows.Forms.ComboBox();
            this.btTranferir = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbConta
            // 
            this.cbConta.FormattingEnabled = true;
            this.cbConta.Location = new System.Drawing.Point(126, 35);
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(121, 21);
            this.cbConta.TabIndex = 1;
            this.cbConta.SelectedIndexChanged += new System.EventHandler(this.cbConta_SelectedIndexChanged);
            // 
            // txContaNumero
            // 
            this.txContaNumero.Location = new System.Drawing.Point(147, 68);
            this.txContaNumero.Name = "txContaNumero";
            this.txContaNumero.Size = new System.Drawing.Size(100, 20);
            this.txContaNumero.TabIndex = 2;
            // 
            // txContaTitular
            // 
            this.txContaTitular.Location = new System.Drawing.Point(147, 99);
            this.txContaTitular.Name = "txContaTitular";
            this.txContaTitular.Size = new System.Drawing.Size(100, 20);
            this.txContaTitular.TabIndex = 3;
            // 
            // txContaSaldo
            // 
            this.txContaSaldo.Location = new System.Drawing.Point(147, 129);
            this.txContaSaldo.Name = "txContaSaldo";
            this.txContaSaldo.Size = new System.Drawing.Size(100, 20);
            this.txContaSaldo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saldo";
            // 
            // btDeposito
            // 
            this.btDeposito.Location = new System.Drawing.Point(66, 161);
            this.btDeposito.Name = "btDeposito";
            this.btDeposito.Size = new System.Drawing.Size(75, 23);
            this.btDeposito.TabIndex = 9;
            this.btDeposito.Text = "Depositar";
            this.btDeposito.UseVisualStyleBackColor = true;
            this.btDeposito.Click += new System.EventHandler(this.btDeposito_Click);
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(66, 194);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(75, 23);
            this.btSacar.TabIndex = 10;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(147, 163);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(100, 20);
            this.txValor.TabIndex = 11;
            // 
            // destinoTransferencia
            // 
            this.destinoTransferencia.FormattingEnabled = true;
            this.destinoTransferencia.Location = new System.Drawing.Point(126, 223);
            this.destinoTransferencia.Name = "destinoTransferencia";
            this.destinoTransferencia.Size = new System.Drawing.Size(121, 21);
            this.destinoTransferencia.TabIndex = 12;
            // 
            // btTranferir
            // 
            this.btTranferir.Location = new System.Drawing.Point(34, 223);
            this.btTranferir.Name = "btTranferir";
            this.btTranferir.Size = new System.Drawing.Size(75, 23);
            this.btTranferir.TabIndex = 13;
            this.btTranferir.Text = "Transferir";
            this.btTranferir.UseVisualStyleBackColor = true;
            this.btTranferir.Click += new System.EventHandler(this.btTranferir_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(147, 194);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 14;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btTranferir);
            this.Controls.Add(this.destinoTransferencia);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.btDeposito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txContaSaldo);
            this.Controls.Add(this.txContaTitular);
            this.Controls.Add(this.txContaNumero);
            this.Controls.Add(this.cbConta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbConta;
        private System.Windows.Forms.TextBox txContaNumero;
        private System.Windows.Forms.TextBox txContaTitular;
        private System.Windows.Forms.TextBox txContaSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDeposito;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.ComboBox destinoTransferencia;
        private System.Windows.Forms.Button btTranferir;
        private System.Windows.Forms.Button btOK;
    }
}

