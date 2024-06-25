using DesignPatterns.Domain.PatternComportamental.Command.Interfaces;

namespace DesignPatterns.Domain.PatternComportamental.Command
{
    public class ControleInvoker
    {
        private Dictionary<string, ICommand> _commands = [];

        public void AddCommand(string nomeComando, ICommand command)
        {
            _commands.Add(nomeComando, command);
        }

        public void ExecuteCommand(string nomeComando)
        {
            if(!_commands.ContainsKey(nomeComando))
            {
                System.Console.WriteLine("Comando inexistente !");
                return;
            }

            _commands[nomeComando].Execute();
        }
    }
}