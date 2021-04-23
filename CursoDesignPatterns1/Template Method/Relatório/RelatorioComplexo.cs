//using System;
//using System.Collections.Generic;

//namespace CursoDesignPatterns1
//{
//    public class RelatorioComplexo : TemplateRelatorio
//    {
//        public override void ImprimeCabecalho(Banco banco)
//        {
//            Console.WriteLine($"Nome do Banco: {banco.Nome}");
//            Console.WriteLine($"Endereço: {banco.Endereco}");
//            Console.WriteLine($"Telefone de contato: {banco.Telefone}");
//        }

//        public override void ImprimeCorpo(List<Conta> contas)
//        {
//            foreach (var conta in contas)
//            {
//                Console.WriteLine($"Titular: {conta.Nome} - Agência: {conta.Agencia} - Número da Conta: {conta.Numero} - Saldo : {conta.Saldo}");
//            }
//        }

//        public override void ImprimeRodape(Banco banco)
//        {
//            Console.WriteLine($"Email: {banco.Email}");
//            Console.WriteLine($"Data: {DateTime.Now.Date}");
//        }
//    }
//}
