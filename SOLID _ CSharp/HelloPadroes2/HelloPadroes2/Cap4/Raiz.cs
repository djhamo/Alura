using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloPadroes2.Cap5;

namespace HelloPadroes2.Cap4
{
    public class Raiz : IExpressao
    {
        public IExpressao Expressao { get; private set; }

        public Raiz(IExpressao expressao)
        {
            this.Expressao = expressao;
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Expressao.Avalia();
            return (int) Math.Sqrt(resultadoDaEsquerda);           
        }

        public void Aceita(IVisitor impressora)
        {
            throw new NotImplementedException();
        }
    }
}
