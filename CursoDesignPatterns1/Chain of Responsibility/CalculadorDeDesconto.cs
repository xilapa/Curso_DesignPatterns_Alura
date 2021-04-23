
namespace CursoDesignPatterns1
{
    public class CalculadorDeDesconto
    {
        public double Calcular(Orcamento orcamento)
        {
            var d1 = new DescontoPorCincoItens();
            var d2 = new DescontoPorMaisDeQuinentosReais();
            var d3 = new DescontoPorVendaCasada();
            var d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            

            return d1.Calcular(orcamento);
        }
    }
}
