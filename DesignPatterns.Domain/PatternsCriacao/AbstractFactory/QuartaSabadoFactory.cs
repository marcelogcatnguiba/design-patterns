using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;
using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            CriarRotinaDiaria();
        }

        public void CriarRotinaDiaria()
        {
            DietaQuartaSabado dieta = new DietaQuartaSabado();
            TreinoQuartaSabado treino = new TreinoQuartaSabado();

            dieta.ObterDieta();
            treino.ObterTreino();
        }
    }
}