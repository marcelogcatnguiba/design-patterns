using DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao
{
    public class Preto : ICor
    {
        public string ConsultaQtdePorCor(string tipoAbstracao)
        {
            var random = new Random();
            var qtdeCor = random.Next(100, 500);

            return $"Existem {qtdeCor} {tipoAbstracao} da cor Preto no estoque";
        }
    }
}