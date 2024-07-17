
using System;
using System.Collections.Generic;

public class Player
{
    private static Random random = new Random();
    private static Dice dice = new Dice();
    private static IDictionary<string, int> stats = new Dictionary<string, int>();

    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Dragonborn
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
            stats[s] = abilityScore;
            DisplayStatWithModifier(s, abilityScore, CalculateModifier(abilityScore));
        }
        ApplyRaceModifiers(race);
        foreach (var stat in stats)
        {
            Console.WriteLine("with race modifers");
        
            DisplayStatWithModifier(stat.Key, stat.Value, CalculateModifier(stat.Value));
        }
    }

    // Method to display the ability score and its modifier
    public static void DisplayStatWithModifier(string statName, int abilityScore, int modifier)
    {
        Console.WriteLine($"{statName}: Rolled Stat: {abilityScore}, Modifier: {modifier}");
    }
}
