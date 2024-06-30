using DesignPatterns.Domain.PatternComportamental.Iterator.Interfaces;

namespace DesignPatterns.Domain.PatternComportamental.Iterator
{
    public class Iterator : IIterator
    {
        private IAggregate _aggregate;
        private int _position;

        public Iterator(IAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public string Next
        {
            get => _aggregate[_position++];
        }

        public bool HasNext
        {
            get => _position <= _aggregate.Limit;
        }
    }
}