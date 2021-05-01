using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public interface EstadoDeUmaConta
    {
        void Saque(Conta conta, double valor);
        void Deposito(Conta conta, double valor);
        void Negativar(Conta conta);
        void Positivar(Conta conta);
    }

    public class ContaPositiva : EstadoDeUmaConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += (valor * 0.98);
        }

        public void Saque(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0)
            {
                Negativar(conta);
            }
        }

        public void Negativar(Conta conta)
        {
            conta.EstadoAtual = new ContaNegativa();
        }

        public void Positivar(Conta conta)
        {
            throw new Exception("Impossivel positivar uma conta positiva");
        }

    }

    public class ContaNegativa : EstadoDeUmaConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += (valor * 0.95);
            if (conta.Saldo >= 0)
            {
                Positivar(conta);
            }
        }

        public void Negativar(Conta conta)
        {
            throw new Exception("Impossivel negativar uma conta negativa");
        }

        public void Positivar(Conta conta)
        {
            conta.EstadoAtual = new ContaPositiva();
        }

        public void Saque(Conta conta, double valor)
        {
            throw new Exception("Impossivel Sacar de uma conta negativa");
        }
    }
}
