
namespace CursoDesignPatterns1
{
    public class ImpostoMuitoAlto : ImpostoDecorator
    {
        public ImpostoMuitoAlto(ImpostoDecorator outroImposto = null) : base(outroImposto) { }

        protected override double calc(double valor)
        {
            return valor * 0.6;
        }
    }
}
