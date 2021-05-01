using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class RealizadorDeInvestimentos
    {
        public void ExecutarInvestimento(ref Conta conta, Investimento investimento)
        {
            double lucro = investimento.CalculaRetorno(conta.Saldo);
            conta.Saldo += lucro * 0.75;
        }
    }
}
