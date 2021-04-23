namespace CursoDesignPatterns1
{
    public interface EstadoContaBancaria
    {
        void Sacar(ContaBancariaComEstados contaBancaria, double valor);
        void Depositar(ContaBancariaComEstados contaBancaria, double valor);

    }
}