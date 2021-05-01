namespace HelloPadrao
{
    public class ItemDaNotaBuilder
    {
        private string _nome;
        private double _valor;

        public ItemDaNotaBuilder AddNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public ItemDaNotaBuilder AddValor(double valor)
        {
            _valor = valor;
            return this;
        }

        public ItemDaNota Construir()
        {
            return new ItemDaNota(_nome, _valor);
        }
    }
}
