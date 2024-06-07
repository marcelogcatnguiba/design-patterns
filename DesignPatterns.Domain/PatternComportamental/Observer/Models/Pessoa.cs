namespace DesignPatterns.Domain.PatternComportamental.Observer.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Email { get; set; } = string.Empty;
        public Pessoa(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }


    }
}