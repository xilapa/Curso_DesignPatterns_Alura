using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    public interface IProcessarRequisicao
    {
        IProcessarRequisicao Proxima { get; }
        string Processar(ContaBancaria contaBancaria, Requisicao requisicao);
    }
}
