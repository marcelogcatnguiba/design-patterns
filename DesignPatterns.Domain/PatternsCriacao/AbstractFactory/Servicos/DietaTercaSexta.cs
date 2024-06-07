using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos
{
    public class DietaTercaSexta : IDieta
    {
        public DietaTercaSexta()
        {
            System.Console.WriteLine("Criando dieta TercaSexta ...");
        }
        public void ObterDieta()
        {
            System.Console.WriteLine("Obtendo dieta TercaSexta ...");
        }
    }
}