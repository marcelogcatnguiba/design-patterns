using DesignPatterns.Domain.PatternComportamental.Command.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Command.Receivers;

namespace DesignPatterns.Domain.PatternComportamental.Command.Commands
{
    public class DesligaLuminariaCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public DesligaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.DesligarLuz();
        }
    }
}