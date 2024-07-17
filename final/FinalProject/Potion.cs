public class Potion : Item

{
    private static Dice dice = new Dice();
    public int HealingAmount { get; set; }

    // public Potion() : base("Healing Potion", "A potion that restores health.", rolls[i] = dice.rollD12();)
    // {
    //     HealingAmount = 20;
    // }
    public Potion() : base("Healing Potion", "A potion that restores health.")
    {
        HealingAmount = 20;
    }

    public override void Use()
    {
        // Console.WriteLine($"You drink the {Name}. It heals you for {HealingAmount} hit points.");
    }
}