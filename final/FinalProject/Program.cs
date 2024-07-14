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
                myCharacter.CreateStats();
                bool reroll =true;
                while(reroll) 
                {myCharacter.CreateStats();
            Console.WriteLine("would you like to reroll :(  y/n");
            
            Console.WriteLine("pick a class : 1.bard 2.fighter 3.wizard");
            //TODO alway class to be picked
            Console.WriteLine("time to enter the STAT DUNGEON!");
            //TODO  game

    }
}
}