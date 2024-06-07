namespace DesignPatterns.Domain.PatternComportamental.Observer.Interfaces
{
    public interface ISujeito
    {
        public IList<IObservavel> Observaveis { get; set; }
        public void Adicionar(IObservavel observavel);
        public void Remover(IObservavel observavel);
        public void Notificar();
        public void NotificarInscricao(IObservavel observavel);

    }
}