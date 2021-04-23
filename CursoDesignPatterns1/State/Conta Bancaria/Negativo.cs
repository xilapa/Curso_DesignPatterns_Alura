using System;

namespace CursoDesignPatterns1
{
    public class Negativo : EstadoContaBancaria
    {
        public void Depositar(ContaBancariaComEstados contaBancaria, double valor)
        {
            contaBancaria.Saldo += valor * 0.95;
            if (contaBancaria.Saldo >= 0)
                contaBancaria.EstadoAtual = new Positivo();
        }

        public void Sacar(ContaBancariaComEstados contaBancaria, double valor)
        {
            throw new Exception("Não é possível sacar com conta negativa");
        }
    }
}