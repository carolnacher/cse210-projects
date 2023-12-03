class PetCare : Task
{
    public int FedNumber { get; }
    public string Action { get; }
    public string Description { get; }

    public PetCare(string name, int point, bool complete, int fedNumber, string action, string description)
        : base(name, point, complete)
    {
        FedNumber = fedNumber;
        Action = action;
        Description = description;
    }
   protected override void Complete()
    {
        Console.WriteLine($"{Name} - {Description} completed by {Action} {FedNumber} times! {Point} points");
        base.Complete();
    }
}