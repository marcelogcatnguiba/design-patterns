using DesignPatterns.Domain.PatternComportamental.Command.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Command.Receivers;

namespace DesignPatterns.Domain.PatternComportamental.Command.Commands
{
    public class LigaLuminariaCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public LigaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.LigarLuz();
        }
    }
}