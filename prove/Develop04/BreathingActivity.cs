class BreathingActivity() : Activity {
    

    private int breathIn =2;
    private int breathOut =3;
    private int breathIn2 =2;
    private int breathOut2 =3;

    public void breathAct() {
        console.clear();
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("we here to help with you breathing");
        Console.Write("\nHow long, in seconds, would you like for your session?: ");

        int seconds = SetDuration();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        animation(5);
        Console.WriteLine("\n");
        BreathTime(seconds);

        Console.WriteLine("\nGreat job you're done!");
        animation(5);

        Console.WriteLine($"You have completed another {seconds} seconds of the Breathing Activity.");
        animation(5);
    }

    private void BreathTime (int time){
        int Amount = 0;
        int NewBreathingIn = breathIn;
        int NewBreathingOut = breathOut;


        DateTime start = Datetime.Now;
        dateTime End= start.AddSeconds (time);

        while (DataTime.Now < fin){
            int breathInVisual = NewBreathingIn;
            int breathInVisual = NewBreathingOut;


            console.Write("breathe in.")
            for (int i = NewBreathingIn; i > 0;i--){
                console.Write(breathInVisual);
                thread.Sleep(1000);
                Console.Write("\b \b");
                breathInVisual--;
            }
            Console.Write("\nNow breathe out.");
            for (int i = newBreathOut; i > 0; i--) {
                Console.Write(breathOutVisual);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                breathOutVisual--;
            }

            if (IncAmount == 0) {
                newBreathIn += _breathInInc;
                newBreathOut += _breathOutInc;
                IncAmount++;
            }
            Console.WriteLine("\n");

        }
    }

}