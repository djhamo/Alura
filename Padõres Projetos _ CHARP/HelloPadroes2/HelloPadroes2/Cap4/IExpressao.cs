using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloPadroes2.Cap5;

namespace HelloPadroes2.Cap4
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
