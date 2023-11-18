class EternalGoal : Goal
{
    public EternalGoal(string name,string description,  int value) : base(name,description, value) { }

    public override void RecordEvent()
    {
        Completed = true;
        Console.WriteLine();
        Console.WriteLine($"Good Job with -> {Name} <- Eternal Goal. You gained {Value} points!");
    }
}