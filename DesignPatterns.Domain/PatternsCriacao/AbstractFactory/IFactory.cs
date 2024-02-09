using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory
{
    public interface IFactory
    {
        public void CriarRotinaDiaria();
    }
}