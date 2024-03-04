using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsCriacao.Builder.Construtores;

namespace DesignPatterns.Domain.PatternsCriacao.Builder
{
    public class Director
    {
        public void ConstruirEstudio(EstudioBuilder builder)
        {
            builder.EscolherPiso();
            builder.EscolherFinanciamento();
            builder.DefinirValorEstudio();
        }
    }
}