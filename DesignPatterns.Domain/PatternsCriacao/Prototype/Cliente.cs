namespace DesignPatterns.Domain.PatternsCriacao.Prototype
{
    public class Cliente
    {
        public void ConsumirGerenciador()
        {
            GerenciadorVendasEstudio gerenciador = new();

            gerenciador["24"] = new Estudio("24 metros", "Fina Investimentos", 180000M);
            gerenciador["26"] = new Estudio("26 metros", "Imoveis Aurora", 200000M);
            gerenciador["28"] = new Estudio("28 metros", "Nova InvestMoveis", 220000M);

            EstudioModel primeiroClone = gerenciador["24"].Clone()!;
            EstudioModel segundoClone = gerenciador["26"].Clone()!;
            EstudioModel terceiroClone = gerenciador["28"].Clone()!;
        }
    }
}