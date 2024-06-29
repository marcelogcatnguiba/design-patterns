using DesignPatterns.Domain.PatternComportamental.Strategy.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Strategy.Model;

namespace DesignPatterns.Domain.PatternComportamental.Strategy.Services
{
    public class MasterServico(Orcamento orcamento) : IServico
    {
        private readonly Orcamento _orcamento = orcamento;
        public void CalcularServico()
        {
            var porcentagemServico = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagemServico;

            if(_orcamento.CupomDesconto)
            {
                System.Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal:C}");

                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.02;

                System.Console.WriteLine($"\nConta com cupom de desconto recebe 2% de desconto para suite {_orcamento.Porcentagem}");
            }
            else if(_orcamento.CupomDesconto && _orcamento.QtdeDias >  60)
            {
                System.Console.WriteLine($"\n Valor sem desconto: {_orcamento.ValorTotal:C}");

                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.03;

                System.Console.WriteLine($"\n Conta superior a 60 dias recebe 3% de desconto para suite Master");
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