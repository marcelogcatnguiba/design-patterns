using DesignPatterns.Domain.PatternsEstruturais.Decorator.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Decorator.Decorators
{
    public class AcessorioDecorator : PetDecorator
    {
        public AcessorioDecorator(IPet pet) : base(pet)
        {
        }
        public override string GetNomeServico()
        {
            return base.GetNomeServico() + "\n[+] Acessorio";
        }
        public override double GetValorServico()
        {
            return base.GetValorServico() + 20;
        }
    }
}