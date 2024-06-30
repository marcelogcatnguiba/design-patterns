namespace DesignPatterns.Domain.PatternComportamental.Memento
{
    public class Originator
    {
        private string _estado = string.Empty;

        public string Estado 
        { 
            get => _estado; 
            set 
            {
                _estado = value;
                System.Console.WriteLine($"Estado atual do video {_estado}");
            }
        }

        public Snapshot CreateSnapShot()
        {
            return new Snapshot(_estado);
        }

        public void Restore(Snapshot snapshot)
        {
            System.Console.WriteLine("Restaurando estado ...");
            Estado = snapshot.GetEstado();
        }
    }
}