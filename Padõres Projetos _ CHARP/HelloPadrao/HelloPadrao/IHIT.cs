using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            for(int i = 0; i < orcamento.Itens.Count; i++)
            {
                string itentest = orcamento.Itens[i].Nome;
                for (int j = (i + 1); j < orcamento.Itens.Count; j++)
                {
                    if (itentest.Equals(orcamento.Itens[j].Nome))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
