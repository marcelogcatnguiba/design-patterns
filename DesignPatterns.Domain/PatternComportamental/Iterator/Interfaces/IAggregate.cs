namespace DesignPatterns.Domain.PatternComportamental.Iterator.Interfaces
{
    public interface IAggregate
    {
        public int Limit { get; }

        string this[int index] { get; set; }
        IIterator GetIterator();
    }
}