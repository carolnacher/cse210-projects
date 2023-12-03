class SimpleGoal : Goal
{
    private int checkpointCount;

    public SimpleGoal(string name, string description, int value) : base(name, description, value)
    {
        checkpointCount = 0;
    }

    public override void RecordEvent()
    {
        checkpointCount++;
        Console.WriteLine();
        Console.WriteLine($"Good Job with -> {Name} <- Simple Goal. You do it!! gained {Value} points!");

        if (checkpointCount >= 2) 
        {
            Completed = true;
            Console.WriteLine($"Congratulations! {Name} is completed. You earned additional points!");
        }
        else
        {
            Console.WriteLine($"You are closer to the goal {Name} - {checkpointCount}/2 times. Keep going!");
        }
    }
}
