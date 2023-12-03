class EternalGoal : Goal
{
    private int checkpointCount;

    public EternalGoal(string name, string description, int value) : base(name, description, value)
    {
        checkpointCount = 0;
    }

    public override void RecordEvent()
    {
        checkpointCount++;
        Console.WriteLine();
        Console.WriteLine($"Good Job with -> {Name} <- Etermal Goal. You do it!! gained {Value} points!");

        if (checkpointCount >= 2)  // Establece el punto de verificación deseado
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
