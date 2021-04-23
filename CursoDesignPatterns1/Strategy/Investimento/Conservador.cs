using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    class Conservador : IInvestimento
    {
        readonly string tipo = "CONSERVADOR";
        public string Tipo
        {
            get
            {
                return tipo;
            }
        }

        public double Investir(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * 0.008;
        }
    }
}
