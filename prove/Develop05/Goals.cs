using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

class Goals {

    protected bool isComplete;
    protected double points;
    protected string goal;
    protected int numCompleted;

    protected int level;
    protected List<string> levelTitle;
    protected double lvlUp;
    protected double totalPoints;

    public Goals(string g, int p) {
        goal = g;
        points = p;
        levelTitle = new List<string>() {
            "Fool",
            "Newbie",
            "Green Fool",
            "Experienced Newbie",
            "Achiever",
            "Intermediate Goaler",
            "Blue Fool",
            "Greater Achiever",
            "Advanced Goaler",
            "Super Achiever",
            "Royal Blue Fool",
            "Certified Gooner"
        };
    }

    public bool isCompleted() {
        return isComplete;
    }

    public virtual void Completed() {
        isComplete = true;
        totalPoints += points;
    }

    public void SetGoal(string g) {
        goal = g;
    }

    public string GetGoal() {
        return goal;
    }

    public virtual void DisplayGoal() {
        if (isComplete) {
            Console.WriteLine($"[X] {goal}");
        }
        else {
            Console.WriteLine($"[] {goal}");
        }
    }

    public void SetPoints(int p) {
        points = p;
    }

    public double GetPoints() {
        return points;
    }

    public void DisplayScore() {
        Console.WriteLine($"Level {level}: {levelTitle[level-1]}");
        Console.WriteLine($"Total Points: {totalPoints}");
    }

}