
namespace CursoDesignPatterns1
{ 
    public abstract class ImpostoDecorator
    {
        private ImpostoDecorator OutroImposto { get; set; }
        public ImpostoDecorator(ImpostoDecorator outroImposto = null)
        {
            OutroImposto = outroImposto;
        }

        protected abstract double calc(double valor);

        public double Calcular(double valor)
        {
            if (OutroImposto != null)
                return calc(valor) + OutroImposto.Calcular(valor);
            else
                return calc(valor);
        }
    }
}
