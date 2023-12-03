class ReadScriptures : Task
{
    public int TimeReading { get; }

    public ReadScriptures(string name, int point, bool complete, int timeReading) : base(name, point, complete)
    {
        TimeReading = timeReading;
    }

    protected override void Complete()
    {
        Console.WriteLine($"{Name} completed by reading scriptures for {TimeReading} minutes! +{Point} points");
        base.Complete();
    }
}