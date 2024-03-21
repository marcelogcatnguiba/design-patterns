using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Armas;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Sulfixos;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Sulfixos
{
    public class VelocidadeDeAtaque : ISulfixo
    {
        private decimal _valorAumento;

        public VelocidadeDeAtaque(decimal valorAumento)
        {
            _valorAumento = valorAumento;
        }

        public void CarregarAfixos(Espada espada)
        {
            espada.Afixo += $"\n[S] - Aumenta velocida de ataque em {_valorAumento}";
            espada.VelocidadeAtaque += _valorAumento;
        }
    }
}