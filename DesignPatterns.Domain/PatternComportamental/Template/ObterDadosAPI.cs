using System.Xml.Serialization;
using DesignPatterns.Domain.PatternComportamental.Template.Model;
using Newtonsoft.Json;

namespace DesignPatterns.Domain.PatternComportamental.Template
{
    public class ObterDadosAPI
    {
        public static string EndpointXML()
        {
            List<Pessoa> pessoas = GetPessoas();
            XmlSerializer serializer = new(typeof(List<Pessoa>));
            string xml = string.Empty;

            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, pessoas);
                xml = sw.ToString();
            }

            return xml;
        }

        public static string EndpointJSON()
        {
            List<Pessoa> pessoas = GetPessoas();
            var json = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            return json;
        }

        private static List<Pessoa> GetPessoas()
        {
            return new() 
            {
                new Pessoa() 
                {   Nome = "Jose", 
                    CPF = "245.245.245-09", 
                    Acoes = new List<Acoes>() 
                        {
                            new() 
                            {
                                Sigla = "AAB",
                                Qtde = 100,
                                ValorUnitario = 10
                            },
                            new() 
                            {
                                Sigla = "ACC",
                                Qtde = 50,
                                ValorUnitario = 34.5
                            },
                        }
                },

                new Pessoa() 
                {   Nome = "Maria", 
                    CPF = "245.245.245-09", 
                    Acoes = new List<Acoes>() 
                        {
                            new() 
                            {
                                Sigla = "CCC",
                                Qtde = 90,
                                ValorUnitario = 9
                            },
                            new() 
                            {
                                Sigla = "KJS",
                                Qtde = 99,
                                ValorUnitario = 77
                            },
                        }
                }
            };
        }
             
    }
}