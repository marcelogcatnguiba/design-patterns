using DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Bridge.Abstracao.Interfaces
{
    public interface IMaterial
    {
        public ICor? CorImplementacao { get; set; }

        public string ConsultarEstoque();
    }
}