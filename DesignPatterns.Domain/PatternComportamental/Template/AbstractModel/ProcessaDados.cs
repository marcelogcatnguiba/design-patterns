using DesignPatterns.Domain.PatternComportamental.Template.Model;

namespace DesignPatterns.Domain.PatternComportamental.Template.AbstractModel
{
    public abstract class ProcessaDados(string json = "", string xml = "")
    {
        protected List<Pessoa> pessoas = [];
        protected string xml = xml;
        protected string json = json;

        public virtual void ProcessarXML()
        {

        }

        public virtual void ProcessarJSON()
        {

        }

        protected void ApresentarValores()
        {
            foreach(var pessoa in pessoas)
            {
                System.Console.WriteLine($"\nCliente: {pessoa.Nome}");

                double valorTotal = 0;
                foreach(var acao in pessoa.Acoes)
                {
                    System.Console.WriteLine(new string('-', 30));
                    System.Console.WriteLine(acao);
                    valorTotal += acao.TotalAcao;                
                }

                System.Console.WriteLine($"\nTotal em Acoes: {valorTotal:C}");
            }
        }
    }
}