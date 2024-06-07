namespace DesignPatterns.Domain.PatternsEstruturais.Flyweight
{
    public class Cliente
    {
        List<string> coresTamanho = new()
            {
                "azul:pequena",
                "cinza:media",
                "vermelha:grande",
                "azul:pequena",
                "cinza:media",
                "vermelha:grande"
            };
        public void ConsumirFlyweight()
        {
            var factory = new FlyweightFactory();
            foreach (var ct in coresTamanho)
            {
                var cor = ct.Split(":")[0];
                var tamanho = ct.Split(":")[1];
                var nave = factory.GetNave(cor); //Cor pois é deterministico nesse cenário

                nave.Exibir(cor, tamanho);
            }
        }
    }
}