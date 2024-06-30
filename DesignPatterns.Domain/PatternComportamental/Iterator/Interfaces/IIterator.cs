namespace DesignPatterns.Domain.PatternComportamental.Iterator.Interfaces
{
    public interface IIterator
    {
        string Next { get; }
        bool HasNext { get; }
    }
}