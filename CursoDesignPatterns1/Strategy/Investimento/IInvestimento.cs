namespace CursoDesignPatterns1
{
    public interface IInvestimento
    {
        string Tipo { get; }
        double Investir(ContaBancaria contaBancaria);
    }
}