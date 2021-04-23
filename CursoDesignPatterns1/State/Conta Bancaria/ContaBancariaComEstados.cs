
namespace CursoDesignPatterns1
{
    public class ContaBancariaComEstados
    {
        public double Saldo { get; set; }

        public EstadoContaBancaria EstadoAtual { get; set; }

        public ContaBancariaComEstados()
        {
            Saldo = 0;
            EstadoAtual = new Positivo();
        }

        public void Sacar(double valor)
        {
            EstadoAtual.Sacar(this, valor);
        }


        public void Depositar(double valor)
        {
            EstadoAtual.Depositar(this, valor);
        }
    }
}
