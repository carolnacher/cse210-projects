class Task
{
    public string Name { get; }
    public int Point { get; }
    public bool IsComplete { get; private set; }

    public Task(string name, int point, bool isComplete = false)
    {
        Name = name;
        Point = point;
        IsComplete = isComplete;
    }

    public void Perform()
    {
        if (!IsComplete)
        {
            MarkComplete();
        }
        else
        {
            Console.WriteLine($"Now you are ready to continue with others activities.");
        }
    }

    public void MarkComplete()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"well done!! you get {Point} points");
        }
        else
        {
            Console.WriteLine(" ");
        }
    }

    protected virtual void Complete()
    {
        Console.WriteLine($"Default implementation of {Name} task completed! {Point} points");
        MarkComplete();
    }
}
