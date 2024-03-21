using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Armas;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Prefixos;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Sulfixos;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento
{
    public class AplicaAfixos : IAfixos
    {
        private readonly IList<IPrefixo> _prefixo;
        private readonly IList<ISulfixo> _sulfixo;

        public AplicaAfixos(IList<IPrefixo> prefixo, IList<ISulfixo> sulfixo)
        {
            _prefixo = prefixo;
            _sulfixo = sulfixo;
        }

        public void CarregarAfixos(Espada espada)
        {
            System.Console.WriteLine($"Espada antes dos afixo aplicados:");
            System.Console.WriteLine(espada);

            System.Console.WriteLine("\n\nAplicando afixos ...");
            System.Console.WriteLine("Lendo prefixos ...");
            foreach (var p in _prefixo)
                p.CarregarAfixos(espada);

            System.Console.WriteLine("Lendo sulfixos ...\n\n");
            foreach (var s in _sulfixo)
                s.CarregarAfixos(espada);

            System.Console.WriteLine("Apos aplicar os afixos:");
            System.Console.WriteLine(espada);

        }
    }
}