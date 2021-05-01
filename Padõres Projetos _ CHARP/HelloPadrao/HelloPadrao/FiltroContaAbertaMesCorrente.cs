using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class FiltroContaAbertaMesCorrente : TemplateFiltro
    {
        public FiltroContaAbertaMesCorrente()
        {
        }

        public FiltroContaAbertaMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        protected override bool ContaCorresponde(Conta conta)
        {
            return conta.DataAbertura.Month == DateTime.Now.Month; 

        }
    }
}
