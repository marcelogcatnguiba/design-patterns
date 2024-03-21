using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Armas;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Prefixos
{
    public class AumentarAtaque : IPrefixo
    {
        private int _valorAumento;

        public AumentarAtaque(int valorAumento)
        {
            _valorAumento = valorAumento;
        }

        public void CarregarAfixos(Espada espada)
        {
            espada.Afixo += $"\n[P] - Aumenta ataque em {_valorAumento}";
            espada.Ataque += _valorAumento;
        }
    }
}