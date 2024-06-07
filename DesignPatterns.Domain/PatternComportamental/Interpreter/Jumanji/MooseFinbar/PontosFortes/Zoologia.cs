namespace DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes
{
    public class Zoologia : IPontoForte
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "[+] - Zoologo experiente\n";
        }
    }
}