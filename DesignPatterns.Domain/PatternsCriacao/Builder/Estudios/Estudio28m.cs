namespace DesignPatterns.Domain.PatternsCriacao.Builder.Estudios
{
    public class Estudio28m : Estudio
    {
        public override void DefinirValorEstudio(decimal valorEstudio)
        {
            ValorEstudio = valorEstudio;
        }

        public override void EscolherFinanciamento(string tipoFinanciamento)
        {
            TipoFinanciamento = tipoFinanciamento;
        }

        public override void EscolherPiso(string piso)
        {
            TipoPiso = piso;
        }
    }
}