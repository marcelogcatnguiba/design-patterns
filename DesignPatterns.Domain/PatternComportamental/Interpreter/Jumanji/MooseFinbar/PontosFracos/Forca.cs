using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos
{
    public class Forca : IPontoFraco
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "[-] - Força\n";
        }
    }
}