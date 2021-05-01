using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public interface Conversor
    {
        Conversor Proximo { get; set; }
        string Converter(Conta conta, Requisicao requisicao);
    }
}
