
namespace CursoDesignPatterns1
{
    public class ImpostoB : ImpostoDecorator
    {
        public ImpostoB(ImpostoDecorator outroImposto = null) : base (outroImposto) { }
        protected override double calc(double valor)
        {
            return valor * 0.2;
        }
    }
}
