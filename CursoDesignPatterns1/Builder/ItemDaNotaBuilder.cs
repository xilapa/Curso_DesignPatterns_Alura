
namespace CursoDesignPatterns1.Builder
{
    public class ItemDaNotaBuilder
    {
        private string nome;
        private decimal valor;

        public ItemDaNotaBuilder ComNome(string nome)
        {
            this.nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(decimal valor)
        {
            this.valor = valor;
            return this;
        }

        public ItemDaNota Build()
        {
            return new ItemDaNota(nome, valor);
        }
    }
}
