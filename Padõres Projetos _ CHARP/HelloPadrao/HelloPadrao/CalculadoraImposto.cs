using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class CalculadoraImposto
    {
        public void Calcular(Orcamento orcamento, Imposto imposto)
        {
            Console.WriteLine("Orçamento {0}, Imposto {1}", orcamento.Valor, imposto.Calcula(orcamento));
        }
    }
}
