using DesignPatterns.Domain.PatternComportamental.Strategy.Interfaces;

namespace DesignPatterns.Domain.PatternComportamental.Strategy
{
    public class CalculaTaxaServicos
    {
        public static void Calcular(List<IServico> servicos)
        {
            foreach(var s in servicos)
            {
                s.CalcularServico();
                System.Console.WriteLine(new string('-', 40));
            }
        }
    }
}