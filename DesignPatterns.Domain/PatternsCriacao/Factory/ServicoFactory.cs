using DesignPatterns.Domain.PatternsCriacao.Factory.Interfaces;
using DesignPatterns.Domain.PatternsCriacao.Factory.Enums;

namespace DesignPatterns.Domain.PatternsCriacao.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico? CriarServico(TipoServico? tipoServico);
    }
}