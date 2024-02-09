using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos
{
    public class TreinoQuartaSabado : ITreino
    {
        public TreinoQuartaSabado()
        {
            System.Console.WriteLine("Criando treino QuartaSabado ...");
        }
        public void ObterTreino()
        {
            System.Console.WriteLine("Obtendo treino QuartaSabado ...");
        }
    }
}