namespace DesignPatterns.Domain.PatternsCriacao.Prototype
{
    public class Estudio : EstudioModel
    {
        private string _tipoEstudio;
        private string _tipoFinanciamento;
        private decimal _valorEstudio;

        public Estudio(string tipoEstudio, string tipoFinanciamento, decimal valorEstudio)
        {
            _tipoEstudio = tipoEstudio;
            _tipoFinanciamento = tipoFinanciamento;
            _valorEstudio = valorEstudio;
        }

        public override EstudioModel? Clone()
        {
            System.Console.WriteLine(new string('-', 40));
            System.Console.WriteLine($"Estudio clonado : {_tipoEstudio}\nTipo financiamento: {_tipoFinanciamento}\nValor estudio: {_valorEstudio.ToString("C")}");

            return MemberwiseClone() as EstudioModel;
        }
    }
}