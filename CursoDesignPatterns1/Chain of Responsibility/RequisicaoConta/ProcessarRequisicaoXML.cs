using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    public class ProcessarRequisicaoXML : IProcessarRequisicao
    {
        public IProcessarRequisicao Proxima { get; private set; }

        public ProcessarRequisicaoXML(IProcessarRequisicao proxima)
        {
            this.Proxima = proxima;
        }

        public string Processar(ContaBancaria contaBancaria, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.XML)
                return($"Titular: {contaBancaria.NomeTitular}, Saldo:{contaBancaria.Saldo}, Processamento {requisicao.Formato}");
            return Proxima.Processar(contaBancaria, requisicao);
        }
    }
}
