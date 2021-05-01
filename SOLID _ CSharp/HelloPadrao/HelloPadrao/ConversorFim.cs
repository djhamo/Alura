using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class ConversorFim : Conversor
    {
        public Conversor Proximo { get; set; }

        public string Converter(Conta conta, Requisicao requisicao)
        {
            return "";
        }
    }
}
