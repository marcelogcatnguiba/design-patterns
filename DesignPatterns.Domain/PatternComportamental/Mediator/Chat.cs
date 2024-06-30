namespace DesignPatterns.Domain.PatternComportamental.Mediator
{
    public class Chat
    {
        public static void Conversar()
        {
            MediadorImplementacao mediador = new();

            Paciente paciente = new(mediador);
            Atendente atendente = new(mediador);

            mediador.Atendente = atendente;
            mediador.Paciente = paciente;

            System.Console.WriteLine("Chat: \n\n");

            paciente.EnviarMenssagem("Gostaria de agendar uma consulta");
            atendente.EnviarMenssagem("Sim, por favor, qual especialidade?");

            paciente.EnviarMenssagem("Clinico Geral");
            atendente.EnviarMenssagem("Temos vagas na Segunda as 16:30");

            paciente.EnviarMenssagem("Tudo bem pode marcar, obrigado");
            atendente.EnviarMenssagem("Nos que agradecemos");
        }
    }
}