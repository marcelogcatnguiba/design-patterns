namespace DesignPatterns.Domain.PatternComportamental.ChainOfResponsability.AbstractModel
{
    public class CobrancaReceiver
    {
        public CobrancaReceiver? Next { get; set; }

        public CobrancaReceiver AddNext(CobrancaReceiver next)
        {
            Next = next;
            return next;
        }

        public virtual Checkout? ExecutarCobrancaServicos(Checkout checkout)
        {
            if(Next != null)
                return Next.ExecutarCobrancaServicos(checkout);

            return null;
        }
    }
}