namespace DesignPatterns.Domain.PatternComportamental.Memento
{
    public class Snapshot(string estado)
    {
        private readonly string _estado = estado;

        public string GetEstado() => _estado;
    }
}