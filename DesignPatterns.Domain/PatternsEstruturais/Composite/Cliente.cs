using DesignPatterns.Domain.PatternsEstruturais.Composite.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Composite
{
    public class Cliente
    {
        public void EfetuarCompra()
        {
            ComponentModel produto = new ProdutoLeaf("Camisa", 22.5);
            ComponentModel produto1 = new ProdutoLeaf("Brinquedo", 19.78);
            ComponentModel produto2 = new ProdutoLeaf("Caderno", 60);
            ComponentModel produto3 = new ProdutoLeaf("Jogo de Tabuleiro", 255);

            ComponentModel smallBox = new ProdutoComposite();
            smallBox.Add(produto, produto1, produto2);

            ComponentModel mediumBox = new ProdutoComposite();
            mediumBox.Add(smallBox, produto3);

            var valorTotal = mediumBox.Operacao();

            System.Console.WriteLine($"O valor total da caixa é de {valorTotal.ToString("C")}");
        }
    }
}