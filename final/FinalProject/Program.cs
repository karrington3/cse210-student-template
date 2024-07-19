using System;
using System.Reflection.Metadata;


class Program

{
    static void Main(string[] args)
    
    {
        Dice dice = new Dice();
        Console.WriteLine("Hello with to stat Dungeon");
        Console.WriteLine("pess any key to begin");
        Console.ReadKey();
        
        // get user input, put it into a variable x
        // define a variable to hold the race enum x
        // use a switch or series of if statements x
        // in the if or switch statement, set the race variable with the corresponding race enum value x
        // Use the race variable in the CreateStats function below

        Console.WriteLine("pick a Race : 1.Human/+1 to all stats  2.Elf 3.dragonborn 4.dwarf ");
        char choice = Console.ReadKey().KeyChar;
    


    Player.Race HoldR;
    
    
    switch (choice)
        {
            case '1':
                
                HoldR = Player.Race.Human ;
                break;
            case '2':
                HoldR = Player.Race.Elf;
                break;
            case '3' :
                HoldR=Player.Race.Dragonborn;
                break;
            case '4' :
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
        
        
        Console.WriteLine($"Your final health is: {myCharacter.Health} try not to die");
        
        // Console.WriteLine("pick a weapon");
        // Console.WriteLine("1");
        //TODO

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.WriteLine("time to enter the STAT DUNGEON!");
        //TODO  game

// List of events (rooms) in the dungeon
        List<Event> events = new List<Event>
        {
            new StrengthRoom(10),     // Strength check DC 15
            new CharismaRoom(10),     // Charisma check DC 12
            new IntelligenceRoom(10), // Intelligence check DC 14
            new DexterityRoom(10),    // Dexterity check DC 10
            new WisdomRoom(10),       // Wisdom check DC 13
            new ConstitutionRoom(10)  // Constitution check DC 16
        };
    Shuffle(events);

  // Process each event (room)
        foreach (Event ev in events)
        {
            Console.WriteLine($"You entered a {ev.GetType().Name} room. Roll a d20 to pass the check (DC {ev.DifficultyCheck}).");
            Console.ReadKey();
            int roll = dice.DiceManager("D20");
            int mod= myCharacter.getStat(ev.roomStat);
            Console.WriteLine($"You rolled a {roll} + {mod} your modifier.");
            if (roll + mod >= ev.DifficultyCheck)
            {
                ev.TriggerGoodEvent();
            }
            else
            {
                ev.TriggerBadEvent();
                break; // Stop if player fails a room (for simplicity)
            }
        }

        Console.WriteLine("\nEnd of the adventure. Thanks for playing!");
    }
// Shuffle method to randomize the order of events
    static void Shuffle(List<Event> events)
    {
        Random rng = new Random();
        int n = events.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Event value = events[k];
            events[k] = events[n];
            events[n] = value;
        }
    
    }
}

