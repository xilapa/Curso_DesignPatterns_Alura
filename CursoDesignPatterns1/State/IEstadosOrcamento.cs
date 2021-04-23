namespace CursoDesignPatterns1
{
    public interface IEstadosOrcamento
    {
        void AplicaDescontoExtra(OrcamentoComEstados orcamento);
        void Aprovar(OrcamentoComEstados orcamento);
        void Reprovar(OrcamentoComEstados orcamento);
        void Finalizar(OrcamentoComEstados orcamento);

    }
}
