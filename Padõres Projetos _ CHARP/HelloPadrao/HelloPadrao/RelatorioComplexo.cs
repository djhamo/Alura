using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override void ImprimeCabecalho()
        {
            Console.WriteLine("Banco XPTO - Rua Saturnino de Brito, 74 - Jardim Botânico - RJ - CEP 22470 - (21) 2345-1662");
        }

        protected override void ImprimeDetalhe(Conta conta)
        {
            Console.WriteLine("Titular {0} - Agência {1} - Conta {2} - Saldo {3}", conta.Correntista, conta.Agencia, conta.Numero, conta.Saldo);
        }

        protected override void ImprimeRodape()
        {
            Console.WriteLine("bancoxpto@xpto.com.br - {0}", DateTime.Now.ToString());
        }
    }
}
