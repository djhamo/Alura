using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadroes2.Cap3
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }

}
