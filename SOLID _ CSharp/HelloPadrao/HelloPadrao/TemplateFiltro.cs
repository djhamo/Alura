using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public abstract class TemplateFiltro : Filtro
    {
        public TemplateFiltro() : base() {}

        public TemplateFiltro(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {

            IList<Conta> result = new List<Conta>();
            foreach (var conta in contas)
            {
                if (ContaCorresponde(conta))
                {
                    result.Add(conta);
                }
            }
            IList<Conta> process = FiltraOutroFiltro(contas);
            return result.Union(process).ToList(); ;
        }

        protected abstract bool ContaCorresponde(Conta conta);

    }
}
