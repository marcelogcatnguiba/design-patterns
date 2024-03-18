using DesignPatterns.Domain.PatternsEstruturais.Bridge.Abstracao.Interfaces;
using DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Bridge.Abstracao
{
    public class CanetaEsferografica : IMaterial
    {
        public ICor? CorImplementacao { get; set; }

        public string ConsultarEstoque()
        {
            return CorImplementacao!.ConsultaQtdePorCor("Caneta Esferografica");
        }
    }
}