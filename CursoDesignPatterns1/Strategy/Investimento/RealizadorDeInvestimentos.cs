using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    class RealizadorDeInvestimentos
    {
        public void Investir(ContaBancaria contaBancaria, IInvestimento investimento)
        {
            var retornoBruto = investimento.Investir(contaBancaria);
            contaBancaria.Saldo += contaBancaria.Saldo + 0.75 * retornoBruto;
            Console.WriteLine($"Investimento {investimento.Tipo} teve um retorno bruto de {retornoBruto}");
        }
    }
}
