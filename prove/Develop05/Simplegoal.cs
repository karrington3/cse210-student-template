using System;
using System.Collections.Generic;

public class SimpleGoal : Goals
{
    // Constructor for initializing a SimpleGoal object
    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        // The base class (Goal) constructor is called to initialize inherited members
    }

    
    public SimpleGoal(string title, string description, int points, bool complete) : base(title, description, points, complete)
    {}


    
    public override List<string> GetGoalInfoList()
    {
        // Create a list containing information about this SimpleGoal instance
        List<string> goalInfo = new List<string> { "Simple", $"{_title}", $"{_description}", $"{_points}", $"{_complete}" };
        return goalInfo;
    }
}