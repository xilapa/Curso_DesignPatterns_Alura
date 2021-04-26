using System.Collections.Generic;

namespace CursoDesignPatterns1
{
    public class CriaNotaFiscalComObserver
    {
        private List<AcaoAposCriacaoNF> acoesPosCriacao = new List<AcaoAposCriacaoNF>();

        public void AdicionarAcoes(AcaoAposCriacaoNF acao)
        {
            acoesPosCriacao.Add(acao);
        }

        public NotaFiscal Criar(string empresa, string cnpj, decimal valor)
        {
            var nf = new NotaFiscal(empresa, cnpj, valor);

            foreach (var acao in acoesPosCriacao)
            {
                acao.Faz(nf);
            }

            return nf;
        }

    }
}
