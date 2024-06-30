using DesignPatterns.Domain.PatternComportamental.Mediator.AbstractModel;

namespace DesignPatterns.Domain.PatternComportamental.Mediator
{
    public class Paciente(Mediador mediador) : Contato(mediador)
    {
        public void EnviarMenssagem(string mensagem)
        {
            System.Console.WriteLine("Paciente escrevendo ...");
            Thread.Sleep(2000);

            Mediador.Enviar(mensagem, this);
            Thread.Sleep(2000);
        }

        public void Notificar(string mensagem)
        {
            System.Console.WriteLine($"Para paciente: {mensagem}");
        }
    }
}