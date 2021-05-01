using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HelloPadroes2.Cap1;
using HelloPadroes2.Cap2;
using HelloPadroes2.Cap3;
using HelloPadroes2.Cap4;
using HelloPadroes2.Cap5;
using HelloPadroes2.Cap6;
using HelloPadroes2.Cap7;
using HelloPadroes2.Cap8;

namespace HelloPadroes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            GeradorDeXml gerador = new GeradorDeXml();
            String xml = gerador.GeraXml(cliente);

            Console.WriteLine(xml);
            Console.ReadKey();
        }
    }
}
