using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello with to stat Dungeon");
        Console.WriteLine("pess any key to begin");
        Console.ReadKey();
        Console.WriteLine("let roll your stat");
        Player myCharacter = new Player();
        
        bool reroll =true;
        while(reroll) 
        {
            reroll = false;
            myCharacter.CreateStats();
            Console.WriteLine("would you like to reroll :(  |Y/N|");
            if (Console.ReadKey(intercept: true).Key ==  ConsoleKey.Y)
            {
                reroll = true;
            }
        }
        
        Console.WriteLine("pick a class : 1.bard 2.fighter 3.wizard");
        //TODO alway class to be picked
        Console.WriteLine("time to enter the STAT DUNGEON!");
        //TODO  game

    }
}
