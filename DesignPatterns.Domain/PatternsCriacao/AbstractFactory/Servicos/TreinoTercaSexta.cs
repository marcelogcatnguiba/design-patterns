using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos
{
    public class TreinoTercaSexta : ITreino
    {
        public TreinoTercaSexta()
        {
            System.Console.WriteLine("Criando treino TercaSexta");
        }
        public void ObterTreino()
        {
            throw new NotImplementedException();
        }
    }
}