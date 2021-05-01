﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadroes2.Cap7
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pagando Pedido {0}", pedido.Cliente);
            pedido.Paga();
        }
    }
}
