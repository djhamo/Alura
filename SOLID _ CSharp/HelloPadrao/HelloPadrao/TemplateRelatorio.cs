using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public abstract class TemplateRelatorio
    {

        public void ImprimeRelatorio(IList<Conta> contas)
        {
            ImprimeCabecalho();
            Console.WriteLine();
            foreach (var conta in contas)
            {
                ImprimeDetalhe(conta);
            }
            Console.WriteLine();
            ImprimeRodape();
        }

        protected abstract void ImprimeDetalhe(Conta conta);
        protected abstract void ImprimeRodape();
        protected abstract void ImprimeCabecalho();
    }
}
