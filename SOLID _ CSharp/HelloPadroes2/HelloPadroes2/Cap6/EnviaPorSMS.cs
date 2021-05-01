using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadroes2.Cap6
{
    public class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
