using DesignPatterns.Domain.PatternComportamental.Template.AbstractModel;
using DesignPatterns.Domain.PatternComportamental.Template.Model;
using System.Xml.Serialization;
using System.Xml;

namespace DesignPatterns.Domain.PatternComportamental.Template
{
    public class ConvertXML(string xml) : ProcessaDados(xml)
    {
        public override void ProcessarXML()
        {
            XmlSerializer deserializer = new (typeof(List<Pessoa>));
            var stringReader = new StringReader(xml);

            using (var reader = XmlReader.Create(stringReader))
            {
                try
                {
                    this.pessoas = (List<Pessoa>)deserializer.Deserialize(reader)!;
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }

            ApresentarValores();
        }
    }
}