﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public interface ITabelaDePrecos
    {
        double DescontoPara(double valor);
    }

    public class TabelaDePrecoPadrao : ITabelaDePrecos
    {
        public double DescontoPara(double valor)
        {
            if (valor > 5000) return 0.03;
            if (valor > 1000) return 0.05;
            return 0;
        }
    }
}