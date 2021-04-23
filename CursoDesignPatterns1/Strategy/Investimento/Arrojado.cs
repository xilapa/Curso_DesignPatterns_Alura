using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    class Arrojado : IInvestimento
    {
        private readonly string tipo = "ARROJADO";
        public string Tipo { get => tipo; }
        private readonly int chance = new Random().Next(101);
        private double retorno;

        public double Investir(ContaBancaria contaBancaria)
        {
            switch (chance)
            {
                case var c when c <= 20:
                    retorno = contaBancaria.Saldo * 0.05;
                    break;
                case var c when c <= 30:
                    retorno = contaBancaria.Saldo * 0.03;
                    break;
                default:
                    retorno = contaBancaria.Saldo * 0.006;
                    break;
            }

            return retorno;
        }    
    }
}
