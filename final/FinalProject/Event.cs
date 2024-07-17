using System;

public class Event
{
    public int DifficultyCheck { get; set; }

    public void Trigger()
    {
        Console.WriteLine("a event have come. ");
        // Additional logic for good event
    }
    public Event(int difficultyCheck)
    {
        DifficultyCheck = difficultyCheck;
    }

    public void CheckRoll(int playerRoll)
    {
        Event Outcome;
        if (playerRoll >= DifficultyCheck)
        {
            Outcome = new GoodEvent();
            Outcome.Trigger();
        }
        else
        {
            Outcome= new BadEvent();
            Outcome.Trigger();
        }
    }
}
