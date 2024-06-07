using DesignPatterns.Domain.PatternsCriacao.Builder.Construtores;

namespace DesignPatterns.Domain.PatternsCriacao.Builder
{
    public class Director
    {
        public void ConstruirEstudio(EstudioBuilder builder)
        {
            builder.EscolherPiso();
            builder.EscolherFinanciamento();
            builder.DefinirValorEstudio();
        }
    }
}