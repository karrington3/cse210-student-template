using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.givenName = "Joseph";
        person.familyName = "Smith";
        person.ShowWesternName();
        person.ShowEasternName();
    
    }
}
