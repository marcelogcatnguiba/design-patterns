namespace DesignPatterns.Domain.PatternComportamental.Visitor.Interfaces
{
    public interface IProduto
    {
        public string NomeProduto { get; set; }
        public double PesoProduto { get; set; }

        public double GetImposto(IVisitor visitor);
    }
}