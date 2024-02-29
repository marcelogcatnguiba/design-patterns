using DesignPatterns.Domain.PatternsEstruturais.Adapter.Interfaces;

namespace DesignPatterns.Domain.PatternsEstruturais.Adapter
{
    public class ClientCloud
    {
        private IAdapter _adapter;
        public ClientCloud()
        {
            _adapter = new Interfaces.Adapter(new CodigoLegado());
        }

        public void ProcessarContas(string mes)
        {
            var resultContaPagar = _adapter.ExecutarRotinaContasPagar(mes);
            System.Console.WriteLine("Processando rotina dados a Pagar");
            System.Console.WriteLine(resultContaPagar);
            Thread.Sleep(5000);

            System.Console.WriteLine(new string('-', 50));

            var resultContaReceber = _adapter.ExecutarRotinaContasReceber(mes);
            System.Console.WriteLine("Processando rotina dados a Receber");
            System.Console.WriteLine(resultContaReceber);
            Thread.Sleep(5000);

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("\n\nProcesso finalizado !!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}