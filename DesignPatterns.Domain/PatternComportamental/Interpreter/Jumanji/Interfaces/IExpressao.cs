using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji.Interfaces
{
    public interface IExpressao
    {
        void Interpretar(Contexto contexto);
    }
}