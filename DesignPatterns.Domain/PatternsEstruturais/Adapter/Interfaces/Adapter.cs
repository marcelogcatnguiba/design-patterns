namespace DesignPatterns.Domain.PatternsEstruturais.Adapter.Interfaces
{
    public class Adapter : IAdapter
    {
        private CodigoLegado _codLegado;

        public Adapter(CodigoLegado codLegado)
        {
            _codLegado = codLegado;
        }

        public string ExecutarRotinaContasPagar(string mes)
        {
            return _codLegado.ExecutarRotinaDadosPagar(mes);
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            return _codLegado.ExecutarRotinaDadosReceber(mes);
        }
    }
}