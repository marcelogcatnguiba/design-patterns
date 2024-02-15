using DesignPatterns.Domain.PatternComportamental.Observer.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Observer.Models;
using DesignPatterns.Domain.PatternComportamental.Observer.Observers;
using DesignPatterns.Domain.PatternComportamental.Observer.Subjects;

namespace DesignPatterns.Domain.PatternComportamental.Observer
{
    public class EnviarEmail
    {
        public void Enviar()
        {
            string naoAssMensagem = "Sabemos que ainda não faz parte do nosso clube de assinantes";
            string assMensagem = "Aproveite as ofertas de assinante";

            List<IObservavel> observavel = new List<IObservavel>()
            {
                new Assinante(new Pessoa(01, "Maria", "maria@gmail.com"), assMensagem),
                new NaoAssinante(new Pessoa(02, "Joao", "joao@gmail.com"), naoAssMensagem),
                new Assinante(new Pessoa(03, "Jose", "jose@gmail.com"), assMensagem),
                new NaoAssinante(new Pessoa(04, "Marcia", "marcia@gmail.com"), naoAssMensagem),
            };

            ISujeito primeVideo = new PrimeVideo(observavel);
            primeVideo.Notificar();

            var novo = new NaoAssinante(new Pessoa(06, "Maria", "maria@gmail.com"), naoAssMensagem);
            System.Console.WriteLine("\n\n");
            System.Console.WriteLine($"Adicionando nova assinante {novo.Pessoa.Nome}");
            System.Console.WriteLine("Notificando assinante novo !!!");
            primeVideo.NotificarInscricao(novo);
        }

    }
}