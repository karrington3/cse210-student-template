class Reflection : Activity{

    private List<string> prompts;
    private List<string> questions;

    public Reflection() {
        this.prompts = new List<string>() {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            };

            this.questions = new List<string>() {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    private void GetRndPrompt() {
        Random rng = new Random();

        int rndPrompt = rng.Next(prompts.Count - 1);
        
        Console.WriteLine($"--- {prompts[rndPrompt]} ---");
        Console.WriteLine("When you have something in mind, press any key to continue");
        Console.ReadKey();
    }

    private void GetRndQuestions(int time) {
        Random rng = new Random();

        int rndQuestion;
        List<int> chosenNums = new List<int>() {0, 0, 0, 0, 0, 0, 0, 0};

        DateTime start = DateTime.Now;
        DateTime fin = start.AddSeconds(time);

        while(DateTime.Now < end) {
            bool isNotDuplicate = false;
            int i = 0;

        do{
            rndQuestion = rng.Next(_questions.Count - 1);

                if (chosenNums[rndQuestion] == 0) {
                    isNotDuplicate = true;
                    chosenNums[rndQuestion] = 1;
                    i = 0;
                }
                else if (chosenNums[rndQuestion] == 1) {
                    isNotDuplicate = false;
                    i++;
                }
                } while(!isNotDuplicate && i < (_questions.Count + _questions.Count));

            if (i >= _questions.Count) {
                Console.WriteLine("All Questions Exhausted!");
                return;
            }
            Console.WriteLine($"> {_questions[rndQuestion]}");
            animation(5);

        }
    }

    public void ReflectingAct(){
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity\n");
        Console.WriteLine(@"This activity will help you reflect on times in your life when you have shown strength and resilience.
        This will help you recognize the power you have and how you can use it in other aspects of your life.");


        int seconds = SetDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        animation(5);
        GetRndPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);

        console.clear;

        GetRndQuestions(seconds);
        Console.WriteLine("Well done!!\n");
        animation(5);
        Console.WriteLine($"You have completed another {seconds} seconds of the Reflecting Activity");
        animation(5);

    }
        }