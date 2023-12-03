class Exercise : Task
{
    public int Repetition { get; }

    public Exercise(string name, int point, bool complete, int repetition) : base(name, point, complete)
    {
        Repetition = repetition;
    }

    protected override void Complete()
    {
        Console.WriteLine($"{Name} completed by doing {Repetition} repetitions of exercise! +{Point} points");
        base.Complete();
    }
}