using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloPadroes2.Cap4;

namespace HelloPadroes2.Cap5
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeMultiplicacao(Multiplicacao soma);
        void ImprimeDivisao(Divisao soma);
        void ImprimeNumero(Numero numero);
        
    }
}
