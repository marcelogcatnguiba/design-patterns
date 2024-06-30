using DesignPatterns.Domain.PatternComportamental.ChainOfResponsability.AbstractModel;

namespace DesignPatterns.Domain.PatternComportamental.ChainOfResponsability.Receivers
{
    public class LimpezaReceiver : CobrancaReceiver
    {
        public override Checkout? ExecutarCobrancaServicos(Checkout checkout)
        {
            System.Console.WriteLine("Calculando taxa Limpeza ...");
            checkout.ValorTotal *= 1.03;
            
            return base.ExecutarCobrancaServicos(checkout);
        }
    }
}