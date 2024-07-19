
public class DexterityRoom : Event
{
    public DexterityRoom(int dc)
    {
        DifficultyCheck = dc;
        roomStat = "Dex";
    }

    public override void TriggerGoodEvent()
    {
        Console.WriteLine("You passed the Dexterity check. Good event triggered!");
    }

    public override void TriggerBadEvent()
    {
        Console.WriteLine("You failed the Dexterity check. Bad event triggered!");
    }
}