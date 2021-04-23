using System;

namespace CursoDesignPatterns1
{
    public class EmAprovacao : IEstadosOrcamento
    {
        private bool descontoAplicadoNestaEtapa = false;
        public void AplicaDescontoExtra(OrcamentoComEstados orcamento)
        {
            if (!descontoAplicadoNestaEtapa)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoAplicadoNestaEtapa = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado neste orçamento");
            }

        }

        public void Aprovar(OrcamentoComEstados orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finalizar(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orcamento em aprovação não pode ser finalizado");
        }

        public void Reprovar(OrcamentoComEstados orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
