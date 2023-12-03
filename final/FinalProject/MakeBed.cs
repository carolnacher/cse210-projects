class MakeBed : Task
{
    public int SheetsClean { get; }

    public MakeBed(string name, int point, bool complete, int sheetsClean) : base(name, point, complete)
    {
        SheetsClean = sheetsClean;
    }

    protected override void Complete()
    {
        Console.WriteLine($"{Name} completed by making the bed with {SheetsClean} clean sheets! +{Point} points");
        base.Complete();
    }
}