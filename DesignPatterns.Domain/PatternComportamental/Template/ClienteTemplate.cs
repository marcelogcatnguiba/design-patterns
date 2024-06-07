namespace DesignPatterns.Domain.PatternComportamental.Template
{
    public class ClienteTemplate
    {
        public void ConsumirEndpointXML()
        {
            System.Console.WriteLine("\n----------XML----------");

            var xml = ObterDadosAPI.EndpointXML();
            ConvertXML convertXML = new(xml);

            convertXML.ProcessarXML();
        }

        public void ConsumirEndpointJSON()
        {
            System.Console.WriteLine("\n----------JSON----------");

            var json = ObterDadosAPI.EndpointJSON();
            ConvertJSON convertJSON = new(json);

            convertJSON.ProcessarJSON();
        }
    }
}