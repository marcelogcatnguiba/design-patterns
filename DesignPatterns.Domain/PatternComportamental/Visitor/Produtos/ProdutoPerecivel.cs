using DesignPatterns.Domain.PatternComportamental.Visitor.Interfaces;

namespace DesignPatterns.Domain.PatternComportamental.Visitor.Produtos
{
    public class ProdutoPerecivel(string nome, double peso) : IProduto
    {
        public string NomeProduto { get; set; } = nome;
        public double PesoProduto { get; set; } = peso;

        public double GetImposto(IVisitor visitor) => visitor.CalcularImpostoProdutoPerecivel(this);

        public override string ToString()
        {
            return $"Produto: {NomeProduto}, Peso: {PesoProduto}";
        }
    }
}