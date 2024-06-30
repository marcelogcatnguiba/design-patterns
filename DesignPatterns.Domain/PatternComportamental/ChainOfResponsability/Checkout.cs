namespace DesignPatterns.Domain.PatternComportamental.ChainOfResponsability
{
    public class Checkout
    {
        public int ClientId { get; set; }
        public int QuantidadeDias { get; set; }
        public double ValorDiaria { get; set; }
        public double ValorTotal { get; set; }

        public Checkout(int clientId, int quantidadeDias, double valorDiaria)
        {
            ClientId = clientId;
            QuantidadeDias = quantidadeDias;
            ValorDiaria = valorDiaria;

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            ValorTotal = QuantidadeDias * ValorDiaria;
        }
    }
}