
namespace CursoDesignPatterns1
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Calcular(Orcamento orcamento);

    }
}
