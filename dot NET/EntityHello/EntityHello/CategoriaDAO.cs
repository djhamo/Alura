using EntityHello.Entidades;
using Microsoft.Data.Entity;
using System.Linq;

namespace EntityHello
{
    class CategoriaDAO
    {
        private EntidadesContexto contexto;

        public CategoriaDAO()
        {
            contexto = new EntidadesContexto();
        }

        public void Salva(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        internal void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public Categoria BuscaPorId(int id)
        {
            return contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.ID == id);
        }

        public void Remove(Categoria categoria)
        {
            contexto.Categorias.Remove(categoria);
            contexto.SaveChanges();
        }
    }
}
