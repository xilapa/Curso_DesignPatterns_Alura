
namespace CursoDesignPatterns1
{
    public class OrcamentoComEstados 
    {
        public IEstadosOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }
        public OrcamentoComEstados(double valor)
        {
            EstadoAtual = new EmAprovacao();
            Valor = valor;
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprovar()
        {
            EstadoAtual.Aprovar(this);
        }

        public void Reprovar()
        {
            EstadoAtual.Reprovar(this);
        }

        public void Finalizar()
        {
            EstadoAtual.Finalizar(this);
        }
    }
}
