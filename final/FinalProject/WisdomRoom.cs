public class WisdomRoom : Event
{
    public WisdomRoom(int dc)
    {
        DifficultyCheck = dc;
    }

    public override void TriggerGoodEvent()
    {
        Console.WriteLine("You passed the Wisdom check. Good event triggered!");
    }

    public override void TriggerBadEvent()
    {
        Console.WriteLine("You failed the Wisdom check. Bad event triggered!");
    }
}