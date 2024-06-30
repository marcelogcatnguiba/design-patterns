namespace DesignPatterns.Domain.PatternComportamental.Mediator.AbstractModel
{
    public abstract class Contato(Mediador mediador)
    {
        protected Mediador Mediador { get; set; } = mediador;
    }
}