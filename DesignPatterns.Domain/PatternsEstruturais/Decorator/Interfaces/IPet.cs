using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternsEstruturais.Decorator.Interfaces
{
    public interface IPet
    {
        string GetNomeServico();
        double GetValorServico();
    }
}