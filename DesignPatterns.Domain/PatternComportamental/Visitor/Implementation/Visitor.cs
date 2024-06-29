using DesignPatterns.Domain.PatternComportamental.Visitor.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Visitor.Produtos;

namespace DesignPatterns.Domain.PatternComportamental.Visitor.Implementation
{
    public abstract class Visitor(string visitorName) : IVisitor
    {
        public string VisitorName { get; } = visitorName;

        public abstract double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel);
        public abstract double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel);

        protected void ImprimirImposto(double imposto)
        {
            System.Console.WriteLine($"Imposto {VisitorName} é de {imposto:C}");
        }
    }
}