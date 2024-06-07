using DesignPatterns.Domain.PatternsEstruturais.Flyweight.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Flyweight.Flyweights
{
    public class NaveVermelha : Nave
    {
        public NaveVermelha()
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