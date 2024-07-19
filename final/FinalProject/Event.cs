using System;

public abstract class Event
{
    public int DifficultyCheck { get; set; }
    public string roomStat;
    // Method to trigger a good event
    public abstract void TriggerGoodEvent();

    // Method to trigger a bad event
    public abstract void TriggerBadEvent();
}
