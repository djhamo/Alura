using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public class Funcionario
    {
        public Cargo Cargo { get; private set; }

        public double SalarioBase { get; private set; }

        public Funcionario(Cargo cargo, double salarioBase)
        {
            this.Cargo = cargo;
            this.SalarioBase = salarioBase;
        }

        public double CalculaSalario()
        {
            return Cargo.Desconto.Calcula(this);
        }

    }

}
