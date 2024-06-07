using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Servicos
{
    public class MasterServico : IServico
    {
        public MasterServico()
        {
            System.Console.WriteLine("Produto Master criado ...");
        }
        public void ExecutaServico()
        {
            System.Console.WriteLine("Executando servico Master ...");
        }
    }
}