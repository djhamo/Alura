using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPadrao
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public String Observacoes { get; private set; }


        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();

        public NotaFiscalBuilder()
        {
            this.Data = DateTime.Now;
        }
        public NotaFiscalBuilder(IList<AcaoAposGerarNota> todasAcoesASeremExecutadas)
        {
            this.Data = DateTime.Now;
            this.todasAcoesASeremExecutadas = todasAcoesASeremExecutadas;
        }
        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);
            foreach (var acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);    
            }
            return nf;
        }

        public void AddAcao(AcaoAposGerarNota acao)
        {
            todasAcoesASeremExecutadas.Add(acao);
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            this.Data = data;
            return this;
        }
    }
}
