using EntityHello.Entidades;
using Microsoft.Data.Entity;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EntityHello
{
    class ProdutoDAO
    {
        private EntidadesContexto contexto;

        public ProdutoDAO(EntidadesContexto contexto)
        {
            this.contexto = contexto;
        }

        public void Salva(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        internal void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public Produto BuscaPorId(int id)
        {
            return contexto.Produtos.Include(produto => produto.Categoria).FirstOrDefault(produto => produto.ID == id);
        }

        public void Remove(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();
        }

        public IList<Produto> BuscaPorNomePrecoNomeCategoria(string nome, decimal preco, string nomeCategoria)
        {
            var busca = from p in contexto.Produtos select p;

            if (!System.String.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p => p.Nome == nome);
            }

            if (preco > 0.0m)
            {
                busca = busca.Where(p => p.Preco == preco);
            }

            if (!System.String.IsNullOrEmpty(nomeCategoria))
            {
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
            }
            return busca.ToList();
        }
    }
}
