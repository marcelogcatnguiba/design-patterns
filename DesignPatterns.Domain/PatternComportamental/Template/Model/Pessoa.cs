namespace DesignPatterns.Domain.PatternComportamental.Template.Model
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public List<Acoes> Acoes { get; set; } = [];
    }
}