using DesignPatterns.Domain.PatternsCriacao.Builder.Estudios;

namespace DesignPatterns.Domain.PatternsCriacao.Builder.Construtores
{
    public class Estudio28mBuilder : EstudioBuilder
    {
        public Estudio28mBuilder()
        {
            estudio = new Estudio28m();
        }
        public override void DefinirValorEstudio()
        {
            estudio.DefinirValorEstudio(220000.00M);
        }

        public override void EscolherFinanciamento()
        {
            estudio.EscolherFinanciamento("Fina Invest Moveis");
        }

        public override void EscolherPiso()
        {
            estudio.EscolherPiso("Laminado");
        }
    }
}