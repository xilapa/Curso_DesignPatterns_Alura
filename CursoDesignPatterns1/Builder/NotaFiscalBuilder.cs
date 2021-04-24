using System;
using System.Collections.Generic;

namespace CursoDesignPatterns1
{
    public class NotaFiscalBuilder
    {
        private string razaoSocial;
        private string cnpj;
        private decimal valorBruto = 0;
        private decimal impostos = 0;
        private DateTime dataDeEmissao;
        private string observacoes;
        private IList<ItemDaNota> items = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            dataDeEmissao = DateTime.Now;
        }

        public NotaFiscalBuilder ParaEmpresa(string empresa)
        {
            razaoSocial = empresa;
            return this;
        }

        public NotaFiscalBuilder ComCNPJ(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            dataDeEmissao = data;
            return this;
        }

        public NotaFiscalBuilder ComObservacao(string obs)
        {
            observacoes = obs;
            return this;
        }
        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            valorBruto += item.Valor;
            impostos += (item.Valor) * 0.05m;
            items.Add(item);
            return this;
        }
        public NotaFiscal Build()
        {
            return new NotaFiscal(razaoSocial, cnpj, valorBruto, impostos, dataDeEmissao, observacoes, items);
        }
    }
}
