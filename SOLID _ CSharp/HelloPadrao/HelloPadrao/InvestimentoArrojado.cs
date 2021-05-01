using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class InvestimentoArrojado : Investimento
    {

        public double CalculaRetorno(double valor)
        {
            int escolhido = new Random().Next(101);

            if (escolhido < 20)
            {
                return valor * 0.05;
            }
            else if (escolhido >= 20 && escolhido <= 30)
            {
                return valor * 0.03;
            }
            else 
            {
                return valor * 0.006;
            }
        }
    }
}
