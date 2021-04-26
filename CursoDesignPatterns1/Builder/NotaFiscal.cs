using System;
using System.Collections.Generic;

namespace CursoDesignPatterns1
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public decimal ValorBruto { get; private set; }
        public decimal Impostos { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public string Observacoes { get; private set; }

        public IList<ItemDaNota> Items { get; private set; }

        public NotaFiscal(string razaoSocial, string cNPJ, decimal valorBruto, decimal impostos, DateTime dataDeEmissao, string observacoes, IList<ItemDaNota> items)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            ValorBruto = valorBruto;
            Impostos = impostos;
            DataDeEmissao = dataDeEmissao;
            Observacoes = observacoes;
            Items = items;
        }

        // construtor para exemplo do observer
        public NotaFiscal(string empresa, string cnpj, decimal valor)
        {
            this.RazaoSocial = empresa;
            CNPJ = cnpj;
            this.ValorBruto = valor;
        }
    }
}
