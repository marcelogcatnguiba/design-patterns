using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Proxy.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Proxy.Interfaces
{
    public interface IProxy
    {
        public void AcessarVPN(User user);
    }
}