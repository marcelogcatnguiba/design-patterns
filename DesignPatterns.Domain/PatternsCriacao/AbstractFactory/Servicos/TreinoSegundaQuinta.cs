using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos
{
    public class TreinoSegundaQuinta : ITreino
    {
        public TreinoSegundaQuinta()
        {
            System.Console.WriteLine("Criando treino SegundaQuinta");
        }

        public void ObterTreino()
        {
            throw new NotImplementedException();
        }
    }
}