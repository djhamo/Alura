using EntityHello.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHello
{
    class UsuarioDAO
    {
        private EntidadesContexto contexto;

        public UsuarioDAO()
        {
            contexto = new EntidadesContexto();
        }

        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        internal void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.ID == id);
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }
    }
}
