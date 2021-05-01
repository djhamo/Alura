using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto d3 = new DescontoPorVendaCasada();
            Desconto dfim = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = dfim;
            return d1.Desconta(orcamento);
        }
    }
}
