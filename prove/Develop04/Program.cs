using System;

class Program
{
    static void Main(string[] args)
    {
        Activity animator = new Activity();
        Breathing breathe = new Breathing();
        Reflection reflect = new Reflection();
        Listing list = new Listing();
        int userChoice = 0;

        do {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  0. Exit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Convert.ToInt32(Console.ReadLine());

            switch(userChoice) 
            {
                case 0:
                    Console.WriteLine("See ya!");
                    animator.animation(2);
                    break;
                case 1:
                    breathe.BreathAct();
                    break;
                case 2:
                    reflect.ReflectAct();
                    break;
                case 3:
                    list.ListingAct();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    animator.animation(1);
                    break;
            }

        } while(userChoice != 0);
    }
}
        

        Animation.animation(12);
    
    }
}
}