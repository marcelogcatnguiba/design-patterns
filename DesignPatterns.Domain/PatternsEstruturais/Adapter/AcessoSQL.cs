using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternsEstruturais.Adapter
{
    public static class AcessoSQL
    {
        public static string GetDadosPagar(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("junho", "Junho :: Pagar\nCNPJ:123456789\nRazao Social: Lojas Prudentes\nValor: 1200");
            dic.Add("agosto", "CNPJ:123456789\nRazao Social: Lojas Macias\nValor: 1200");
            dic.Add("setembro", "CNPJ:123456789\nRazao Social: Lojas Bernardo\nValor: 1200");
            dic.Add("outubro", "CNPJ:123456789\nRazao Social: Lojas Salomao\nValor: 2000");

            return dic[mes];
        }
        public static string GetDadosReceber(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("junho", "Junho :: Receber\nCNPJ:123456789\nRazao Social: Lojas Prudentes\nValor: 1200");
            dic.Add("agosto", "CNPJ:123456789\nRazao Social: Lojas Macias\nValor: 1200");
            dic.Add("setebro", "CNPJ:123456789\nRazao Social: Lojas Bernardo\nValor: 1200");
            dic.Add("outubro", "CNPJ:123456789\nRazao Social: Lojas Salomao\nValor: 2000");

            return dic[mes];
        }
    }
}