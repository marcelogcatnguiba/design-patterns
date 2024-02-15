using DesignPatterns.Domain.PatternsCriacao.FactoryMethod.Enums;

namespace DesignPatterns.Domain.PatternsCriacao.FactoryMethod
{
    public class Cliente
    {
        public void ExecutarCriacaoProduto()
        {
            var selecionaServico = new SelecionaServico();
            var continuar = true;

            while (continuar)
            {
                System.Console.WriteLine("**************************************");
                System.Console.WriteLine("Seleciono o tipo de servico:");
                System.Console.WriteLine("0 - Tradicional");
                System.Console.WriteLine("1 - Premium");
                System.Console.WriteLine("2 - Master");
                System.Console.WriteLine("3 - Cobertura");
                System.Console.WriteLine("**************************************\n");
                System.Console.Write("Digite o servico que desaja usar: ");

                var servico = int.Parse(Console.ReadLine()!);

                System.Console.WriteLine("\n");
                selecionaServico.CriarServico((TipoServico)servico);
                System.Console.WriteLine("\n");

                System.Console.Write("Deseja continuar? : 1 = [Sim]\t2 = [Nao]:");
                var resp = int.Parse(Console.ReadLine()!);

                if (resp == 2)
                {
                    continuar = false;
                }
            }
        }
    }
}