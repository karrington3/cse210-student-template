using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Verse v = new Verse();
        v.GetScripture();
        string userChoose = "";
        do {
        v.DisplayScripture();
        Console.WriteLine("1). New Scripture");
        Console.WriteLine("2). Exit");
        Console.WriteLine("Press enter to hide words");
        userChoose = Console.ReadLine();
        if (userChoose == "2" ) {
            break;
        }
        else if (userChoose == "1") {
            v.GetScripture();
        }
        else {
            // code for hiding words go here
            Console.WriteLine("else");
        }
        
        
        }while (true);



        string scripture = v.GetScripture();
        Console.WriteLine(scripture);
    }
}