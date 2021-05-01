using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class Conta
    {

        private double saldo;
        public int Numero { get; private set; }
        public string Correntista { get; set; }
        public double Saldo {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
                if (saldo < 0)
                {
                    EstadoAtual = new ContaNegativa();
                } else
                {
                    EstadoAtual = new ContaPositiva();
                }

            }
        }
        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public EstadoDeUmaConta EstadoAtual { get; set; }
        public Conta(int numero)
        {
            this.Numero = numero;
        }
        public void Saque(double valor)
        {
            EstadoAtual.Saque(this, valor);
        }
        public void Deposito(double valor)
        {
            EstadoAtual.Deposito(this, valor);
        }
        public void Negativar()
        {
            EstadoAtual.Negativar(this);
        }
        public void Positivar()
        {
            EstadoAtual.Positivar(this);
        }

    }
}
