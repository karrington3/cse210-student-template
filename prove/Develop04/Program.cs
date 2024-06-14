using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("dfghjkhgfhj");
        //Activity animator = new Activity();
        BreathingActivity breathe = new BreathingActivity();
        ReflectionActivity reflect = new ReflectionActivity();
        ListingActivity list = new ListingActivity();
        int userChoice = -1;

        while(userChoice != 0){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  0. Exit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Convert.ToInt32(Console.ReadLine());

            switch(userChoice) 
            {
                case 0:
                    Console.WriteLine("See ya!");
                    breathe.animation(2);
                    break;
                case 1:
                    breathe.breathAct();
                    break;
                case 2:
                    reflect.ReflectingAct();
                    break;
                case 3:
                    list.ListingAct();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    list.animation(1);
                    break;
            }

        }
        
        //Animation.animation(12);
    
    }
}