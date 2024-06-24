using DesignPatterns.Domain.PatternsEstruturais.Facade.AmbienteComplexo;

namespace DesignPatterns.Domain.PatternsEstruturais.Facade
{
    public class FacadeManager
    {
        public static void ExecutarComplexidade()
        {
            var perdasNorte = ZonaNorte.ExecutaRotinaVendasPerdidas(DateTime.Now);
            var perdasSul = ZonaSul.ExecutaRotinaVendasPerdidas(DateTime.Now);

            CloudComputing.GerarRelatorioVendasPerdidas(perdasSul, perdasNorte);
        }
    }
}