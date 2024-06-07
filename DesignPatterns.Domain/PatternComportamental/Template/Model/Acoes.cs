namespace DesignPatterns.Domain.PatternComportamental.Template.Model
{
    public class Acoes
    {
        public string Sigla { get; set; } = string.Empty;
        public int Qtde { get; set; }
        public double ValorUnitario { get; set; }
        public double TotalAcao { get => Qtde * ValorUnitario; }

        public Acoes()
        {
            
        }
        public Acoes(string sigla, int qtde, double valorUnitario)
        {
            Sigla = sigla;
            Qtde = qtde;
            ValorUnitario = valorUnitario;
        }

        public override string ToString()
        {
            return $"Sigla: {Sigla}\nQtde: {Qtde}\nValor Unitario: {ValorUnitario:C}\nValor Total: {TotalAcao:C}";
        }
    }
}