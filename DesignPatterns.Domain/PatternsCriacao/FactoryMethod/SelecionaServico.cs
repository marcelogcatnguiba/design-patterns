using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Enums;
using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Interfaces;
using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Servicos;

namespace DesignPatterns.Domain.PatternsCriacao.FactoryMethod
{
    public class SelecionaServico : ServicoFactory
    {
        public override IServico CriarServico(TipoServico tipoServico)
        {
            switch (tipoServico)
            {
                case TipoServico.Tradicional:
                    return new TradicionalServico();
                case TipoServico.Premium:
                    return new PremiumServico();
                case TipoServico.Master:
                    return new MasterServico();
                case TipoServico.Cobertura:
                    return new CoberturaServico();
                default:
                    return null;
            }
        }
    }
}