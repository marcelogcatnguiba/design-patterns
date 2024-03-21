using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Armas
{
    public sealed class EspadaCurta : Espada
    {
        public EspadaCurta(string nome, int ataque, decimal velocidadeAtaque) : base(nome, ataque, velocidadeAtaque)
        {
        }
    }
}