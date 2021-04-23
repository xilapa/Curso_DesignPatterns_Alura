using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    public class ProcessarRequisaoCSV : IProcessarRequisicao
    {
        public IProcessarRequisicao Proxima { get; }

        public ProcessarRequisaoCSV(IProcessarRequisicao proxima)
        {
            this.Proxima = proxima;
        }

        public string Processar(ContaBancaria contaBancaria, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.CSV)
                return ($"Titular: {contaBancaria.NomeTitular}, Saldo:{contaBancaria.Saldo}, Processamento {requisicao.Formato}");
            return Proxima.Processar(contaBancaria, requisicao);
        }
    }
}
