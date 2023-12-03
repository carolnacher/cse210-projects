class CleanRoom : Task
{
    public CleanRoom(string name, int point, bool complete) : base(name, point, complete)
    {
    }

    protected override void Complete()
    {
        Console.WriteLine($"{Name} completed by cleaning the room! +{Point} points");
        base.Complete();
    }
}