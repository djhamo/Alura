using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public abstract class Filtro
    {
        public abstract IList<Conta> Filtra(IList<Conta> contas);
        public Filtro OutroFiltro { get; set; }
        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }
        public Filtro()
        {
            this.OutroFiltro = null;
        }

        protected IList<Conta> FiltraOutroFiltro(IList<Conta> contas)
        {
            if (OutroFiltro == null) return new List<Conta>();
            return OutroFiltro.Filtra(contas);
        }
    }
}
