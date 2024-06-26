class ListingActivity : Activity{
    private string[] prompts =  {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    private List<string> UserAnswers = new List<string>();

    public void GetPrompt(){
        Random rand = new Random();
        int randPrompt = rand.Next (prompts.Length - 1);
        Console.WriteLine($"--- {prompts[randPrompt]} ---");
    }
    public void GetInput(int time) {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(time);

        while(DateTime.Now < end) {
            Console.Write("> ");
            UserAnswers.Add(Console.ReadLine());   
        }
    
        int seconds = SetDuration();
        Console.Clear();
        
        Console.WriteLine("Get ready...");
        animation(5);
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        GetPrompt();

        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine("\n");
        GetInput(seconds);

        Console.WriteLine($"You listed {UserAnswers.Count} items!\n");

        Console.WriteLine("Well done!!");
        animation(5);
        Console.WriteLine($"You have completed another {seconds} seconds of the Listing Activity.");
        animation(5);
    }
    public void ListingAct() {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        GetInput(0);
        
    }
}
