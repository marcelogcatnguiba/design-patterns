using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao.Interfaces
{
    public interface ICor
    {
        public string ConsultaQtdePorCor(string tipoAbstracao);
    }
}