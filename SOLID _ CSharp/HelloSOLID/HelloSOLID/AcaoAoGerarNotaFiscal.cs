using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public abstract class AcaoAoGerarNotaFiscal
    {
        protected AcaoAoGerarNotaFiscal ProximaAcao { get; private set; }

        public AcaoAoGerarNotaFiscal()
        {
            ProximaAcao = null;
        }

        public AcaoAoGerarNotaFiscal(AcaoAoGerarNotaFiscal proximo)
        {
            ProximaAcao = proximo;
        }

        public void Executa(NotaFiscal nf)
        {
            Acao(nf);
            ProximaAcao?.Acao(nf);
        }
        protected abstract void Acao(NotaFiscal nf);
    }

    public class EnviadorDeEmail : AcaoAoGerarNotaFiscal
    {
        public EnviadorDeEmail()
        {
        }

        public EnviadorDeEmail(AcaoAoGerarNotaFiscal proximo) : base(proximo)
        {
        }

        protected override void Acao(NotaFiscal nf)
        {
            Console.WriteLine("Enviando email");
        }
    }

    public class NotaFiscalDao : AcaoAoGerarNotaFiscal
    {
        public NotaFiscalDao()
        {
        }

        public NotaFiscalDao(AcaoAoGerarNotaFiscal proximo) : base(proximo)
        {
        }

        protected override void Acao(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo nota");
        }
    }
}
