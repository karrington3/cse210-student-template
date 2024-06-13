using Microsoft.VisualBasic;

class BreathingActivity() : Activity {
    

    private int breathIn =2;
    private int breathOut =3;
    private int breathIn2 =2;
    private int breathOut2 =3;

    public void breathAct() {
        Console.Clear();
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
        //int Amount = 0;
        int NewBreathingIn = breathIn;
        int NewBreathingOut = breathOut;


        DateTime start = DateTime.Now;
        DateTime End= start.AddSeconds (time);

        while (DateTime.Now < End){
            int breathInVisual = NewBreathingIn;
            int breathOutVisual = NewBreathingOut;


            Console.Write("breathe in.");
            for (int i = NewBreathingIn; i > 0;i--){
                Console.Write(breathInVisual);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                breathInVisual--;
            }
            Console.Write("\nNow breathe out.");
            for (int i = NewBreathingOut; i > 0; i--) {
                Console.Write(breathOutVisual);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                breathOutVisual--;
            }

            // if (Amount == 0) {
            //     NewBreathingIn += BreathInInc;
            //     NewBreathingOut += BreathOutInc;
            //     Amount++;
            //}
            Console.WriteLine("\n");
        }
    }

}