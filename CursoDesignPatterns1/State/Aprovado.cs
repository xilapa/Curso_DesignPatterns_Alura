using System;

namespace CursoDesignPatterns1
{
    public class Aprovado : IEstadosOrcamento
    {
        private bool descontoAplicadoNestaEtapa = false;
        public void AplicaDescontoExtra(OrcamentoComEstados orcamento)
        {
            if (!descontoAplicadoNestaEtapa)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicadoNestaEtapa = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado neste orçamento");
            }

        }

        public void Aprovar(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento já foi aprovado");
        }

        public void Finalizar(OrcamentoComEstados orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprovar(OrcamentoComEstados orcamento)
        {
            throw new Exception("Orçamento já foi aprovado, não pode ser reprovado");
        }
    }
}