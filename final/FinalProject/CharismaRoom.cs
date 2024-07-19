public class CharismaRoom : Event
{
    public CharismaRoom(int dc)
    {
        DifficultyCheck = dc;
    }

    public override void TriggerGoodEvent()
    {
        Console.WriteLine("You passed the Charisma check. Good event triggered!");
    }

    public override void TriggerBadEvent()
    {
        Console.WriteLine("You failed the Charisma check. Bad event triggered!");
    }
}
