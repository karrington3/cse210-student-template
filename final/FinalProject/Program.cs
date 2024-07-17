using System;
using System.Reflection.Metadata;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello with to stat Dungeon");
        Console.WriteLine("pess any key to begin");
        Console.ReadKey();
        
        // get user input, put it into a variable x
        // define a variable to hold the race enum x
        // use a switch or series of if statements x
        // in the if or switch statement, set the race variable with the corresponding race enum value x
        // Use the race variable in the CreateStats function below

        Console.WriteLine("pick a Race : 1.Human  2.Elf 3.dragonborn 4.dwarf ");
        ConsoleKey choice;
        choice = Console.ReadKey().Key;


    Player.Race HoldR;
    
    
    switch (choice)
        {
            case ConsoleKey.NumPad1:
                
                HoldR = Player.Race.Human ;
                break;
            case ConsoleKey.NumPad2:
                HoldR = Player.Race.Elf;
                break;
            case ConsoleKey.NumPad3 :
                HoldR=Player.Race.Dragonborn;
                break;
            case ConsoleKey.NumPad4 :
                HoldR=Player.Race.Dwarf;
                break;
            default:
                HoldR = Player.Race.Human ;
                Console.WriteLine("dude that a human move messing up so your a human now.");
                break;

        }
        
        Console.WriteLine("let roll your stat");
        Player myCharacter = new Player();
        
        bool reroll =true;
        while(reroll) 
        {
            reroll = false;
            myCharacter.CreateStats(HoldR);
            Console.WriteLine("would you like to reroll :(  |Y/N|");
            if (Console.ReadKey(intercept: true).Key ==  ConsoleKey.Y)
            {
                reroll = true;
            }
        }
        
        
        
        //TODO
        Console.WriteLine("time to enter the STAT DUNGEON!");
        //TODO  game

    }
}
