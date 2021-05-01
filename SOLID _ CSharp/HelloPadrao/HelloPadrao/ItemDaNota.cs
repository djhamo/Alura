using System;

namespace HelloPadrao
{
    public class ItemDaNota
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(string nome, double valor)
        {
            if (nome == null) throw new ArgumentNullException(nameof(nome));
            Nome = nome;
            Valor = valor;
        }
    }
}