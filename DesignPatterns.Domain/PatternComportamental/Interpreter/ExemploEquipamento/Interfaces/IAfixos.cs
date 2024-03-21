using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Armas;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Interfaces
{
    public interface IAfixos
    {
        void CarregarAfixos(Espada espada);
    }
}