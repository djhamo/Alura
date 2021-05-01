using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public class ProcessadorDeInvestimentos
    {

        public void Processa()
        {
            IList<IConta> contas = ContasDoBanco();

            foreach (IConta conta in contas)
            {
                conta.somaInvestimento();

                Console.WriteLine("Novo saldo: " + conta.Saldo.Saldo);
            }

            Console.ReadLine();
        }

        private static IList<IConta> ContasDoBanco()
        {
            List<IConta> contas = new List<IConta>();
            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaEstudante(100));
            return contas;
        }

        private static ContaEstudante umaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum umaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }
    }
}
