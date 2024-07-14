using System;



    public class Player
    {
        private static Random random = new Random();
        private static Dice dice = new Dice();
        private static IDictionary<string,int> stats = new Dictionary<string,int>{};

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
            return rolls[0] + rolls[1] + rolls[2];
        }

        // Method to calculate the modifier for a given ability score
        public static int CalculateModifier(int abilityScore)
        {
            return (abilityScore - 10) / 2;
        }

        public void CreateStats()
        {
            stats["Strength"] = 5;
            string[] statNames = {"Str", "Dex", "Con", "Int", "Wis", "Cha"};
            foreach (string s in statNames)
            {
                int abilityScore = RollStat();
                stats[s] = CalculateModifier(abilityScore);
                DisplayStatWithModifier(s,abilityScore,stats[s]);
            }
        }

        // Method to display the ability score and its modifier
        public static void DisplayStatWithModifier(string statName, int abilityScore, int modifier)
        {

            Console.WriteLine($"{statName}: Rolled Stat: {abilityScore}, Modifier: {modifier}");

        }
    }


    




        //race fun 

        //human +1 to all stat
        //elf +2 dex and +1 wis
        //dwarf +2 con and +1 wis
        //dragonborn +2 str and +1 chr

        //inventory
        // all player heath is 20+ con and all player armor is 15

    
