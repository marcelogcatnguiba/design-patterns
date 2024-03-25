using DesignPatterns.Domain.PatternsEstruturais.Proxy.Interfaces;
using DesignPatterns.Domain.PatternsEstruturais.Proxy.Model;
using DesignPatterns.Domain.PatternsEstruturais.Proxy.SQL;

namespace DesignPatterns.Domain.PatternsEstruturais.Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            //Execução do proxy
            DatabaseConnection sql = new();
            VPN vpn = new();
            sql.RegistrarAcessoVPN(user);

            System.Console.WriteLine(new string('-', 40));

            //Chamada da classe bs
            vpn.AcessarVPN(user);
        }
    }
}