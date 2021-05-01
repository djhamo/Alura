using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class FiltroSaldoMaiorQue500 : TemplateFiltro
    {
        public FiltroSaldoMaiorQue500()
        {
        }

        public FiltroSaldoMaiorQue500(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        protected override bool ContaCorresponde(Conta conta)
        {
            return conta.Saldo > 500;
        }
    }
}
