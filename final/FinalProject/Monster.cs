using System;
using System.Collections.Generic;

namespace DnD
{
    public class Monster
    {
        // Properties
        public string Name { get; set; }
        public int HP { get; set; }
        public int ArmorClass { get; set; }
        public int AttackPower { get; set; }
        public List<string> Abilities { get; set; }
        public List<string> Drops { get; set; }

        // Constructor
        public Monster(string name, int hp, int armorClass, int attackPower, List<string> abilities, List<string> drops)
        {
            Name = name;
            HP = hp;
            ArmorClass = armorClass;
            AttackPower = attackPower;
            Abilities = abilities;
            Drops = drops;
        }

        // Method to display monster information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Armor Class: {ArmorClass}");
            Console.WriteLine($"Attack Power: {AttackPower}");
            Console.WriteLine("Abilities: " + string.Join(", ", Abilities));
            Console.WriteLine("Drops: " + string.Join(", ", Drops));
        }

        // Method to simulate an attack
        public void Attack()
        {
            Console.WriteLine($"{Name} attacks with power {AttackPower}!");
        }
    }

    class Monster1
    {
        static void Main2(string[] args)
        {
            // Example monster
            List<string> goblinAbilities = new List<string> { "Sneak Attack", "Evasion" };
            List<string> goblinDrops = new List<string> { "Gold Coin", "Dagger" };
            Monster goblin = new Monster("Goblin", 30, 15, 5, goblinAbilities, goblinDrops);

            // Display monster info
            goblin.DisplayInfo();

            // Simulate an attack
            goblin.Attack();
        }
    }
}