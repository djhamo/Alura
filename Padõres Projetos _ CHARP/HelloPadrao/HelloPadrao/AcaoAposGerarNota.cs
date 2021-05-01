using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public interface AcaoAposGerarNota
    {
        void Executa(NotaFiscal notafiscal);
    }

    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando por e-mail");
        }
    }

    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("salvando no banco");
        }
    }

    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando por sms");
        }
    }

    public class Impressora : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("imprimindo notaFiscal");
        }
    }

    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal notafiscal)
        {
            Console.WriteLine("Valor pelo Fator {0}", notafiscal.ValorBruto * Fator);
        }
    }
}
