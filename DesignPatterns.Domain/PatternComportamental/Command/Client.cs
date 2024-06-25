using DesignPatterns.Domain.PatternComportamental.Command.Commands;
using DesignPatterns.Domain.PatternComportamental.Command.Receivers;

namespace DesignPatterns.Domain.PatternComportamental.Command
{
    public class Client
    {
        public void FalarComandos()
        {
            var luminaria = new LuzLuminariaReceiver();
            var controle = new ControleInvoker();

            controle.AddCommand("ligar", new LigaLuminariaCommand(luminaria));
            controle.AddCommand("desligar", new DesligaLuminariaCommand(luminaria));

            controle.AddCommand("aumenta", new AumentaIntensidadeCommand(luminaria));
            controle.AddCommand("diminui", new DiminuiIntensidadeCommand(luminaria));

            var fluxo = true;
            while(fluxo)
            {
                System.Console.WriteLine("Digite comando a ser executado :\n");
                var comando = Console.ReadLine();

                controle.ExecuteCommand(comando!);

                System.Console.WriteLine("Deseja terminar ? [s] [n]\n");
                var terminar = Console.ReadLine();

                if(terminar!.Equals("s"))
                {
                    fluxo = !fluxo;
                }
            }
        }
    }
}