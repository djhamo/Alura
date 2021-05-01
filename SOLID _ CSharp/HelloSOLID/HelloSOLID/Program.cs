using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CalculadoraDeSalario calc = new CalculadoraDeSalario();
            Funcionario func = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000.0);
            Funcionario func2 = new Funcionario(new Dba(new QuinzeOuVinteCincoPorcento()), 1800.0);

            Console.WriteLine("Sálario Desenvolvedor R$ {0}", calc.Calcula(func));
            Console.WriteLine("Sálario DBA R$ {0}", calc.Calcula(func2));
            */
            /*
            Fatura fat1 = new Fatura(1000.0, "Os Amarelinhos");
            NotaFiscal nf1 = new GeradorDeNotaFiscal(new EnviadorDeEmail(new NotaFiscalDao())).Gera(fat1);
            Console.WriteLine("Nota Fiscal {0} - {1} - {2}", nf1.Impostos, nf1.ValorBruto, nf1.ValorLiquido);
            */
            /*
            Compra c1 = new Compra()
            {
                Cidade = "Sao Paulo",
                Cliente = "Os Amarelinhos",
                Produto = "Ração para Cachorro Keldog",
                Valor = 150.0
            };
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Frete());
            Console.WriteLine("Preço {0} - Produto {1} - Cidade {2}", calc.Calcula(c1), c1.Produto, c1.Cidade);
            */
            /*
            IList<Boleto> boletos = new List<Boleto>();
            boletos.Add(new Boleto(250.0));
            boletos.Add(new Boleto(500.0));
            boletos.Add(new Boleto(250.0));
            Fatura fatura = new Fatura("Os Amarelinhos", 1000.0);

            Console.WriteLine("Fatura {0} Paga {1} ?", fatura.Cliente, fatura.Pago);
            ProcessadorDeBoletos proc1 = new ProcessadorDeBoletos();
            proc1.Processa(boletos, fatura);
            Console.WriteLine("Fatura {0} Paga {1} ?", fatura.Cliente, fatura.Pago);
            */
            ProcessadorDeInvestimentos proc1 = new ProcessadorDeInvestimentos();
            proc1.Processa();
            Console.ReadKey();
        }
    }
}
