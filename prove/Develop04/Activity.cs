public abstract class Activity {
    private string[] anime = ["...","0..",".0.","..0"];
    private int duration = 12;

    public void animation(int time) {
        DateTime start =DateTime.Now;
        DateTime fin = start.AddSeconds(time);

    
        while(DateTime.Now < fin) {
            Console.Write(anime[0]);
            Thread.Sleep(200);
            Console.Write("\b\b\b\b");
            Console.Write(anime[1]);
            Thread.Sleep(200);
            Console.Write("\b\b\b\b");
            Console.Write(anime[2]);
            Thread.Sleep(200);
            Console.Write("\b\b\b\b");
            Console.Write(anime[3]);
            Thread.Sleep(200);
            Console.Write("\b\b\b\b");
        }
    }

    public void Countdown(int num) {
        for (int i = num; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(100);
            Console.Write("\b \b");

        }
    public int SetDuration() {
            //Had to do this long winded cast cause Console.Read was returning really weird numbers.
            Console.Write("How long, in seconds, for your session?: ");
            string Cast = Console.ReadLine();
            int.TryParse(Cast, out this. duration);
            return  duration;
    }
        public int GetDuration() {
        return  duration;
    }
    }

}

