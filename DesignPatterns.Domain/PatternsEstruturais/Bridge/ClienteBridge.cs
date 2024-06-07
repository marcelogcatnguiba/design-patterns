using DesignPatterns.Domain.PatternsEstruturais.Bridge.Abstracao.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Bridge
{
    public class ClienteBridge
    {
        public IMaterial Material { get; set; } = null!;
        public void ConsultaCorEstoque()
        {
            System.Console.WriteLine(Material.ConsultarEstoque());
        }

    }
}