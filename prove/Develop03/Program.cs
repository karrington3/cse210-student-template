using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Verse v = new Verse();

        string scripture = v.GetScripture();
        Console.WriteLine(scripture);
    }
}