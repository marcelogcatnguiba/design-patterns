using DesignPatterns.Domain.PatternsCriacao.Builder.Estudios;

namespace DesignPatterns.Domain.PatternsCriacao.Builder.Construtores
{
    public abstract class EstudioBuilder
    {
        protected Estudio estudio = null!;
        public Estudio GetEstudio { get => estudio; }

        public abstract void EscolherPiso();
        public abstract void EscolherFinanciamento();
        public abstract void DefinirValorEstudio();
    }
}