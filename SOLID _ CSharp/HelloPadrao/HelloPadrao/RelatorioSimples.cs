using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void ImprimeCabecalho()
        {
            Console.WriteLine("Banco XPTO");
            Console.WriteLine("Relatório:");
        }

        protected override void ImprimeDetalhe(Conta conta)
        {
            Console.WriteLine("Titular {0} e Saldo {1}", conta.Correntista, conta.Saldo);
        }

        protected override void ImprimeRodape()
        {
            Console.WriteLine("Tel (11) 2345-6166");
        }
    }
}
