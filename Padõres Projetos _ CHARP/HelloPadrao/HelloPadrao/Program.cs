using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Orcamento orcamento = new Orcamento(100.0);
            Investimento icms = new ICMS();
            Investimento iss = new ISS();
            Investimento iccc = new ICCC();
            CalculadoraImposto calc = new CalculadoraImposto();

            calc.Calcular(orcamento, icms);
            calc.Calcular(orcamento, iss);

            Orcamento orc1 = new Orcamento(2000.0);
            Orcamento orc2 = new Orcamento(7000.0);

            calc.Calcular(orcamento, iccc);
            calc.Calcular(orc1, iccc);
            calc.Calcular(orc2, iccc);
            */
            /*
            Conta ct1 = new Conta(5000);
            Investimento arrojado = new InvestimentoArrojado();
            Investimento conservador = new InvestimentoConservador();
            Investimento moderado = new InvestimentoModerado();
            RealizadorDeInvestimentos rel = new RealizadorDeInvestimentos();

            rel.ExecutarInvestimento(ref ct1, conservador);
            Console.WriteLine("Saldo Conservador {0}", ct1.Saldo);
            rel.ExecutarInvestimento(ref ct1, moderado);
            Console.WriteLine("Saldo Moderado {0}", ct1.Saldo);
            rel.ExecutarInvestimento(ref ct1, arrojado);
            Console.WriteLine("Saldo Arrojado {0}", ct1.Saldo);

            */
            /*
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orc1 = new Orcamento(2200.0);
            orc1.AdicionaItem(new Item("Geladeira", 500));
            orc1.AdicionaItem(new Item("Televisão", 1200));
            orc1.AdicionaItem(new Item("CANETA", 250.0));
            orc1.AdicionaItem(new Item("LAPIS", 250.0));

            double desconto = calculador.Calcula(orc1);

            Console.WriteLine(desconto);
            */
            /*
            ProcessadorRequisicao fila = new ProcessadorRequisicao();
            Conta c1 = new Conta(1)
            {
                Correntista = "Tiago Fernandes DAgostino",
                Saldo = 500.0
            };
            Requisicao r1 = new Requisicao(Formato.CSV);
            Requisicao r2 = new Requisicao(Formato.PORCENTO);
            Requisicao r3 = new Requisicao(Formato.XML);

            Console.WriteLine("Conta Formato CSV = {0}", fila.Converter(c1, r1));
            Console.WriteLine("Conta Formato PORCENTO = {0}", fila.Converter(c1, r2));
            Console.WriteLine("Conta Formato XML = {0}", fila.Converter(c1, r3));
            */
            /*
            CalculadoraImposto calculador = new CalculadoraImposto();
            Orcamento orc1 = new Orcamento(2225.0);
            orc1.AdicionaItem(new Item("Geladeira", 500));
            orc1.AdicionaItem(new Item("Televisão", 1200));
            orc1.AdicionaItem(new Item("CANETA", 250.0));
            orc1.AdicionaItem(new Item("LAPIS", 250.0));
            orc1.AdicionaItem(new Item("LAPIS", 25.0));

            Imposto icms = new ICMS();
            Imposto iss = new ISS();
            Imposto iccc = new ICCC();
            Imposto icpp = new ICPP();
            Imposto ikcv = new IKCV();
            Imposto ihit = new IHIT();
            CalculadoraImposto calc = new CalculadoraImposto();

            Console.WriteLine("Orçamento Inicial {0}", orc1.Valor);
            calc.Calcular(orc1, icms);
            calc.Calcular(orc1, iss);
            calc.Calcular(orc1, iccc);
            calc.Calcular(orc1, icpp);
            calc.Calcular(orc1, ikcv);
            calc.Calcular(orc1, ihit);
            */
            /*
            IList<Conta> contas = new List<Conta>();
            contas.Add(new Conta(1)
            {
                Correntista = "Tiago Fernandes DAgostino",
                Saldo = 500.0,
                Agencia = 111
            }
            );
            contas.Add(new Conta(2)
            {
                Correntista = "Luciana Satie Oguma",
                Saldo = 1500.0,
                Agencia = 111
            }
            );
            contas.Add(new Conta(3)
            {
                Correntista = "Dominó",
                Saldo = 5000.0,
                Agencia = 112
            }
            );

            RelatorioSimples relat = new RelatorioSimples();
            relat.ImprimeRelatorio(contas);
            Console.WriteLine();
            RelatorioComplexo rela2 = new RelatorioComplexo();
            rela2.ImprimeRelatorio(contas);
            */
            /*
            CalculadoraImposto calculador = new CalculadoraImposto();
            Orcamento orc1 = new Orcamento(2225.0);
            orc1.AdicionaItem(new Item("Geladeira", 500));
            orc1.AdicionaItem(new Item("Televisão", 1200));
            orc1.AdicionaItem(new Item("CANETA", 250.0));
            orc1.AdicionaItem(new Item("LAPIS", 250.0));
            orc1.AdicionaItem(new Item("LAPIS", 25.0));

            Imposto iss = new ISS(new ImpostoMuitoAlto(new IKCV(new ICPP(new ICMS()))));

            Imposto icms = new ICMS();
            Imposto iss2 = new ISS();
            Imposto iccc = new ICCC();
            Imposto icpp = new ICPP();
            Imposto ikcv = new IKCV();
            Imposto ihit = new IHIT();

            Console.WriteLine("ISS + ICMS + Imposto Muito Alto {0}", iss.Calcula(orc1));
            */
            /*
            IList<Conta> contas = new List<Conta>();
            contas.Add(new Conta(1)
            {
                Correntista = "Tiago Fernandes DAgostino",
                Saldo = 50.0,
                Agencia = 111,
                DataAbertura = DateTime.Now
            }
            );
            contas.Add(new Conta(2)
            {
                Correntista = "Luciana Satie Oguma",
                Saldo = 400.0,
                Agencia = 111,
                DataAbertura = DateTime.Now
            }
            );
            contas.Add(new Conta(3)
            {
                Correntista = "Dominó",
                Saldo = 5000.0,
                Agencia = 112,
                DataAbertura = DateTime.Now
            }
            );

            //FiltroSaldoMenor100 f1 = new FiltroSaldoMenor100(new FiltroSaldoMaiorQue500());
            FiltroSaldoMenor100 f1 = new FiltroSaldoMenor100(new FiltroSaldoMaiorQue500(new FiltroContaAbertaMesCorrente()));
            IList<Conta> result = f1.Filtra(contas);

            foreach (var conta in result)
            {
                Console.WriteLine("Conta {0} - Agencia {1} - Correntista {2} - Saldo {3} - DtAbertura {4}", conta.Numero, conta.Agencia, conta.Correntista, conta.Saldo, conta.DataAbertura.ToString());
            }
            */
            /*
            Orcamento reforma = new Orcamento(500.0);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); 
            reforma.Aprova(); 

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); 

            reforma.Finaliza();

            Console.ReadKey();
            reforma.AplicaDescontoExtra();
            Console.ReadKey();
            reforma.Aprova(); 
            */
            /*
            Conta conta = new Conta(1)
            {
                Correntista = "Tiago Fernandes DAgostino",
                Saldo = 50.0,
                Agencia = 111,
                DataAbertura = DateTime.Now
            };

            Console.WriteLine("Conta {0} - Correntista {1} - Saldo {2}", conta.Numero, conta.Correntista, conta.Saldo);
            Console.WriteLine("Depositando 500 em Positivo");
            conta.Deposito(500);
            Console.WriteLine("Conta {0} - Correntista {1} - Saldo {2}", conta.Numero, conta.Correntista, conta.Saldo);
            Console.WriteLine("Saque 700 em Positivo");
            conta.Saque(700);
            Console.WriteLine("Conta {0} - Correntista {1} - Saldo {2}", conta.Numero, conta.Correntista, conta.Saldo);
            Console.WriteLine("Saque 100 em Negativo");
            //conta.Saque(100);
            Console.WriteLine("Conta {0} - Correntista {1} - Saldo {2}", conta.Numero, conta.Correntista, conta.Saldo);
            Console.WriteLine("Deposito 1000 em Negativo");
            conta.Deposito(1000);
            Console.WriteLine("Conta {0} - Correntista {1} - Saldo {2}", conta.Numero, conta.Correntista, conta.Saldo);
            */

            ItemDaNotaBuilder ntcriador = new ItemDaNotaBuilder();
            ntcriador
                .AddNome("item 1")
                .AddValor(100.0);
            ItemDaNota n1 = ntcriador.Construir();
            ntcriador
                .AddNome("item 2")
                .AddValor(200.0);
            ItemDaNota n2 = ntcriador.Construir();
            ntcriador
                .AddNome("item 3")
                .AddValor(300.0);
            ItemDaNota n3 = ntcriador.Construir();
            NotaFiscalBuilder criador = new NotaFiscalBuilder(new List<AcaoAposGerarNota>()
            {
                new EnviadorDeEmail(),
                new EnviadorDeSms(),
                new NotaFiscalDao(),
                new Multiplicador(5.0)
            });

            //criador.AddAcao(new EnviadorDeEmail());
            //criador.AddAcao(new EnviadorDeSms());
            //criador.AddAcao(new NotaFiscalDao());
            //criador.AddAcao(new Multiplicador(5.0));

            criador
                .ParaEmpresa("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .ComItem(n1)
                .ComItem(n2)
                .ComItem(n3)
                .ComObservacoes("entregar nf pessoalmente");

            NotaFiscal nf = criador.Constroi();
            Console.WriteLine("Valor Total {0} - Imposto {1} - Data {2}", nf.ValorBruto, nf.Impostos, nf.DataDeEmissao);
            criador
                .ParaEmpresa("Caelum 2")
                .ComCnpj("123.456.789/0002-12")
                .ComObservacoes("entregar nf pessoalmente longe das cameras")
                .NaData(new DateTime(2017, 02, 21));
            nf = criador.Constroi();

            Console.WriteLine("Valor Total {0} - Imposto {1} - Data {2}", nf.ValorBruto, nf.Impostos, nf.DataDeEmissao);
            Console.ReadKey();
        }
    }
}
