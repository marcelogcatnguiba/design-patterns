using DesignPatterns.Domain.PatternComportamental.Observer.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Observer.Observers;

namespace DesignPatterns.Domain.PatternComportamental.Observer.Subjects
{
    public class PrimeVideo : ISujeito
    {
        public IList<IObservavel> Observaveis { get; set; } = null!;
        public PrimeVideo(IList<IObservavel> observaveis)
        {
            Observaveis = observaveis;
        }

        public void Adicionar(IObservavel observavel)
        {
            if (observavel.GetType() == typeof(NaoAssinante))
            {
                Observaveis.Add(observavel);
                NotificarInscricao(observavel);

            }
            Observaveis.Add(observavel);
        }

        public void Notificar()
        {
            foreach (var ob in Observaveis)
            {
                ob.Update();
                System.Console.WriteLine(new string('-', 50));
            }
        }

        public void Remover(IObservavel observavel)
        {
            Observaveis.Remove(observavel);
        }

        public void NotificarInscricao(IObservavel observavel)
        {
            var assinante = (NaoAssinante)observavel;
            System.Console.WriteLine($"Obrigado {assinante.Pessoa.Nome} por se inscrever !!, desfrute das melhores series e videos aqui");
        }
    }
}