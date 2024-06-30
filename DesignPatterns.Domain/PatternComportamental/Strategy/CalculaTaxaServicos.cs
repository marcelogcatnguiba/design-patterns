using DesignPatterns.Domain.PatternComportamental.Strategy.Enum;
using DesignPatterns.Domain.PatternComportamental.Strategy.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Strategy.Model;

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

        public static double AplicarTaxaSuite(Orcamento orcamento)
        {
            var taxaSuite = CalcularTaxaSuite(orcamento);
            orcamento.ValorTotal += taxaSuite;

            return taxaSuite;
        }

        private static double CalcularTaxaSuite(Orcamento orcamento)
        {
            return orcamento.ValorTotal * PorcentagemTaxaSuite(orcamento.Porcentagem);
        }

        private static double PorcentagemTaxaSuite(TipoSuite suite)
        {
            switch(suite)
            {
                case TipoSuite.Cobertura:
                    return 0.2;
                case TipoSuite.Master:
                    return 0.18;
                case TipoSuite.Premium:
                    return 0.15;
                case TipoSuite.Tradicional:
                    return 0.12;
                default:
                    return 0;
            }
        }
    }
}