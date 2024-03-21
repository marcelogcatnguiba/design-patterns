using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji
{
    public class ApresentaPopUp
    {
        public void ApresentarHabilidades()
        {
            List<IPontoForte> pontoFortes = new()
            {
                new Armeiro(),
                new Zoologia()
            };

            List<IPontoFraco> pontoFracos = new(){
                new Bolo(),
                new Forca(),
                new Velocidade()
            };

            var mooseFinbar = new Contexto("Moose Finbar");
            Habilidades habilidades = new Habilidades(pontoFortes, pontoFracos);
            habilidades.Interpretar(mooseFinbar);
        }
    }
}