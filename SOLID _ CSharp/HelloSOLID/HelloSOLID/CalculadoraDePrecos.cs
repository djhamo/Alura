using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePrecos _tabela;
        private IFrete _frete;

        public CalculadoraDePrecos(ITabelaDePrecos tabela, IFrete frete)
        {
            _tabela = tabela;
            _frete = frete;
        }
        public double Calcula(Compra produto)
        {

            double desconto = _tabela.DescontoPara(produto.Valor);
            double frete = _frete.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
