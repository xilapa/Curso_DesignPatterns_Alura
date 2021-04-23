using System;

namespace CursoDesignPatterns1
{
    public class Finalizado : IEstadosOrcamento
    {
        public void AplicaDescontoExtra(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento finalizado não se aplica desconto");
        }

        public void Aprovar(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento já finalizado, não é possível aprovar");
        }

        public void Finalizar(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento já foi finalizado");
        }

        public void Reprovar(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento já finalizado, não é possível reprovar");
        }
    }
}