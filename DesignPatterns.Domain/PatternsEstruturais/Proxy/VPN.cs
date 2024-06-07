using DesignPatterns.Domain.PatternsEstruturais.Proxy.Interfaces;
using DesignPatterns.Domain.PatternsEstruturais.Proxy.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Proxy
{
    public class VPN : IProxy
    {
        public void AcessarVPN(User user)
        {
            System.Console.WriteLine("[+] Acessando VPN\n");
            Thread.Sleep(2000);

            System.Console.WriteLine($"{user.UserName} você esta logado na VPN");
        }
    }
}