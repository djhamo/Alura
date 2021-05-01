using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class InvestimentoModerado : Investimento
    {
        public double CalculaRetorno(double valor)
        {
            bool escolhido = new Random().Next(101) > 50;

            if (escolhido)
            {
                return valor * 0.025;
            }
            else
            {
                return valor * 0.007;
            }
            
        }
    }
}
