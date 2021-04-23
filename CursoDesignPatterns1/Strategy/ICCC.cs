using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    public class ICCC : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            double imposto;
            switch (orcamento.Valor)
            {
                case var valor when valor< 1000:
                    imposto = orcamento.Valor * 0.05;
                    break;
                case var valor when valor <= 3000:
                    imposto = orcamento.Valor * 0.07;
                    break;
                default:
                    imposto = (orcamento.Valor * 0.08) + 30;
                    break;
                    
            }
            return imposto;
        }
    }
}
