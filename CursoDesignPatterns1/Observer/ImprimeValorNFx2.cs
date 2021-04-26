using System;

namespace CursoDesignPatterns1
{
    public class ImprimeValorNFx2 : AcaoAposCriacaoNF
    {
        public void Faz(NotaFiscal nf)
        {
            Console.WriteLine($"Valor dobrado: {nf.ValorBruto * 2}");
        }
    }
}
