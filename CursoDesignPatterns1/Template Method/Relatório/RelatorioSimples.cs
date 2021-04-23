//using System;
//using System.Collections.Generic;

//namespace CursoDesignPatterns1
//{
//    public class RelatorioSimples : TemplateRelatorio
//    {
//        public override void ImprimeCabecalho(Banco banco)
//        {
//            Console.WriteLine($"Nome do Banco: {banco.Nome}");
//        }

//        public override void ImprimeCorpo(List<Conta> contas)
//        {
//            foreach (var conta in contas)
//            {
//                Console.WriteLine($"Titular: {conta.Nome} - Saldo : {conta.Saldo}");
//            }
//        }

//        public override void ImprimeRodape(Banco banco)
//        {
//            Console.WriteLine($"Telefone de Contato: {banco.Telefone}");
//        }
//    }
//}
