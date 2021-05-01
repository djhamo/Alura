using System.Collections.Generic;
namespace Caelum.Leilao
{

    public class Leilao
    {

        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string descricao)
        {
            this.Descricao = descricao;
            this.Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            if (Lances.Count == 0 || podeDarLance(lance.Usuario))
            {
                Lances.Add(lance);
            }
        }

        private bool podeDarLance(Usuario usuario)
        {
            return !ultimoLanceDado().Usuario.Equals(usuario)
                && qtdDelancesDo(usuario) < 5;
        }

        private int qtdDelancesDo(Usuario usuario)
        {
            int total = 0;
            foreach (Lance lance in Lances)
            {
                if (lance.Usuario.Equals(usuario)) total++;
            }
            return total;
        }

        private Lance ultimoLanceDado()
        {
            return Lances[Lances.Count - 1];
        }

        public void DobraLance(Usuario usuario)
        {
            Lance ultimoLanceUsuario = UltimoLance(usuario);
            if (ultimoLanceUsuario != null)
                Propoe(ultimoLanceUsuario);
        }

        public Lance UltimoLance(Usuario usuario)
        {
            Lance ultimoLanceUsuario = null;
            foreach (var lance in Lances)
            {
                if (lance.Usuario.Equals(usuario))
                {
                    ultimoLanceUsuario = new Lance(usuario, (lance.Valor * 2));
                }
            }
            return ultimoLanceUsuario;
        }
    }
}