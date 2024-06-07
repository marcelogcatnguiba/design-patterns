using DesignPatterns.Domain.PatternsEstruturais.Composite.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Composite
{
    public class ProdutoComposite : ComponentModel
    {
        private List<ComponentModel> _component;

        public ProdutoComposite()
        {
            _component = new List<ComponentModel>();
        }

        public override void Add(params ComponentModel[] components)
        {
            _component.AddRange(components);
        }

        public override ComponentModel? GetChild(int index)
        {
            if (_component.Count == 0)
            {
                System.Console.WriteLine("Nao possui produtos cadastrados");
                return null;
            }

            return _component[index];
        }

        public override double Operacao()
        {
            double result = 0;

            for (int i = 0; i < _component.Count; i++)
            {
                var component = _component[i];
                result += component.Operacao();
            }

            return result;
        }

        public override void Remove(ComponentModel components)
        {
            _component.Remove(components);
        }
    }
}