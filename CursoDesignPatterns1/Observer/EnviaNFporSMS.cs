using System;

namespace CursoDesignPatterns1
{
    public class EnviaNFporSMs : AcaoAposCriacaoNF
    {
        public void Faz(NotaFiscal nf)
        {
            Console.WriteLine($"SMS: Empresa - {nf.RazaoSocial} - Valor: {nf.ValorBruto}");
        }
    }
}