
namespace CursoDesignPatterns1
{
    public class ImpostoA : ImpostoDecorator
    {
        public ImpostoA(ImpostoDecorator outroImposto = null) : base (outroImposto) { }
        protected override double calc(double valor)
        {
            return valor * 0.1;
        }
    }
}
