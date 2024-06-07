using DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji.Interfaces;
using DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji
{
    public class Habilidades : IExpressao
    {
        private readonly IList<IPontoForte> _listaPontosFortes;
        private readonly IList<IPontoFraco> _listaPontosFracos;

        public Habilidades(IList<IPontoForte> listaPontosFortes, IList<IPontoFraco> listaPontosFracos)
        {
            _listaPontosFortes = listaPontosFortes;
            _listaPontosFracos = listaPontosFracos;
        }

        public void Interpretar(Contexto contexto)
        {
            System.Console.WriteLine($"\nPersonagem : {contexto.Personagem}");

            contexto.Conteudo += "Exibindo abilidades...\n\nPontos Fortes\n\n";
            foreach (var forte in _listaPontosFortes)
                forte.Interpretar(contexto);

            contexto.Conteudo += "\nPontos Fracos\n";
            foreach (var fraco in _listaPontosFracos)
                fraco.Interpretar(contexto);

            System.Console.WriteLine(contexto.Conteudo);
        }
    }
}