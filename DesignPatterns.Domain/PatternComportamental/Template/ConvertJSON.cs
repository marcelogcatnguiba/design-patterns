using DesignPatterns.Domain.PatternComportamental.Template.AbstractModel;
using DesignPatterns.Domain.PatternComportamental.Template.Model;
using Newtonsoft.Json;

namespace DesignPatterns.Domain.PatternComportamental.Template
{
    public class ConvertJSON(string json) : ProcessaDados(json: json)
    {
        public override void ProcessarJSON()
        {
            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(json)!;
            ApresentarValores();
        }
    }
}