using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class InvestimentoConservador : Investimento
    {
        public double CalculaRetorno(double valor)
        {
            return valor * 0.008;
        }
    }
}
