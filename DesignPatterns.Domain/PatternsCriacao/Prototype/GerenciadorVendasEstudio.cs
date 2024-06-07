namespace DesignPatterns.Domain.PatternsCriacao.Prototype
{
    public class GerenciadorVendasEstudio
    {
        private Dictionary<string, EstudioModel> _estudioModel = new();

        public EstudioModel this[string key]
        {
            get { return _estudioModel[key]; }
            set { _estudioModel[key] = value; }
        }
    }
}