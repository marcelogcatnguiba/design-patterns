using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Servicos
{
    public class CoberturaServico : IServico
    {
        public CoberturaServico()
        {
            System.Console.WriteLine("Produto Cobertura criado ...");
        }
        public void ExecutaServico()
        {
            System.Console.WriteLine("Executando servico Cobertura ...");
        }
    }
}