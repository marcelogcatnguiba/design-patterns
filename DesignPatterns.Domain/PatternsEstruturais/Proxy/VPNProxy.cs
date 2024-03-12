using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Proxy.Interfaces;
using DesignPatterns.Domain.PatternsEstruturais.Proxy.Model;
using DesignPatterns.Domain.PatternsEstruturais.Proxy.SQL;

namespace DesignPatterns.Domain.PatternsEstruturais.Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            DatabaseConnection sql = new();
            VPN vpn = new();

            sql.RegistrarAcessoVPN(user);
            System.Console.WriteLine(new string('-', 40));

            vpn.AcessarVPN(user);
        }
    }
}