using MyEntityTest.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            myDBContext dbc = new myDBContext();
            foreach (var item in dbc.People)
            {
                Console.WriteLine("Name {0}, Idade {1}, Email {2}, CPF {3}, Telefone {4}", item.Name, item.Age, item.Email, item.Cpf, item.Telefone);
            }
            string ans = "n";
            do
            {
                Person newperson = new Person();
                string temp = "";
                int age = 0;

                Console.WriteLine("Digite o Nome ");
                newperson.Name = Console.ReadLine();

                Console.WriteLine("Digite o Emal ");
                newperson.Email = Console.ReadLine();

                Console.WriteLine("Digite o Telefone ");
                newperson.Telefone = Console.ReadLine();

                Console.WriteLine("Digite o CPF ");
                newperson.Cpf = Console.ReadLine();
                do
                {
                    Console.WriteLine("Entre com a Idade");
                    temp = Console.ReadLine();
                }
                while (!(int.TryParse(temp, out age) && age > 0));

                temp = null;

                newperson.Age = age;

                dbc.People.Add(newperson);

                Console.Write("Quer Cadastrar mais Pessoas ?");
                ans = Console.ReadLine();
            } while (ans.Equals("s", StringComparison.CurrentCultureIgnoreCase));
            dbc.SaveChanges();
        }
    }
}
