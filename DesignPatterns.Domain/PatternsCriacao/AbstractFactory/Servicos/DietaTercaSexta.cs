using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos
{
    public class DietaTercaSexta : IDieta
    {
        public DietaTercaSexta()
        {
            System.Console.WriteLine("Criando dieta TercaSexta ...");
        }
        public void ObterDieta()
        {
            throw new NotImplementedException();
        }
    }
}