using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Decorator.Decorators;
using DesignPatterns.Domain.PatternsEstruturais.Decorator.Services;

namespace DesignPatterns.Domain.PatternsEstruturais.Decorator
{
    public class Cliente
    {
        public void ExecutarServicoPet()
        {
            var banhoTosa = new BanhoTosa("Banho e Tosa", 100);
            var acessorioDecorator = new AcessorioDecorator(banhoTosa);
            var luxoSpa = new LuxoDecorator(acessorioDecorator);

            System.Console.WriteLine(luxoSpa.GetNomeServico());
            System.Console.WriteLine(luxoSpa.GetValorServico());
        }
    }
}