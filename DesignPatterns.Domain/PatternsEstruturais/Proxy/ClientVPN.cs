using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Proxy.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Proxy
{
    public class ClientVPN
    {
        public void TentarConexaoVPN()
        {
            var vpnProxy = new VPNProxy();

            System.Console.Write("Digite o user name: ");
            var userName = Console.ReadLine();

            System.Console.Write("Digite o password: ");
            var pass = Console.ReadLine();

            var user = new User(userName!, pass!);
            vpnProxy.AcessarVPN(user);
        }
    }
}