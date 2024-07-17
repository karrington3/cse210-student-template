public class Rapier : Weapon
{private static Dice dice = new Dice();
    public Rapier() : base("Rapier", "A light, quick weapon that uses Dexterity.", 8) { }

    public override int CalculateDamage(int dexModifier)
    {
        return Damage + dexModifier;
    }

    public override void Use()
    {
        Console.WriteLine($"You use the {Name}. It deals {Damage} damage plus Dexterity modifier.");
    }
}