using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class ICCC : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            
            if (orcamento.Valor < 1000.0)
            {
                return orcamento.Valor * 0.05;
            }

            if (orcamento.Valor > 3000.0)
            {
                return (orcamento.Valor * 0.08) + 30.0;
            }

            return orcamento.Valor * 0.07;
        }
    }
}
