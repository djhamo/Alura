using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class ConversorCSV : Conversor
    {
        public Conversor Proximo { get; set; }
        public string Converter(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato.Equals(Formato.CSV)) { 
                string result = String.Format("Numero;{0};Correntista;{1};Saldo;{2};", conta.Numero, conta.Correntista, conta.Saldo);
                return result;
            }
            return Proximo.Converter(conta, requisicao);
        }
    }
}
