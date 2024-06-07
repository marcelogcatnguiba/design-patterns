using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Servicos
{
    public class PremiumServico : IServico
    {
        public PremiumServico()
        {
            System.Console.WriteLine("Produto Premium criado ...");
        }
        public void ExecutaServico()
        {
            System.Console.WriteLine("Executando servico Premium ...");
        }
    }
}