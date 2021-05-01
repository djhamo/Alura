using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class ProcessadorRequisicao
    {
        public string Converter(Conta conta, Requisicao requisicao)
        {
            Conversor c1 = new ConversorCSV();
            Conversor c2 = new ConversorPorCento();
            Conversor c3 = new ConversorXML();
            Conversor cfim = new ConversorFim();

            c1.Proximo = c2;
            c2.Proximo = c3;
            c3.Proximo = cfim;
            return c1.Converter(conta, requisicao);
        }
    }
}
