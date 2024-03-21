using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji
{
    public class Contexto
    {
        public string Personagem { get; set; } = "";
        public string Conteudo { get; set; } = "";

        public Contexto(string personagem)
        {
            Personagem = personagem;
            Conteudo = string.Empty;
        }
    }
}