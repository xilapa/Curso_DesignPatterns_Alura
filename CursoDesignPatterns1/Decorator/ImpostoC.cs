
namespace CursoDesignPatterns1
{
    public class ImpostoC : ImpostoDecorator
    {
        public ImpostoC(ImpostoDecorator outroImposto = null) : base(outroImposto) { }

        protected override double calc(double valor)
        {
            return valor * 0.3;
        }
    }
}
