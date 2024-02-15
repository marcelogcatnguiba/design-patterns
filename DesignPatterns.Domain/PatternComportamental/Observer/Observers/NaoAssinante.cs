using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternComportamental.Observer.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Observer.Models;

namespace DesignPatterns.Domain.PatternComportamental.Observer.Observers
{
    public class NaoAssinante : IObservavel
    {
        public Pessoa Pessoa { get; set; } = null!;
        public string Mensagem { get; set; } = string.Empty;
        public NaoAssinante(Pessoa pessoa, string mensagem)
        {
            Pessoa = pessoa;
            Mensagem = mensagem;
        }
        public void Update()
        {
            // simula envio de email
            System.Console.WriteLine($"Enviando email para: {Pessoa.Email}");
            System.Console.WriteLine($"Mensagem: {Mensagem}");

            //insert no banco
            System.Console.WriteLine($"INSERT INTO TB_NOTIFICATIONS VALUES('{Pessoa.Nome}', '{Pessoa.Email}', '{Mensagem}')");
        }
    }
}