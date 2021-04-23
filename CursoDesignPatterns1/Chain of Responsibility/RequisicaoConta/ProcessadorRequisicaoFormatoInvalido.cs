using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    public class ProcessadorRequisicaoFormatoInvalido : IProcessarRequisicao
    {
        public IProcessarRequisicao Proxima { get; }

        public ProcessadorRequisicaoFormatoInvalido(IProcessarRequisicao proxima)
        {
            this.Proxima = proxima;
        }

        public string Processar(ContaBancaria contaBancaria, Requisicao requisicao)
        {
            return "Formato Inválido";
        }
    }
}
