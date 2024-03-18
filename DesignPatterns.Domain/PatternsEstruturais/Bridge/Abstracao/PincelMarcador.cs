using DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao.Interfaces;
using DesignPatterns.Domain.PatternsEstruturais.Bridge.Abstracao.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao
{
    public class PincelMarcador : IMaterial
    {
        public ICor? CorImplementacao { get; set; }

        public string ConsultarEstoque()
        {
            return CorImplementacao!.ConsultaQtdePorCor("Pincel Marcador");
        }
    }
}