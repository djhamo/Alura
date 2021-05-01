using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloPadroes2.Cap5;

namespace HelloPadroes2.Cap4
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;

        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}
