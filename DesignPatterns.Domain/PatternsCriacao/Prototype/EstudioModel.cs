using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternsCriacao.Prototype
{
    public abstract class EstudioModel
    {
        public abstract EstudioModel? Clone();
    }
}