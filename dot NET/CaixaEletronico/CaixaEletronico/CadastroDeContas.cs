using System;
using System.Windows.Forms;
using Caelum.CaixaEletronico.Modelo.Contas;
using Caelum.CaixaEletronico.Modelo.Usuarios;

namespace CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;

        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string indiceSelecionado = cbTipoConta.SelectedText;

            Conta novaConta;
            if (indiceSelecionado == "Conta Corrente")
            {
                novaConta = new ContaCorrente();
                Cliente cliente = new Cliente();
                cliente.Nome = titularConta.Text;
                novaConta.Titular = cliente;
                novaConta.Numero = Convert.ToInt32(numeroDaConta.Text);

            }
            else
            {
                novaConta = new ContaPoupanca();
                Cliente cliente = new Cliente();
                cliente.Nome = titularConta.Text;
                novaConta.Titular = cliente;
                novaConta.Numero = Convert.ToInt32(numeroDaConta.Text);

            }


            aplicacaoPrincipal.AdicionaConta(novaConta);
            Close();
        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            cbTipoConta.Items.Add("Conta Corrente");
            cbTipoConta.Items.Add("Poupança");
        }
    }
}
