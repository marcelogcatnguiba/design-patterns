using DesignPatterns.Domain.PatternComportamental.Visitor.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Visitor.Produtos;
using DesignPatterns.Domain.PatternComportamental.Visitor.Visitantes;

namespace DesignPatterns.Domain.PatternComportamental.Visitor
{
    public class Fiscal
    {
        public static void CalcularImpostos()
        {
            CalcularProdutosPereciveis();
            System.Console.WriteLine(new String('-', 40));
            CalcularProdutosNaoPereciveis();
        }

        private static void CalcularProdutosNaoPereciveis()
        {
            List<ProdutoNaoPerecivel> produtoNaoPerecivels = 
            [
                new("Antena WiFi", 500),
                new("Perfume frances", 1000)
            ];

            System.Console.WriteLine("Calculando imposto produtos NAO pereciveis:\n");

            foreach(var p in produtoNaoPerecivels)
            {
                System.Console.WriteLine($"Produto: {p.NomeProduto}, Peso: {p.PesoProduto}");

                foreach(var v in GetVisitors())
                    v.CalcularImpostoProdutoNaoPerecivel(p);
                
                System.Console.WriteLine("\n");
            }
        }

        private static void CalcularProdutosPereciveis()
        {
            List<ProdutoPerecivel> produtoPerecivels =
            [
                new("Especiarias", 2500),
                new("Poupas de frutas", 2000)
            ];

            System.Console.WriteLine("Calculando imposto produtos pereciveis:\n");

            foreach(var p in produtoPerecivels)
            {
                System.Console.WriteLine($"Produto: {p.NomeProduto}, Peso: {p.PesoProduto}");

                foreach(var v in GetVisitors())
                    v.CalcularImpostoProdutoPerecivel(p);
                
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