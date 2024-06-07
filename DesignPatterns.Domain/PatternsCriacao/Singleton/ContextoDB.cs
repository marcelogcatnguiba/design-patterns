namespace DesignPatterns.Domain.PatternsCriacao.Singleton
{
    public class ContextoDB
    {
        private static ContextoDB? _instancia;
        public static ContextoDB Instancia { get { return _instancia == null ? _instancia = new ContextoDB() : _instancia; } }

        private ContextoDB()
        {
            System.Console.WriteLine("Criando instancia de ContextoDB");
        }

        public void ExecutaQuery(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}