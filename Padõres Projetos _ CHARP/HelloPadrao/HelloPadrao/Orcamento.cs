using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        private bool JaRecebeuDesconto = false;

        public Orcamento(double valor)
        {
            this.Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            if (JaRecebeuDesconto) return;
            EstadoAtual.AplicaDescontoExtra(this);
            JaRecebeuDesconto = true;
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
