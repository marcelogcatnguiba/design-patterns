using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Servicos
{
    public class TradicionalServico : IServico
    {
        public TradicionalServico()
        {
            System.Console.WriteLine("Produto Tradicional criado ...");
        }
        public void ExecutaServico()
        {
            System.Console.WriteLine("Executando servico Tradicional ...");
        }
    }
}