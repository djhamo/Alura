using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class FiltroSaldoMenor100 : TemplateFiltro
    {
        public FiltroSaldoMenor100(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        protected override bool ContaCorresponde(Conta conta)
        {
            return conta.Saldo < 100;
        }
    }
}
