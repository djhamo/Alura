using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public class SaldoHandle
    {
        public double Saldo { get; private set; }

        public SaldoHandle()
        {
            this.Saldo = 0;
        }
        public SaldoHandle(double valor)
        {
            this.Saldo = valor;
        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
        }

        public void somaInvestimento(double valor)
        {
            Deposita(this.Saldo * valor);
        }

    }

    public abstract class IConta
    {
        public SaldoHandle Saldo { get; protected set; }
        public abstract void Deposita(double valor);
        public abstract void Saca(double valor);
        public abstract void somaInvestimento();
    }

    class ContaEstudante : IConta
    {
        public int Milhas { get; private set; }

        public ContaEstudante()
        {
            this.Saldo = new SaldoHandle();
        }
        public ContaEstudante(double saldo)
        {
            this.Saldo = new SaldoHandle(saldo);
        }

        public override void Deposita(double valor)
        {
            Saldo.Deposita(valor);
            this.Milhas += (int)valor;
        }
        public override void Saca(double valor)
        {
            Saldo.Saca(valor);
        }
        public override void somaInvestimento()
        {
            Saldo.somaInvestimento(0);
        }
    }

    class ContaComum : IConta
    {
        public ContaComum()
        {
            this.Saldo = new SaldoHandle();
        }

        public ContaComum(double saldoInicial)
        {
            this.Saldo = new SaldoHandle(saldoInicial);
        }

        public override void Deposita(double valor)
        {
            Saldo.Deposita(valor);
        }
        public override void Saca(double valor)
        {
            Saldo.Saca(valor);
        }

        public override void somaInvestimento()
        {
            this.Saldo.Deposita(this.Saldo.Saldo * 0.01);
        }
    }
}
