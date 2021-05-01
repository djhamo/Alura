using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public interface EstadoDeUmOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);

        
    }

    class EmAprovacao : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }
        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
        }
    }
    class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
    class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de reprovação e não pode ser aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de reprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
    class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está finalizado e não pode ser aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está finalizado e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
    }
}
