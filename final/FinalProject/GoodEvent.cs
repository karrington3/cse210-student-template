public class GoodEvent : Event
{
    public GoodEvent() : base(0) {} // GoodEvent does not need a difficulty check

    public void Trigger()
    {
        Console.WriteLine("Good event triggered!");
        // Additional logic for good event
    }
}