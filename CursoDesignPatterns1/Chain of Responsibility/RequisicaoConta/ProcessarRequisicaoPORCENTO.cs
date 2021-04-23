using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    public class ProcessarRequisicaoPORCENTO : IProcessarRequisicao
    {
        public IProcessarRequisicao Proxima { get; }

        public ProcessarRequisicaoPORCENTO(IProcessarRequisicao proxima)
        {
            this.Proxima = proxima;
        }

        public string Processar(ContaBancaria contaBancaria, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.PORCENTO)
                return ($"Titular: {contaBancaria.NomeTitular}, Saldo:{contaBancaria.Saldo}, Processamento {requisicao.Formato}");
            if (Proxima != null)
                return Proxima.Processar(contaBancaria, requisicao);
            return "";
        }
    }
}
