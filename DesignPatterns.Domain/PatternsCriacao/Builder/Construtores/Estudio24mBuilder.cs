using DesignPatterns.Domain.PatternsCriacao.Builder.Estudios;

namespace DesignPatterns.Domain.PatternsCriacao.Builder.Construtores
{
    public class Estudio24mBuilder : EstudioBuilder
    {
        public Estudio24mBuilder()
        {
            estudio = new Estudio24m();
        }
        public override void DefinirValorEstudio()
        {
            estudio.DefinirValorEstudio(180000.00M);
        }

        public override void EscolherFinanciamento()
        {
            estudio.EscolherFinanciamento("Fina movel Financiamentos");
        }

        public override void EscolherPiso()
        {
            estudio.EscolherPiso("Ceramica");
        }
    }
}