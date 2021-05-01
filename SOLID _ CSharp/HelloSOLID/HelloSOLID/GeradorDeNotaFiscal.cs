using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public class GeradorDeNotaFiscal
    {
        private readonly AcaoAoGerarNotaFiscal Acao;

        public GeradorDeNotaFiscal(AcaoAoGerarNotaFiscal acao)
        {
            Acao = acao;
        }

        public NotaFiscal Gera(Fatura fatura)
        {

            double valor = fatura.Valor;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));

            Acao?.Executa(nf);

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }
}
