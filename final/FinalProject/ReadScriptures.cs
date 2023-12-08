class ReadScriptures : Task
{
    public int TimeReading { get; }
    public string FavoriteScripture { get; set; }
    public string Learned { get; set; }

    public ReadScriptures(string name, int point, bool complete, int timeReading) : base(name, point, complete)
    {
        TimeReading = timeReading;
        FavoriteScripture = "";
        Learned = "";
    }

    protected override void Complete()
    {
        Console.WriteLine($"{Name} completed by reading scriptures for {TimeReading} minutes! +{Point} points");
         GetUserInput();
        base.Complete();
    }

    public void GetUserInput()
    {
        Console.WriteLine($"Read the scriptures for {TimeReading} minutes.");

        Console.WriteLine("What scripture did you like the most?");
        FavoriteScripture = Console.ReadLine();

        Console.WriteLine("What did you learn from this scripture?");
        Learned = Console.ReadLine();
    }

}
