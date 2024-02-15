using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Decorator.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Decorator.Decorators
{
    public class LuxoDecorator : PetDecorator
    {
        public LuxoDecorator(IPet pet) : base(pet)
        {
        }

        public override string GetNomeServico()
        {
            return base.GetNomeServico() + "\n[+] Luxo SPA";
        }
        public override double GetValorServico()
        {
            return base.GetValorServico() + 300;
        }
    }
}