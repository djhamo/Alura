using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public abstract class Cargo
    {
        public IPoliticaDesconto Desconto { get; private set; }

        protected Cargo(IPoliticaDesconto desconto)
        {
            this.Desconto = desconto;
        }
    }

    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(DezOuVintePorcento desconto) : base(desconto)
        {
        }
    }

    public class Dba : Cargo
    {
        public Dba(QuinzeOuVinteCincoPorcento desconto) : base(desconto)
        {
        }
    }

    public class Tester : Cargo
    {
        public Tester(QuinzeOuVinteCincoPorcento desconto) : base(desconto)
        {
        }
    }
}
