using DesignPatterns.Domain.PatternComportamental.Visitor.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Visitor.Produtos;
using DesignPatterns.Domain.PatternComportamental.Visitor.Visitantes;

namespace DesignPatterns.Domain.PatternComportamental.Visitor
{
    public class Fiscal
    {
        public static void CalcularImpostos(
            List<ProdutoPerecivel> produtoPerecivels, List<ProdutoNaoPerecivel> produtoNaoPerecivels)
        {
            System.Console.WriteLine("Calculando imposto produtos NAO pereciveis:\n");
            CalcularProdutosPereciveis(produtoPerecivels);
            

            System.Console.WriteLine(new String('-', 40));

            System.Console.WriteLine("Calculando imposto produtos pereciveis:\n");
            CalcularProdutosNaoPereciveis(produtoNaoPerecivels);
            
        }

        private static void CalcularProdutosNaoPereciveis(List<ProdutoNaoPerecivel> produtoNaoPerecivels)
        {
            foreach(var p in produtoNaoPerecivels)
            {
                System.Console.WriteLine(p);

                foreach(var v in GetVisitors())
                    p.GetImposto(v);
                
                System.Console.WriteLine("\n");
            }
        }

        private static void CalcularProdutosPereciveis(List<ProdutoPerecivel> produtoPerecivels)
        {
            foreach(var p in produtoPerecivels)
            {
                System.Console.WriteLine(p);

                foreach(var v in GetVisitors())
                    p.GetImposto(v);
                
                System.Console.WriteLine("\n");
            }
        }

        private static List<IVisitor> GetVisitors() => 
        [
            new RioDeJaneiroVisitor("Rio de Janeiro"),
            new SaoPauloVisitor("Sao Paulo")
        ];
    }
}