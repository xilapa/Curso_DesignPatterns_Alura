
namespace CursoDesignPatterns1
{
    public class ItemDaNota
    {
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        public ItemDaNota(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
