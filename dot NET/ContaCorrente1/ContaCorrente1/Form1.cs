using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente1
{
    public partial class Form1 : Form
    {
        Conta [] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void cbConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = cbConta.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            Atualiza(contaSelecionada);
        }

        private void Atualiza(Conta contaSelecionada)
        {
            txContaTitular.Text = contaSelecionada.Titular;
            txContaSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            txContaNumero.Text = Convert.ToString(contaSelecionada.Numero);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = "Victor";
            contaDoVictor.Numero = 1;

            Conta contaDoMario = new ContaPoupanca();
            contaDoMario.Titular = "Mario";
            contaDoMario.Numero = 2;

            this.contas = new Conta[2];
            this.contas[0] = contaDoVictor;
            this.contas[1] = contaDoMario;

            foreach (Conta conta in contas)
            {
                cbConta.Items.Add(conta.Titular);
            }

            foreach (Conta conta in contas)
            {
                destinoTransferencia.Items.Add(conta.Titular);
            }
        }

        private void btDeposito_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = cbConta.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            double valor = Convert.ToDouble(txValor.Text);

            contaSelecionada.Deposita(valor);

            Atualiza(contaSelecionada);
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = cbConta.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            double valor = Convert.ToDouble(txValor.Text);

            contaSelecionada.Saca(valor);

            Atualiza(contaSelecionada);

        }

        private void btTranferir_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = cbConta.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            indiceSelecionado = destinoTransferencia.SelectedIndex;
            Conta contaDestinoTransferencia = contas[indiceSelecionado];

            double valor = Convert.ToDouble(txValor.Text);

            contaSelecionada.Transfere(contaDestinoTransferencia, valor);

            Atualiza(contaSelecionada);

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            ContaCorrente contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = "Victor";
            contaDoVictor.Numero = 1;
            contaDoVictor.Deposita(100);

            ContaPoupanca contaDoMario = new ContaPoupanca();
            contaDoMario.Titular = "Mario";
            contaDoMario.Numero = 2;
            contaDoMario.Deposita(100);

            SeguroDeVida contaSeguro = new SeguroDeVida();

            GerenciadorDeImposto gImp = new GerenciadorDeImposto();
            //gImp.Adiciona(contaDoVictor);
            gImp.Adiciona(contaDoMario);
            gImp.Adiciona(contaSeguro);

            MessageBox.Show("Total de Impostos: " + gImp.Total);

        }
    }
}
