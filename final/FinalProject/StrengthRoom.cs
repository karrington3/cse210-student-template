public class StrengthRoom : Event
{
    public StrengthRoom(int dc)
    {
        DifficultyCheck = dc;
    }

    public override void TriggerGoodEvent()
    {
        Console.WriteLine("You passed the Strength check. Good event triggered!");
    }

    public override void TriggerBadEvent()
    {
        Console.WriteLine("You failed the Strength check. Bad event triggered!");
    }
}