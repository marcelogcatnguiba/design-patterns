using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Flyweight.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Flyweight.Flyweights
{
    public class NaveCinza : Nave
    {
        public NaveCinza()
        {
            Condicao = "voando em linha reta";
            Acao = "- disparando lazers";
        }
        public override void Exibir(string cor, string tamanho)
        {
            Cor = cor;
            Tamanho = tamanho;
            System.Console.WriteLine($"Nave tamanho {Tamanho} e cor {Cor} {Condicao} {Acao}");
        }
    }
}