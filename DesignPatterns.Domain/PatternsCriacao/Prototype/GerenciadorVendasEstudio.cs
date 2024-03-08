using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternsCriacao.Prototype
{
    public class GerenciadorVendasEstudio
    {
        private Dictionary<string, EstudioModel> _estudioModel = new();

        public EstudioModel this[string key]
        {
            get { return _estudioModel[key]; }
            set { _estudioModel[key] = value; }
        }
    }
}