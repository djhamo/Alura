using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSOLID
{
    public interface IFrete
    {
        double Para(string cidade);
    }

    class Frete : IFrete
    {
        public double Para(string cidade)
        {

            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}
