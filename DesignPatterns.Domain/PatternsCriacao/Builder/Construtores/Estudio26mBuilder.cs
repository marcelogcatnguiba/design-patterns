using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsCriacao.Builder.Estudios;

namespace DesignPatterns.Domain.PatternsCriacao.Builder.Construtores
{
    public class Estudio26mBuilder : EstudioBuilder
    {
        public Estudio26mBuilder()
        {
            estudio = new Estudio26m();
        }
        public override void DefinirValorEstudio()
        {
            estudio.DefinirValorEstudio(200000.00M);
        }

        public override void EscolherFinanciamento()
        {
            estudio.EscolherFinanciamento("Financiamentos Marabraz");
        }

        public override void EscolherPiso()
        {
            estudio.EscolherPiso("Porcelanato");
        }
    }
}