namespace DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji
{
    public class Contexto
    {
        public string Personagem { get; set; } = "";
        public string Conteudo { get; set; } = "";

        public Contexto(string personagem)
        {
            Personagem = personagem;
            Conteudo = string.Empty;
        }
    }
}