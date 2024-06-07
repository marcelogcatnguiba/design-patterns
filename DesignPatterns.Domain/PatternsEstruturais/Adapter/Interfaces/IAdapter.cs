namespace DesignPatterns.Domain.PatternsEstruturais.Adapter.Interfaces
{
    public interface IAdapter
    {
        public string ExecutarRotinaContasPagar(string mes);
        public string ExecutarRotinaContasReceber(string mes);
    }
}