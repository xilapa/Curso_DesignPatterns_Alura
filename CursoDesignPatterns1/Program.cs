using System;

namespace CursoDesignPatterns1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
            // Explicação Strategy
            var icms = new ICMS();
            var iss = new ISS();
            var iccc = new ICCC();

            var orcamento = new Orcamento(500.0);

            var calculadoraImposto = new CalculadorDeImpostos();

            calculadoraImposto.RealizarCalculo(orcamento, icms);
            calculadoraImposto.RealizarCalculo(orcamento, iss);
            calculadoraImposto.RealizarCalculo(orcamento, iccc);

            // Exercício Investimento Strategy
            Console.WriteLine("\n\n Investimentos");

            var conta1 = new ContaBancaria();
            var conta2 = new ContaBancaria();
            var conta3 = new ContaBancaria();

            conta1.Saldo = 1000;
            conta2.Saldo = 1000;
            conta3.Saldo = 1000;

            var investimentoConservador = new Conservador();
            var investimentoModerado = new Moderado();
            var investimentoArrojado = new Arrojado();

            var realizadorDeInvestimento = new RealizadorDeInvestimentos();

            realizadorDeInvestimento.Investir(conta1, investimentoConservador);
            realizadorDeInvestimento.Investir(conta2, investimentoModerado);
            realizadorDeInvestimento.Investir(conta3, investimentoArrojado);

            #endregion

            #region Chain of Responsibility

            // Explicação Chain of Responsibility
            Console.WriteLine("\n\n Desconto");
            var calculadorDeDesconto = new CalculadorDeDesconto();

            orcamento.AdicionaItens(new Item("LAPIS", 300.0));
            orcamento.AdicionaItens(new Item("CANETA", 300.0));

            var desconto = calculadorDeDesconto.Calcular(orcamento);
            Console.WriteLine($"Valor do Desconto: {desconto}");



            // Exercicio Chain of Responsibility
            Console.WriteLine("\n\n Requisição");

            var requisicao = new Requisicao((Formato)4);
            var conta4 = new ContaBancaria();
            var processadorDeRequisicao = new ProcessadorDeRequisicao();

            conta4.NomeTitular = "Dirceu";
            conta4.Saldo = 1000;

            var requisicaoProcessada = processadorDeRequisicao.Processar(conta4, requisicao);
            Console.WriteLine(requisicaoProcessada);

            Console.ReadKey();
            #endregion

            #region Template Method

            // esta na pasta dele

            #endregion

            #region Decorator

            Console.WriteLine("Decorator");

            var totalImposto = new ImpostoMuitoAlto(new ImpostoA(new ImpostoB(new ImpostoC()))).Calcular(100);
            Console.WriteLine(totalImposto);

            #endregion

            #region Decorator + Template
            Console.WriteLine("Decorator + Template");

            var orcamento2 = new Orcamento(100);
            orcamento.Itens.Add(new Item("Arroz", 120.0));

            var totalImposto2 = new ICPP(new IKCV()).Calcular(orcamento2);

            Console.WriteLine(totalImposto2);
            #endregion

            #region State

            var orcamentoComEstado = new OrcamentoComEstados(100);
            Console.WriteLine(orcamentoComEstado.Valor);

            orcamentoComEstado.AplicaDescontoExtra();
            Console.WriteLine(orcamentoComEstado.Valor);

            orcamentoComEstado.Aprovar();
            orcamentoComEstado.AplicaDescontoExtra();
            Console.WriteLine(orcamentoComEstado.Valor);

            //orcamentoComEstado.AplicaDescontoExtra();
            Console.ReadKey();


            // Exemplo conta bancária
            Console.WriteLine("Conta Bancária");
            var contaBancariaComEstados = new ContaBancariaComEstados();
            contaBancariaComEstados.Sacar(100);
            //contaBancariaComEstados.Sacar(200); gera exceção, saldo negativo

            #endregion

            #region Builder

            Console.WriteLine("Builder");
            var nfBuilder = new NotaFiscalBuilder();
            var nota = nfBuilder
                            .ComCNPJ("123456/0001-9")
                            .ParaEmpresa("Empresa")
                            .ComItem(new ItemDaNota("caneta", 15.0m))
                            .ComItem(new ItemDaNota("borracha", 25.0m))
                            .ComObservacao("observação")
                            .Build();

            Console.WriteLine(nota.Impostos);
            Console.WriteLine(nota.ValorBruto);
            Console.ReadKey();

            #endregion

            #region Observer

            Console.WriteLine("Observer");
            var criaNotaFiscalComObserver = new CriaNotaFiscalComObserver();
            criaNotaFiscalComObserver.AdicionarAcoes(new EnviaNFEmail());
            criaNotaFiscalComObserver.AdicionarAcoes(new EnviaNFporSMs());
            criaNotaFiscalComObserver.AdicionarAcoes(new ImprimeValorNFx2());
            criaNotaFiscalComObserver.Criar("empresa A", "1223456/00099-1", 15000.0m);
            Console.ReadKey();

            #endregion
        }

    }
}
