using DesignPatterns.Domain.PatternComportamental.ChainOfResponsability.AbstractModel;

namespace DesignPatterns.Domain.PatternComportamental.ChainOfResponsability.Receivers
{
    public class LavanderiaReceiver : CobrancaReceiver
    {
        public override Checkout? ExecutarCobrancaServicos(Checkout checkout)
        {
            System.Console.WriteLine("Calculando taxa Lavanderia ...");
            checkout.ValorTotal *= 1.028;

            return base.ExecutarCobrancaServicos(checkout);
        }
    }
}