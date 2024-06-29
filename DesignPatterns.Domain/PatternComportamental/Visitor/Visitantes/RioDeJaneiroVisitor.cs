using Class = DesignPatterns.Domain.PatternComportamental.Visitor.Implementation;
using DesignPatterns.Domain.PatternComportamental.Visitor.Produtos;

namespace DesignPatterns.Domain.PatternComportamental.Visitor.Visitantes
{
    public class RioDeJaneiroVisitor(string visitorName) : Class::Visitor(visitorName)
    {
        private const double _impostoPerecivel = 5;
        private const double _impostoNaoPerecivel = 10;

        public override double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
        {
            var imposto = (produtoNaoPerecivel.PesoProduto / 100) + _impostoPerecivel;

            ImprimirImposto(imposto);
            
            return imposto;
        }

        public override double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
        {
            var imposto = (produtoPerecivel.PesoProduto / 100) + _impostoNaoPerecivel;

            ImprimirImposto(imposto);

            return imposto;
        }
    }
}