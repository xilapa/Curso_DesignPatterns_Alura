
namespace CursoDesignPatterns1
{
    public class IKCV : TemplateImposto
    {
        //decorado
        public IKCV(TemplateImposto outroImposto = null) : base (outroImposto) { }

        public override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        public override bool UsarTaxacaoMaxima(Orcamento orcamento)
        {
            if(orcamento.Valor > 500 && TemItemMaiorQue100Reais(orcamento))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TemItemMaiorQue100Reais(Orcamento orcamento)
        {
            foreach(var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
