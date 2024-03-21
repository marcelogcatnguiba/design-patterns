using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Flyweight.Flyweights;
using DesignPatterns.Domain.PatternsEstruturais.Flyweight.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Nave> _listaNaves = new();
        public Nave GetNave(string cor)
        {
            Nave? nave = null;

            if (_listaNaves.ContainsKey(cor))
            {
                nave = _listaNaves[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul":
                        nave = new NaveAzul();
                        break;
                    case "cinza":
                        nave = new NaveCinza();
                        break;
                    case "vermelha":
                        nave = new NaveVermelha();
                        break;
                }
                _listaNaves.Add(cor, nave!);
            }

            return nave!;
        }
    }
}