namespace DesignPatterns.Domain.PatternComportamental.Memento
{
    public class Videocassete
    {
        public static void ExecutarAcaoVideo()
        {
            Originator originator = new();
            originator.Estado = "play";

            Caretaker caretaker = new();
            caretaker.AddSnapshot(originator.CreateSnapShot());

            originator.Estado = "pause";

            originator.Restore(caretaker.GetSnapshot()!);
        }
    }
}