namespace DesignPatterns.Domain.PatternsEstruturais.Composite.Model
{
    public abstract class ComponentModel
    {
        public abstract double Operacao();
        public abstract void Add(params ComponentModel[] components);
        public abstract void Remove(ComponentModel components);
        public abstract ComponentModel? GetChild(int index);
    }
}