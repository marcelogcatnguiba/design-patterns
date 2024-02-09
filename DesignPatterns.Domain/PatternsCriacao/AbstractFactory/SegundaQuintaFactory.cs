using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;
using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            CriarRotinaDiaria();
        }
        public void CriarRotinaDiaria()
        {
            DietaSegundaQuinta dieta = new DietaSegundaQuinta();
            TreinoSegundaQuinta treino = new TreinoSegundaQuinta();

            dieta.ObterDieta();
            treino.ObterTreino();
        }
    }
}