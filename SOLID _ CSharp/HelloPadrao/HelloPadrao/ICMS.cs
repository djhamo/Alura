using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class ICMS : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50.0;
        }
    }
}
