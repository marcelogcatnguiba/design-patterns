using DesignPatterns.Domain.PatternComportamental.Strategy.Enum;

namespace DesignPatterns.Domain.PatternComportamental.Strategy.Model
{
    public class Orcamento
    {
        public int IdCliente { get; set; }
        public double ValorDiaria { get; set; }
        public int QtdeDias { get; set; }
        public double ValorTotal { get; set; }
        public bool CupomDesconto { get; set; } = false;
        public TipoSuite Porcentagem { get; set; }

        public Orcamento(int idCliente, double valorDiaria, int qtdeDias, TipoSuite porcentagem, bool cupomDesconto = false)
        {
            IdCliente = idCliente;
            ValorDiaria = valorDiaria;
            QtdeDias = qtdeDias;
            Porcentagem = porcentagem;
            CupomDesconto = cupomDesconto;

            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {
           ValorTotal = ValorDiaria * QtdeDias;
        }
    }
}