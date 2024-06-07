namespace DesignPatterns.Domain.PatternsCriacao.Builder.Estudios
{
    public class Estudio24m : Estudio
    {
        public override void EscolherPiso(string piso)
        {
            TipoPiso = piso;
        }
        public override void EscolherFinanciamento(string tipoFinanciamento)
        {
            TipoFinanciamento = tipoFinanciamento;
        }
        public override void DefinirValorEstudio(decimal valorEstudio)
        {
            ValorEstudio = valorEstudio;
        }
    }
}