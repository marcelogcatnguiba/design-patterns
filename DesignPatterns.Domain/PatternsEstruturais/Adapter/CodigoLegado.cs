namespace DesignPatterns.Domain.PatternsEstruturais.Adapter
{
    public class CodigoLegado
    {
        public string ExecutarRotinaDadosPagar(string mes)
        {
            var result = AcessoSQL.GetDadosPagar(mes);

            System.Console.WriteLine("\nAplicando rotina dados pagar ....");
            Thread.Sleep(5000);

            return result;
        }
        public string ExecutarRotinaDadosReceber(string mes)
        {
            var result = AcessoSQL.GetDadosReceber(mes);

            System.Console.WriteLine("\nAplicando rotina dados para receber ....");
            Thread.Sleep(5000);

            return result;
        }
    }
}