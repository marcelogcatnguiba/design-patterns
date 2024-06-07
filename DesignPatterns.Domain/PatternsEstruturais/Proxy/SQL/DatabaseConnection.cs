using DesignPatterns.Domain.PatternsEstruturais.Proxy.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Proxy.SQL
{
    public class DatabaseConnection
    {
        public void RegistrarAcessoVPN(User user)
        {
            string query = $"INSERT INTO TB_REGISTRO VALUES ('{user.UserName}', '{user.Password}', '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}')";

            System.Console.WriteLine("\n[!] Registrando acesso pelo proxy ...\n");
            System.Console.WriteLine(query);
        }
    }
}