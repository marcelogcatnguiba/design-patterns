using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Interfaces;
using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Enums;

namespace DesignPatterns.Domain.PatternsCriacao.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico CriarProduto(TipoServico tipoServico);
    }
}