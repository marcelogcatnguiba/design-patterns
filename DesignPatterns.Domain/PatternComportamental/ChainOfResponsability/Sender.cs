using DesignPatterns.Domain.PatternComportamental.ChainOfResponsability.Receivers;

namespace DesignPatterns.Domain.PatternComportamental.ChainOfResponsability
{
    public class Sender
    {
        public void RealizarCheckout()
        {
            Checkout checkout = new(1, 20, 23.5);
            System.Console.WriteLine($"Valor total: {checkout.ValorTotal:C}");

            var lavanderia = new LavanderiaReceiver();
            var limpeza = new LimpezaReceiver();
            var quarto = new ServicoQuartoReceiver();

            //Criar fila de servicos
            lavanderia.AddNext(limpeza).AddNext(quarto);

            //Chama corrente de servicos
            lavanderia.ExecutarCobrancaServicos(checkout);

            System.Console.WriteLine($"Valor total apos taxas: {checkout.ValorTotal:C}");
        }
    }
}