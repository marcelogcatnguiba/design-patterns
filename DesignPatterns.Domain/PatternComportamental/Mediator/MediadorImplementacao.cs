using DesignPatterns.Domain.PatternComportamental.Mediator.AbstractModel;

namespace DesignPatterns.Domain.PatternComportamental.Mediator
{
    public class MediadorImplementacao : Mediador
    {
        private Atendente? _atendente;
        private Paciente? _paciente;

        public Atendente Atendente { set => _atendente = value; }
        public Paciente Paciente { set => _paciente = value; }

        public override void Enviar(string mensagem, Contato contato)
        {
            if(contato.Equals(_paciente))
            {
                _atendente!.Notificar(mensagem);
                System.Console.WriteLine("\n");
                return;
            }

            _paciente!.Notificar(mensagem);
            System.Console.WriteLine("\n");
        }
    }
}