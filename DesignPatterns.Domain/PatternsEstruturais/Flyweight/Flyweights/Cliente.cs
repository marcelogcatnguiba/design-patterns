using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternsEstruturais.Flyweight.Flyweights
{
    public class Cliente
    {
        List<string> coresTamanho = new()
            {
                "azul:pequena",
                "cinza:media",
                "vermelha:grande",
                "azul:pequena",
                "cinza:media",
                "vermelha:grande"
            };
        public void ConsumirFlyweight()
        {
            var factory = new FlyweightFactory();
            foreach (var ct in coresTamanho)
            {
                var cor = ct.Split(":")[0];
                var tamanho = ct.Split(":")[1];
                var nave = factory.GetNave(cor);

                nave.Exibir(cor, tamanho);
            }
        }
    }
}