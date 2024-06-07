namespace DesignPatterns.Domain.PatternsCriacao.Builder.Estudios
{
    public abstract class Estudio
    {
        public string TipoPiso { get; protected set; } = "";
        public string TipoFinanciamento { get; protected set; } = "";
        public decimal ValorEstudio { get; protected set; }

        public abstract void EscolherPiso(string piso);
        public abstract void EscolherFinanciamento(string tipoFinanciamento);
        public abstract void DefinirValorEstudio(decimal valorEstudio);
    }
}