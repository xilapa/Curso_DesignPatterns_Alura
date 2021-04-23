using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    public class ProcessadorDeRequisicao
    {
        public string Processar(ContaBancaria contaBancaria, Requisicao requisicao)
        {
            try
            {
                var resposta = new ProcessarRequisicaoXML(new ProcessarRequisaoCSV(new ProcessarRequisicaoPORCENTO(null)));
                return resposta.Processar(contaBancaria, requisicao);
            }
            catch
            {
                return "Formato Inválido";
            }         
            
        }
    }
}
