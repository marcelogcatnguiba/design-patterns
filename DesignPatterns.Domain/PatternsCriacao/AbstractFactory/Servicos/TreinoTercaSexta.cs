using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos
{
    public class TreinoTercaSexta : ITreino
    {
        public TreinoTercaSexta()
        {
            System.Console.WriteLine("Criando Treino TercaSexta ...");
        }
        public void ObterTreino()
        {
            System.Console.WriteLine("Obtendo treino TercaSexta ...");
        }
    }
}