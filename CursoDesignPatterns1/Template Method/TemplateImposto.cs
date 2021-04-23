
namespace CursoDesignPatterns1
{
    public abstract class TemplateImposto : IImposto
    {
        private TemplateImposto OutroImposto { get; set; }

        public TemplateImposto(TemplateImposto outroImposto =  null)
        {
            OutroImposto = outroImposto;
        }
        public double Calcular(Orcamento orcamento)
        {
            if(UsarTaxacaoMaxima(orcamento))
            {
                return TaxacaoMaxima(orcamento) + CalcularOutroImposto(orcamento);
            }
            else
            {
                return TaxacaoMinima(orcamento) + CalcularOutroImposto(orcamento);
            }
        }

        //decorado
        private double CalcularOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto != null)
                return OutroImposto.Calcular(orcamento);
            else
                return 0;
        }

        public abstract double TaxacaoMinima(Orcamento orcamento);

        public abstract double TaxacaoMaxima(Orcamento orcamento);

        public abstract bool UsarTaxacaoMaxima(Orcamento orcamento);
    }
}
