abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
     
    public int Value { get; protected set; }
    public bool Completed { get; set; }
    
    

    public Goal(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
        Completed = false;
    }

    public virtual void Display()
    {
        
        Console.WriteLine($"[{(Completed ? "X" : " ")}] {Name} - {Description} ");
       
    }
    public abstract void RecordEvent();
    
}