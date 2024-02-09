using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Interfaces;
using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Servicos;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            CriarRotinaDiaria();
        }
        public void CriarRotinaDiaria()
        {
            DietaTercaSexta dieta = new DietaTercaSexta();
            TreinoTercaSexta treino = new TreinoTercaSexta();

            dieta.ObterDieta();
            treino.ObterTreino();

        }
    }
}