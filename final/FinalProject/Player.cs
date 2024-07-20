
using System;
using System.Collections.Generic;
using System.Linq;
public class Player
{
    private static Random random = new Random();
    private static Dice dice = new Dice();
    private static IDictionary<string, int> stats = new Dictionary<string, int>();
    public int getStat(string key)
    {
        return stats[key];
    }

    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Dragonborn
    }


    private int health;
     // Property to get the health value
    public int getHealth()
    {
        return health;
    }
    public void damage()
    {
        health -= 4;
    }
    
    // Method to roll a single die with a given number of sides
    public static int RollDie(int sides)
    {
        return random.Next(1, sides + 1);
    }

    // Method to roll 4d6 and drop the lowest die roll
    public static int RollStat()
    {
        int[] rolls = new int[4];
        for (int i = 0; i < 4; i++)
        {
            rolls[i] = dice.rollD6();
        }
        Array.Sort(rolls);
        return rolls[1] + rolls[2] + rolls[3]; // sum of the top 3 rolls
    }

    // Method to calculate the modifier for a given ability score
    public static int CalculateModifier(int abilityScore)
    {
        return (abilityScore - 10) / 2;
    }

    // Method to apply race modifiers
    public static void ApplyRaceModifiers(Race race)
    {
        switch (race)
        {
            case Race.Human:
                foreach (var key in stats.Keys.ToList())
                {
                    stats[key] += 1;
                }
                break;
            case Race.Elf:
                stats["Dex"] += 2;
                stats["Wis"] += 1;
                break;
            case Race.Dwarf:
                stats["Con"] += 2;
                stats["Wis"] += 1;
                break;
            case Race.Dragonborn:
                stats["Str"] += 2;
                stats["Cha"] += 1;
                break;
        }
    }

    public void CreateStats(Race race)
    {
        string[] statNames = { "Str", "Dex", "Con", "Int", "Wis", "Cha" };
        foreach (string s in statNames)
        {
            int abilityScore = RollStat();
            stats[s] = CalculateModifier(abilityScore);
            DisplayStatWithModifier(s, abilityScore, CalculateModifier(abilityScore));
        }    Console.WriteLine("with race modifers");
        ApplyRaceModifiers(race);
        foreach (var stat in stats)
        {
        
            Console.WriteLine($"{stat.Key}: Modifier: {stat.Value}");

        }
        // Calculate health with Constitution modifier
                int conModifier = (stats["Con"]);
                health = 20 + conModifier;
                Console.WriteLine($"Health: {health}");
    }

    // Method to display the ability score and its modifier
    public static void DisplayStatWithModifier(string statName, int abilityScore, int modifier)
    {
        Console.WriteLine($"{statName}: Rolled Stat: {abilityScore}, Modifier: {modifier}");
    }
}
