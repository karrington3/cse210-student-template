using System;
using System;
using System.Collections;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Prompts promptList = new Prompts("../../../promptList.txt");
        Entry userEntry = new Entry();
        Journal userJournal = new Journal();

        while(true) {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following choices:");

            Console.WriteLine("1: Write\n2: Display\n3: Load\n4: Save\n5: Quit");
            Console.WriteLine("What would you like to do?: ");
            string choice = Console.ReadLine();

            switch(choice) {
                case "1":
                    string prompt = userEntry.GeneratePrompt(promptList.prompt);
                    string response = Console.ReadLine();
                    userJournal.AddEntry(new Entry(response, prompt));
                    break;
                case "2":
                    userJournal.DisplayJournal();
                    Console.Read();
                    break;
                case "3":
                    Console.WriteLine("What is the filename? (must be inside program folder): ");
                    string userFile = Console.ReadLine();
                    userJournal.LoadJournal($"../../../{userFile}");
                    break;
                case "4":
                    Console.WriteLine("What is the filename? (do not include extensions): ");
                    string journalName = Console.ReadLine();
                    Console.WriteLine("Saving Journal...");
                    userJournal.SaveJournal(journalName);
                    Console.WriteLine("Saving Complete! Press any key to continue.");
                    Console.Read();
                    break;
                default:
                    break;
            }
            if (choice == "5") {
                break;
            }
        }

        
    }
}