using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        private IList<Pagamento> _pagamentos = new List<Pagamento>();
        public bool Pago { get; private set; }

        private double _totalPago = 0;

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pago = false;
        }

        public void AddPagamento(Pagamento pagamento)
        {
            _pagamentos.Add(pagamento);
            _totalPago += pagamento.Valor;
            if (_totalPago >= Valor)
            {
                Pago = true;
            }

        }


    }
}
