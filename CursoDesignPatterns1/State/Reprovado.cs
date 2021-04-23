using System;

namespace CursoDesignPatterns1
{
    public class Reprovado : IEstadosOrcamento
    {
        public void AplicaDescontoExtra(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento reprovado não se aplica desconto");
        }

        public void Aprovar(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento já reprovado, não é possível aprovar");
        }

        public void Finalizar(OrcamentoComEstados orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprovar(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento já foi reprovado");
        }
    }
}