using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    class Moderado : IInvestimento
    {
        public readonly string tipo = "MODERADO";
        private readonly bool sorte = new Random().Next(101) > 50; 

        public string Tipo { get => tipo; }

        public double Investir(ContaBancaria contaBancaria)
        {
            if (sorte) return contaBancaria.Saldo * 0.025;
            return contaBancaria.Saldo * 0.007;
        }
    }
}
