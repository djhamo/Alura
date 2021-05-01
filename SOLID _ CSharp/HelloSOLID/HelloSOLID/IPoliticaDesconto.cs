using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public interface IPoliticaDesconto
    {
        double Calcula(Funcionario funcionario);
    }

    public class DezOuVintePorcento : IPoliticaDesconto
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.8;
            }
            else
            {
                return funcionario.SalarioBase * 0.9;
            }
        }

    }

    public class QuinzeOuVinteCincoPorcento : IPoliticaDesconto
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 2000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }
            else
            {
                return funcionario.SalarioBase * 0.85;
            }
        }

    }


}
