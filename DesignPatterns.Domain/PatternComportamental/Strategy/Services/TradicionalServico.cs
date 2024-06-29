using DesignPatterns.Domain.PatternComportamental.Strategy.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Strategy.Model;

namespace DesignPatterns.Domain.PatternComportamental.Strategy.Services
{
    public class TradicionalServico(Orcamento orcamento) : IServico
    {
        private readonly Orcamento _orcamento = orcamento;
        public void CalcularServico()
        {
            var porcentagemServico = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagemServico;

            if(_orcamento.CupomDesconto)
            {
                System.Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal:C}");

                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.01;

                System.Console.WriteLine($"\nConta com cupom de desconto recebe 1% de desconto para {_orcamento.Porcentagem}");
            }

            System.Console.WriteLine
            (
                $"Tipo quarto: {_orcamento.Porcentagem}\n" +
                $"Porcentagem Servico: {porcentagemServico:C}\n" +
                $"Quant. Dias: {_orcamento.QtdeDias}\n" +
                $"Valor dia: {_orcamento.ValorDiaria}\n" +
                $"Valor Total: {_orcamento.ValorTotal}\n"
            );
        }
    }
}