using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + CalculoDoOutroImposto(orcamento);
        }
    }
}
