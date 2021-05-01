using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class ConversorXML : Conversor
    {
        public Conversor Proximo { get; set; }

        public string Converter(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato.Equals(Formato.XML))
            {
                string result = String.Format("<Numero>{0}</Numero><Correntista>{1}</Correntista><Saldo>{2}</Saldo>", conta.Numero, conta.Correntista, conta.Saldo);
                return result;
            }
            return Proximo.Converter(conta, requisicao);
        }
    }
}
