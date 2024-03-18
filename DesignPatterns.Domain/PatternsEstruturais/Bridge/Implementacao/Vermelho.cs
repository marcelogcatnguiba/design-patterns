using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao
{
    public class Vermelho : ICor
    {
        public string ConsultaQtdePorCor(string tipoAbstracao)
        {
            var random = new Random();
            var qtdeCor = random.Next(100, 500);

            return $"Existem {qtdeCor} {tipoAbstracao} da cor Vermelho no estoque";
        }
    }
}