using DesignPatterns.Domain.PatternsCriacao.Builder.Construtores;
using DesignPatterns.Domain.PatternsCriacao.Builder.Estudios;

namespace DesignPatterns.Domain.PatternsCriacao.Builder
{
    public class ClientBuilder
    {
        public void ConsumirBuilders()
        {
            var director = new Director();
            var estudioBuilder = new Estudio24mBuilder();
            director.ConstruirEstudio(estudioBuilder);

            var estudio = estudioBuilder.GetEstudio;
            ImprimirResultado(estudio, "Estudio 24m");
        }

        private void ImprimirResultado(Estudio estudio, string nome)
        {
            System.Console.WriteLine(new string('-', 40));
            System.Console.WriteLine($"[+] - Estudio: {nome}");
            System.Console.WriteLine($"Valor do Estudio: {estudio.ValorEstudio.ToString("C")}");
            System.Console.WriteLine($"Financiamento: {estudio.TipoFinanciamento}");
            System.Console.WriteLine($"Tipo de piso: {estudio.TipoPiso}");
        }
    }
}