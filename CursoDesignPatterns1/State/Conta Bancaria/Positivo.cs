namespace CursoDesignPatterns1
{
    public class Positivo : EstadoContaBancaria
    {
        public void Depositar(ContaBancariaComEstados contaBancaria, double valor)
        {
            contaBancaria.Saldo += 0.98 * valor;
        }

        public void Sacar(ContaBancariaComEstados contaBancaria, double valor)
        {
            contaBancaria.Saldo -= valor;
            if (contaBancaria.Saldo < 0)
                contaBancaria.EstadoAtual = new Negativo();
        }
    }
}