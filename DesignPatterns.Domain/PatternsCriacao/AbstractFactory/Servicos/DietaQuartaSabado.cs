using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos
{
    public class DietaQuartaSabado : IDieta
    {
        public DietaQuartaSabado()
        {
            System.Console.WriteLine("Criando dieta QuartaSabado ...");
        }
        public void ObterDieta()
        {
            throw new NotImplementedException();
        }
    }
}