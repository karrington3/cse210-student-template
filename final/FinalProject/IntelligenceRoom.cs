public class IntelligenceRoom : Event
{
    public IntelligenceRoom(int dc)
    {
        DifficultyCheck = dc;
    }

    public override void TriggerGoodEvent()
    {
        Console.WriteLine("You passed the Intelligence check. Good event triggered!");
    }

    public override void TriggerBadEvent()
    {
        Console.WriteLine("You failed the Intelligence check. Bad event triggered!");
    }
}
