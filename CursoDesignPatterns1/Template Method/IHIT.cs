using System.Linq;

namespace CursoDesignPatterns1
{
    public class IHIT : TemplateImposto
    {
        public override double TaxacaoMaxima(Orcamento orcamento)
        {
            return ((orcamento.Valor * 0.13) + 100);
        }

        public override double TaxacaoMinima(Orcamento orcamento)
        {
            return ((orcamento.Valor * 0.01) * orcamento.Itens.Count);
        }

        public override bool UsarTaxacaoMaxima(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                var qtd = orcamento.Itens.Where(i => i.Nome == item.Nome).ToList().Count;
                if (qtd > 1)
                    return true;
            }
            return false;
        }
    }
}
