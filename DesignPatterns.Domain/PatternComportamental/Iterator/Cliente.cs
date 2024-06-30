using DesignPatterns.Domain.PatternComportamental.Iterator.Interfaces;

namespace DesignPatterns.Domain.PatternComportamental.Iterator
{
    public class Cliente
    {
        public static void ConsumirEstrutura()
        {
            Aggregate aggregate = new();

            aggregate[0] = "Item 01";
            aggregate[1] = "Item 02";
            aggregate[2] = "Item 03";

            IIterator iterator = aggregate.GetIterator();

            for(string item = iterator.Next; iterator.HasNext; item = iterator.Next)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}