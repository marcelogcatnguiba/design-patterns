using DesignPatterns.Domain.PatternComportamental.Observer.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Observer.Models;

namespace DesignPatterns.Domain.PatternComportamental.Observer.Observers
{

    public class Assinante : IObservavel
    {
        public Pessoa Pessoa { get; set; }
        public string Mensagem { get; set; }
        public Assinante(Pessoa pessoa, string mensagem)
        {
            Pessoa = pessoa;
            Mensagem = mensagem;
        }

        public void Update()
        {
            //simula envio de email
            System.Console.WriteLine($"Enviando email para: {Pessoa.Email}");
            System.Console.WriteLine($"Mensagem: {Mensagem}");

            //insert no banco
            System.Console.WriteLine($"INSERT INTO TB_NOTIFICATIONS VALUES('{Pessoa.Nome}', '{Pessoa.Email}', '{Mensagem}')");
        }
    }
}