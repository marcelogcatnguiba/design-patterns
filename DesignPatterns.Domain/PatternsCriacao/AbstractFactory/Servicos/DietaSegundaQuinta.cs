using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos
{
    public class DietaSegundaQuinta : IDieta
    {
        public DietaSegundaQuinta()
        {
            System.Console.WriteLine("Criando dieta SegundaQuinta ...");
        }
        public void ObterDieta()
        {
            System.Console.WriteLine("Obtendo dieta SegundaQuinta ...");
        }
    }
}