
namespace CursoDesignPatterns1
{
    public class ICPP : TemplateImposto
    {
        public ICPP(TemplateImposto outroImposto = null) : base(outroImposto) { }

        public override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        public override bool UsarTaxacaoMaxima(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
