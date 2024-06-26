namespace DesignPatterns.Domain.PatternsEstruturais.Proxy.Model
{
    public class User
    {
        public string UserName { get; private set; } = "";
        public string Password { get; private set; } = "";

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}