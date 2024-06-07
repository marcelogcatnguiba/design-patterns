using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            CriarRotinaDiaria();
        }

        public void CriarRotinaDiaria()
        {
            DietaQuartaSabado dieta = new DietaQuartaSabado();
            TreinoQuartaSabado treino = new TreinoQuartaSabado();

            dieta.ObterDieta();
            treino.ObterTreino();
        }
    }
}