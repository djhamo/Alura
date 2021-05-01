using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente1
{
    abstract class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; protected set; }
        public int Numero { get; set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public void Saca(double valor)
        {

            this.Saldo -= valor;
        }
        public virtual void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * taxa;
        }

        public void Transfere(Conta destino, double valor)
        {
            Saca(valor);
            destino.Deposita(valor);
        }

    }
    class ContaPoupanca : Conta, ITributavel
    {
        public override void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * 3 * taxa;
        }

        public double CalculaTributos()
        {
            return Saldo * 0.02;
        }
    }
    class ContaCorrente : Conta
    {
        public override void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * 2 * taxa;
        }
    }

    public interface ITributavel
    {
        double CalculaTributos();
    }

    class SeguroDeVida : ITributavel
    {
        public double CalculaTributos()
        {
            return 42.0;
        }

    }

    public class GerenciadorDeImposto
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel tributavel)
        {
            this.Total += tributavel.CalculaTributos();
        }
    }
}
