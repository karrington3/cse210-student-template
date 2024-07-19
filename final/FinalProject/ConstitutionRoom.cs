public class ConstitutionRoom : Event
{
    public ConstitutionRoom(int dc)
    {
        DifficultyCheck = dc;
    }

    public override void TriggerGoodEvent()
    {
        Console.WriteLine("You passed the Constitution check. Good event triggered!");
    }

    public override void TriggerBadEvent()
    {
        Console.WriteLine("You failed the Constitution check. Bad event triggered!");
    }
}