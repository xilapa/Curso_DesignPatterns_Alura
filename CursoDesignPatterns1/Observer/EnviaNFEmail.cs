using System;

namespace CursoDesignPatterns1
{
    public class EnviaNFEmail : AcaoAposCriacaoNF
    {
        public void Faz(NotaFiscal nf)
        {
            Console.WriteLine($"Email: Empresa - {nf.RazaoSocial} - Valor: {nf.ValorBruto}");
        }
    }
}
