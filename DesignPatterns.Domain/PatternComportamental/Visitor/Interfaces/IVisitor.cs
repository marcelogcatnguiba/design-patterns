using DesignPatterns.Domain.PatternComportamental.Visitor.Produtos;

namespace DesignPatterns.Domain.PatternComportamental.Visitor.Interfaces
{
    public interface IVisitor
    {
        //Visita um produto e aplica a regra de calcular o imposto
        double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel);
        double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel);
    }
}