class Checklist : Goals{

    private int amountComplete;

    public Checklist(string g, int p, int comp) : base(g, p) {
        this.amountComplete = comp;
    }

    public override void Completed()
    {
        numCompleted++;
        if (numCompleted == amountComplete) {
            isComplete = true;
            totalPoints += points;
        }
    }

    public override void DisplayGoal()
    {
        if (isComplete) {
            Console.WriteLine($"[X] {goal} -- Currently completed: {numCompleted}/{amountComplete}");
        }
        else {
            Console.WriteLine($"[] {goal} -- Currently completed: {numCompleted}/{amountComplete}");
        }
    }

}