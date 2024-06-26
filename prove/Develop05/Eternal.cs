class Eternal : Goals {

    public Eternal(string g, int p) : base(g, p) {

    }

    public override void Completed()
    {
        numCompleted++;
        totalPoints += points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[] {goal}");
    }

}