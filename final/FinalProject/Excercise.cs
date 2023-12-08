class Exercise : Task
{
    public int Repetition { get; }
    public int Minutes { get; }

    public Exercise(string name, int point, bool complete, int repetition, int minutes)
        : base(name, point, complete)
    {
        Repetition = repetition;
        Minutes = minutes;
    }

    protected override void Complete()
    {
        Console.WriteLine($"{Name} completed by doing {Repetition} repetitions of exercise for {Minutes} minutes! +{Point} points");
        base.Complete();
    }
}