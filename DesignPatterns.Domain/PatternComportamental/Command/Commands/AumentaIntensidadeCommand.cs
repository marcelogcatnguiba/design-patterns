using DesignPatterns.Domain.PatternComportamental.Command.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Command.Receivers;

namespace DesignPatterns.Domain.PatternComportamental.Command.Commands
{
    public class AumentaIntensidadeCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public AumentaIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.AumentarIntensidade();
        }
    }
}