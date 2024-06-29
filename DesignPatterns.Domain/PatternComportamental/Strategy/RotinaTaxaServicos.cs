using DesignPatterns.Domain.PatternComportamental.Strategy.Enum;
using DesignPatterns.Domain.PatternComportamental.Strategy.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Strategy.Model;
using DesignPatterns.Domain.PatternComportamental.Strategy.Services;

namespace DesignPatterns.Domain.PatternComportamental.Strategy
{
    public class RotinaTaxaServicos
    {
        public static void ExecutarRotina()
        {
            
            Orcamento cobertura = new(1, valorDiaria: 70, qtdeDias: 30, PorcentagemServicos.Cobertura);
            Orcamento cobertura2 = new(2, 70, 65, PorcentagemServicos.Cobertura, true);
            Orcamento master = new(3, 50, 20, PorcentagemServicos.Master);
            Orcamento master2 = new(4, 50, 60, PorcentagemServicos.Master, true);
            Orcamento premium = new(5, 40, 15, PorcentagemServicos.Premium);
            Orcamento premium2 = new(6, 40, 23, PorcentagemServicos.Premium, true);
            Orcamento tradicional = new(7, 30, 20, PorcentagemServicos.Tradicional);
            Orcamento tradicional2 = new(8, 30, 32, PorcentagemServicos.Tradicional, true);
            
            List<IServico> servicos = 
            [
                new CoberturaServico(cobertura),
                new CoberturaServico(cobertura2),
                new MasterServico(master),
                new MasterServico(master2),
                new PremiumServico(premium),
                new PremiumServico(premium2),
                new TradicionalServico(tradicional),
                new TradicionalServico(tradicional2)
            ];

            CalculaTaxaServicos.Calcular(servicos);
        }
    }
}