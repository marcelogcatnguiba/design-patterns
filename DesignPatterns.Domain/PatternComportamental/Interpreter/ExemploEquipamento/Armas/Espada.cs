using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Armas
{
    public abstract class Espada
    {
        public string Nome { get; set; } = "";
        public int Ataque { get; set; }
        public decimal VelocidadeAtaque { get; set; }
        public string Afixo { get; set; } = "";

        protected Espada(string nome, int ataque, decimal velocidadeAtaque)
        {
            Nome = nome;
            Ataque = ataque;
            VelocidadeAtaque = velocidadeAtaque;
            Afixo = string.Empty;
        }
        public override string ToString()
        {
            return $"Espada: {Nome}\nAtaque: {Ataque}\nVel. Ataque: {VelocidadeAtaque}\n"
                 + $"Afixos: {Afixo}";
        }
    }
}