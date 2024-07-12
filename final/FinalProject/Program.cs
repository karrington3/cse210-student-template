using System;
using DnDStatRoller;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        
            // Example usage: roll stats and display their modifiers
            for (int i = 0; i < 6; i++)
            {
                Player.DisplayStatWithModifier();
            }
    }
}