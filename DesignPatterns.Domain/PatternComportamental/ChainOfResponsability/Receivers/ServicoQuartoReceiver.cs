using DesignPatterns.Domain.PatternComportamental.ChainOfResponsability.AbstractModel;

namespace DesignPatterns.Domain.PatternComportamental.ChainOfResponsability.Receivers
{
    public class ServicoQuartoReceiver : CobrancaReceiver
    {
        public override Checkout? ExecutarCobrancaServicos(Checkout checkout)
        {
            System.Console.WriteLine("Calculando taxa ServicoDeQuarto ...");
            checkout.ValorTotal *= 1.025;

            return base.ExecutarCobrancaServicos(checkout);
        }
    }
}